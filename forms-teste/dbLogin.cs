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

            //paramePtros         

            try
            {   
                cmd.Connection = dbConexao.Connection();

                cmd.ExecuteNonQuery();

                dbCmdReader = cmd.ExecuteReader();

                if (dbCmdReader.HasRows)
                {
                    this.msg = "Logado com sucesso!";
                    this.statusLogin = true;                   
                }               
            }
            catch (Exception e)
            {
                //caso der algum erro
                this.msg = "Erro ao tentar se conectar ao banco de dados";                
                statusLogin = false;
            }
            
            
            
        }
    }
}
