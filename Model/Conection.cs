using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFLoad.Model
{
    public class Conection
    {
        public SqlConnection Conexao(DadosConexao conexao)
        {
            string connString =!(bool)conexao.IsChecked ? @"Data Source = " + conexao.Servidor + "; database = NFLoad ;integrated security = true;"
                                               : @"Data Source = " + conexao.Servidor + "; database = NFLoad ;integrated security = true;User id =" + conexao.Usuario + "; Password="+ conexao.Senha + ";";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: ");
                throw ex;
            }
            return conn;
        }


        public bool VerifyDb(DadosConexao conexao)
        {
            try
            {
                SqlConnection connection = Conexao(conexao);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "SELECT * FROM sys.databases WHERE name = 'NFLoad'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                reader = cmd.ExecuteReader();


                if (!reader.HasRows)
                {
                    CriarBanco(connection, conexao);
                    CreateStructure(Conexao(conexao), conexao);
                }
                connection.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
         }

        public void CriarBanco(SqlConnection sqlConnection, DadosConexao conexao)
        {
            sqlConnection.Dispose();
            sqlConnection.Close();
            sqlConnection = Conexao(conexao);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "CREATE DATABASE NFLoad";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            cmd.ExecuteReader();
            sqlConnection.Dispose();
            sqlConnection.Close();
        }

        public void CreateStructure(SqlConnection sqlConnection, DadosConexao conexao)
        {
            foreach (var item in CriarTabelas())
            {
                sqlConnection = Conexao(conexao);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = item;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection;
                cmd.ExecuteReader();
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }

        public List<string> CriarTabelas()
        {
            List<string> scripts = new List<string>();
            scripts.Add("CREATE TABLE MEMORANDOS ("+
                         "ID_MEMORANDO INT IDENTITY(1, 1) PRIMARY KEY,"                     +
                         "COD_TIPO_ESTRUTURA INT NOT NULL,"                                 +
                         "NRO_MEMORANDO VARCHAR(9) NOT NULL,"                               +
                         "NRO_DESPACHO VARCHAR(13) NOT NULL,"                               +
                         "CNPJ VARCHAR(30),"                                                +
                         "CNPJECE VARCHAR(30),"                                             +
                         "DATA_INSERT DATETIME NOT NULL DEFAULT(GETDATE())); "             );            

            scripts.Add("CREATE TABLE NCM ("                                                +
                        "ID_NCM INT IDENTITY(1, 1) PRIMARY KEY,"                            +
                        "NRO_NCM VARCHAR(9) NOT NULL,"                                      +
                        "ID_MEMORANDO INT NOT NULL,"                                        +
                        "FOREIGN KEY(ID_MEMORANDO) REFERENCES MEMORANDOS(ID_MEMORANDO)); " );

            scripts.Add(" CREATE TABLE NRODE ("                                             +
                         "ID_NRE INT IDENTITY(1, 1) PRIMARY KEY,"                           +
                         "NRO_ANEXO VARCHAR(9) NOT NULL,"                                   +
                         "NRO_RE VARCHAR(9) NOT NULL,"                                      +
                         "ID_MEMORANDO INT NOT NULL,"                                       +  
                         "FOREIGN KEY(ID_MEMORANDO) REFERENCES MEMORANDOS(ID_MEMORANDO)); ");

            scripts.Add(" CREATE TABLE NRONF ("                                             +
                           "ID_NF INT IDENTITY(1, 1) PRIMARY KEY,"                          +
                           "NRO_NF VARCHAR(9) NOT NULL,"                                    +
                           "ID_MEMORANDO INT NOT NULL,"                                     +
                          "FOREIGN KEY(ID_MEMORANDO) REFERENCES MEMORANDOS(ID_MEMORANDO));");

            scripts.Add("CREATE TABLE DUE ("                                                +
                          "ID_DUE INT IDENTITY(1, 1) PRIMARY KEY,"                          +
                          "NRO_DUE VARCHAR(9) NOT NULL,"                                    +
                          "ID_MEMORANDO INT NOT NULL,"                                      +  
                          "ID_NCM INT,"                                                     +
                          "FOREIGN KEY(ID_NCM) REFERENCES NCM(ID_NCM),"                     +
                          "FOREIGN KEY(ID_MEMORANDO) REFERENCES MEMORANDOS(ID_MEMORANDO)); ");
            return scripts;
                     
        }
    }
}
