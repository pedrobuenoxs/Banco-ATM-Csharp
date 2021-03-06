using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace forms_teste
{
    public class dbLogin

    {
        public bool statusLogin = false;
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dbCmdReader;

        public String msg = "Login não autorizado";

        public void Status(string Nome, string Senha)
        {
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@senha", Senha);
            
            //Comando Sql
            cmd.CommandText = "select * from tblClientes where Nome = @nome and Senha = @senha";
            //textStatusLogin textStatusLogin = new textStatusLogin(Nome,senha);
            //paramePtros
            dbGetClienteID dbGetClienteID = new dbGetClienteID(Nome, Senha);
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            getContaSaldo getContaSaldo = new getContaSaldo(dbGetClienteID.id);
            try
            {   
                cmd.Connection = dbConexao.Connection();

                cmd.ExecuteNonQuery();

                dbCmdReader = cmd.ExecuteReader();

                if (dbCmdReader.HasRows)
                {
                    this.msg = "Logado com sucesso!";
                    this.statusLogin = true;
                    frm1.statusLogin.ForeColor = System.Drawing.Color.Green;
                    frm1.statusLogin.Text = "Connected!";
                    frm1.labelSaldo.Text = "R$ "+getContaSaldo.saldo;
                }               
            }
            catch (Exception e)
            {
                //caso der algum erro
                this.msg = "Erro ao tentar se conectar ao banco de dados";
                frm1.statusLogin.Text = "Not connected";
                statusLogin = false;
                frm1.statusLogin.ForeColor = System.Drawing.Color.Red;
            }
            
            
            
        }
    }
}
