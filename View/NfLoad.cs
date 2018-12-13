using NFLoad.Controler;
using NFLoad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NFLoad
{
    public partial class NfLoad: Form 
    {
        Conection conection = new Conection();
        NfLoadController loadController = new NfLoadController();
        public NfLoad()
        {
           
            InitializeComponent();
            txtSenha.PasswordChar = '*';
            txtSenha.Enabled = false;
            txtUsuario.Enabled = false;
            panel2.Visible = false;
            btnEstrutura.Enabled= false;         
        }

        public void ValidacaoSql()
        {
            if (chcAut.Checked)
            {
                txtSenha.Enabled = true;
                txtUsuario.Enabled = true;
            }else
            {
                txtSenha.Enabled = false;
                txtUsuario.Enabled = false;
            }
        }

        private void btnEstrutura_Click(object sender, EventArgs e)
        { 
            try
            {                
                panel2.Visible = conection.VerifyDb(DadosConexao()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível logar");                
            }            
        }

        private void chcAut_CheckedChanged(object sender, EventArgs e)
        {
            ValidacaoSql();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {   
            if(CamposObrigatorios())
            MessageBox.Show("Campos obrigatórios a serem preenchidos!");
            else
            {
                SalvarLoad();
            }
        }

        public void SalvarLoad()
        {            
           // loadController. Salvar(CarregarObjetos(),DadosConexao());
            LimparCampos();
        }
        
        public DadosConexao DadosConexao()
        {
            DadosConexao conexao = new DadosConexao()
            {
                Servidor  = txtServidor.Text,
                Usuario   = txtUsuario.Text,
                Senha     = txtSenha.Text,
                IsChecked = chcAut.Checked
        };

            return conexao;
        }

        public object[]  CarregarObjetos()
        {
            object[] result = new object[5];
            result[0] = new Ncm()
            {
                NumeroNcm = txtNcm.Text
            };
            result[1] = new Due() {
            };
            result[2] = new Memorandos() {
                CodStrutura ="2",
                NumeroMemorando= txtMemorando.Text,
                NumeroDespacho = txtDespacho.Text,
                Cnpj = txtCnpj.Text,
                CnpjEce = txtCnpjEce.Text,
                DataSalva = DateTime.Now
            };
            result[3] = new NroDe()
            {
                NumeroAnexo = "",
                NumeroRe = ""
            };
            result[4] = new NroNf()
            {
                NumeroNf = ""
            };
            return result;
        }


        public void LimparCampos()
        {
            txtCnpj.Text = !chcCnpj.Checked? "": txtCnpj.Text;
            txtCnpjEce.Text =!chcCnpjEce.Checked? "": txtCnpjEce.Text;
            txtNcm.Text = !chcNcm.Checked?"": txtNcm.Text;
            txtDespacho.Text = "";
            txtMemorando.Text = "";           
            txtNre.Text = "";
        }

        public bool CamposObrigatorios()
        {
             return
             
             (string.IsNullOrWhiteSpace(txtCnpj.Text)    ||
             string.IsNullOrWhiteSpace(txtCnpjEce.Text)  ||
             string.IsNullOrWhiteSpace(txtDespacho.Text) ||
             string.IsNullOrWhiteSpace(txtMemorando.Text)||
             string.IsNullOrWhiteSpace(txtNcm.Text)      ||
             string.IsNullOrWhiteSpace(txtNre.Text));
                
            
        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            btnEstrutura.Enabled =( !string.IsNullOrWhiteSpace(txtServidor.Text))?true:false;
        }

        //private void PasteClipboard(DataGridView myDataGridView1)
        //{
        //    DataObject o = (DataObject)Clipboard.GetDataObject();
        //    if (o.GetDataPresent(DataFormats.Text))
        //    {
        //        if (myDataGridView1.RowCount > 0)
        //            myDataGridView1.Rows.Clear();

        //        if (myDataGridView1.ColumnCount > 0)
        //            myDataGridView1.Columns.Clear();

        //        bool columnsAdded = false;
        //        string[] pastedRows = System.Text.RegularExpressions.Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
        //        foreach (string pastedRow in pastedRows)
        //        {
        //            string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

        //            if (!columnsAdded)
        //            {
        //                for (int i = 0; i < pastedRowCells.Length; i++)
        //                    myDataGridView1.Columns.Add("col" + i, pastedRowCells[i]);

        //                columnsAdded = true;
        //                continue;
        //            }

        //            myDataGridView1.Rows.Add();
        //            int myRowIndex = myDataGridView1.Rows.Count - 1;

        //            using (DataGridViewRow myDataGridView1Row = myDataGridView1.Rows[myRowIndex])
        //            {
        //                for (int i = 0; i < pastedRowCells.Length; i++)
        //                    myDataGridView1Row.Cells[i].Value = pastedRowCells[i];
        //            }
        //        }
        //    }
        //}

        void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = dataGridView1.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = dataGridView1.CurrentCell.RowIndex;
                int col = dataGridView1.CurrentCell.ColumnIndex;
                foreach (string line in lines)
                {
                    if (row < dataGridView1.RowCount && line.Length >
0)
                    {
                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                        {
                            if (col + i < this.dataGridView1.ColumnCount)
                            {
                                dataGridView1[col + i, row].Value = Convert.ChangeType(cells[i], dataGridView1[col + i, row].ValueType);
                            }
                            else
                            {
                                break;
                            }
                        }
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
