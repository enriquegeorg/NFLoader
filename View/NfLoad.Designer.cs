using System;

namespace NFLoad
{
    partial class NfLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chcAut = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstrutura = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Anexos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chcNcm = new System.Windows.Forms.CheckBox();
            this.chcCnpjEce = new System.Windows.Forms.CheckBox();
            this.chcCnpj = new System.Windows.Forms.CheckBox();
            this.txtMemorando = new System.Windows.Forms.TextBox();
            this.txtDespacho = new System.Windows.Forms.TextBox();
            this.txtNre = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtCnpjEce = new System.Windows.Forms.TextBox();
            this.txtNcm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chcAut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEstrutura);
            this.panel1.Controls.Add(this.txtServidor);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 93);
            this.panel1.TabIndex = 0;
            // 
            // chcAut
            // 
            this.chcAut.AutoSize = true;
            this.chcAut.Location = new System.Drawing.Point(308, 43);
            this.chcAut.Name = "chcAut";
            this.chcAut.Size = new System.Drawing.Size(107, 17);
            this.chcAut.TabIndex = 3;
            this.chcAut.Text = "Autenticação Sql";
            this.chcAut.UseVisualStyleBackColor = true;
            this.chcAut.CheckedChanged += new System.EventHandler(this.chcAut_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servidor";
            // 
            // btnEstrutura
            // 
            this.btnEstrutura.Location = new System.Drawing.Point(308, 9);
            this.btnEstrutura.Name = "btnEstrutura";
            this.btnEstrutura.Size = new System.Drawing.Size(75, 23);
            this.btnEstrutura.TabIndex = 4;
            this.btnEstrutura.Text = "Logar";
            this.btnEstrutura.UseVisualStyleBackColor = true;
            this.btnEstrutura.Click += new System.EventHandler(this.btnEstrutura_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(88, 12);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(206, 20);
            this.txtServidor.TabIndex = 3;
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(88, 62);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(206, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(88, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.chcNcm);
            this.panel2.Controls.Add(this.chcCnpjEce);
            this.panel2.Controls.Add(this.chcCnpj);
            this.panel2.Controls.Add(this.txtMemorando);
            this.panel2.Controls.Add(this.txtDespacho);
            this.panel2.Controls.Add(this.txtNre);
            this.panel2.Controls.Add(this.txtCnpj);
            this.panel2.Controls.Add(this.txtCnpjEce);
            this.panel2.Controls.Add(this.txtNcm);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 318);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(599, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(142, 227);
            this.dataGridView2.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Notas Fiscais";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 99;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anexos});
            this.dataGridView1.Location = new System.Drawing.Point(439, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(135, 227);
            this.dataGridView1.TabIndex = 16;
            //PasteClipboard(myDataGridView1);
            //this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(dataGridView1_KeyDown);
            // 
            // Anexos
            // 
            this.Anexos.HeaderText = "Anexos";
            this.Anexos.Name = "Anexos";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(666, 277);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chcNcm
            // 
            this.chcNcm.AutoSize = true;
            this.chcNcm.Location = new System.Drawing.Point(324, 192);
            this.chcNcm.Name = "chcNcm";
            this.chcNcm.Size = new System.Drawing.Size(59, 17);
            this.chcNcm.TabIndex = 15;
            this.chcNcm.Text = "Manter";
            this.chcNcm.UseVisualStyleBackColor = true;
            // 
            // chcCnpjEce
            // 
            this.chcCnpjEce.AutoSize = true;
            this.chcCnpjEce.Location = new System.Drawing.Point(324, 158);
            this.chcCnpjEce.Name = "chcCnpjEce";
            this.chcCnpjEce.Size = new System.Drawing.Size(59, 17);
            this.chcCnpjEce.TabIndex = 14;
            this.chcCnpjEce.Text = "Manter";
            this.chcCnpjEce.UseVisualStyleBackColor = true;
            // 
            // chcCnpj
            // 
            this.chcCnpj.AutoSize = true;
            this.chcCnpj.Location = new System.Drawing.Point(324, 128);
            this.chcCnpj.Name = "chcCnpj";
            this.chcCnpj.Size = new System.Drawing.Size(59, 17);
            this.chcCnpj.TabIndex = 13;
            this.chcCnpj.Text = "Manter";
            this.chcCnpj.UseVisualStyleBackColor = true;
            // 
            // txtMemorando
            // 
            this.txtMemorando.Location = new System.Drawing.Point(98, 35);
            this.txtMemorando.Name = "txtMemorando";
            this.txtMemorando.Size = new System.Drawing.Size(206, 20);
            this.txtMemorando.TabIndex = 12;
            // 
            // txtDespacho
            // 
            this.txtDespacho.Location = new System.Drawing.Point(98, 65);
            this.txtDespacho.Name = "txtDespacho";
            this.txtDespacho.Size = new System.Drawing.Size(206, 20);
            this.txtDespacho.TabIndex = 11;
            // 
            // txtNre
            // 
            this.txtNre.Location = new System.Drawing.Point(98, 96);
            this.txtNre.Name = "txtNre";
            this.txtNre.Size = new System.Drawing.Size(206, 20);
            this.txtNre.TabIndex = 10;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(98, 125);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(206, 20);
            this.txtCnpj.TabIndex = 9;
            // 
            // txtCnpjEce
            // 
            this.txtCnpjEce.Location = new System.Drawing.Point(98, 158);
            this.txtCnpjEce.Name = "txtCnpjEce";
            this.txtCnpjEce.Size = new System.Drawing.Size(206, 20);
            this.txtCnpjEce.TabIndex = 8;
            // 
            // txtNcm
            // 
            this.txtNcm.Location = new System.Drawing.Point(98, 192);
            this.txtNcm.Name = "txtNcm";
            this.txtNcm.Size = new System.Drawing.Size(206, 20);
            this.txtNcm.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "MEMORANDO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "DESPACHO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "NRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "CNPJ ECE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "NCM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DADOS DA NOTA";
            // 
            // NfLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NfLoad";
            this.Text = "NfLoad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void PasteClipboard(object myDataGridView1)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstrutura;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtSenha;
        
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chcNcm;
        private System.Windows.Forms.CheckBox chcCnpjEce;
        private System.Windows.Forms.CheckBox chcCnpj;
        private System.Windows.Forms.TextBox txtMemorando;
        private System.Windows.Forms.TextBox txtDespacho;
        private System.Windows.Forms.TextBox txtNre;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCnpjEce;
        private System.Windows.Forms.TextBox txtNcm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chcAut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anexos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

