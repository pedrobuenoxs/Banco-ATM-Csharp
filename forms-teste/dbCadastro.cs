using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace forms_teste
{
    public class dbCadastro

    {   
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();
        public bool statusCPF;
        SqlDataReader dbCmdReader;
        public String msg;

        public dbCadastro(String Nome,String Cpf,String Senha)
        {
            
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@senha", Senha);
            cmd.CommandText = "insert into tblClientes values(@nome,@cpf,@senha)";


            try
            {
                cmd.Connection = dbConexao.Connection();             
                                
                cmd.ExecuteNonQuery();
                
                dbConexao.Desconectar();
                
                this.msg = "Cadastrado com sucesso";

                
            }
            catch (Exception e)
            {               
                this.msg = "Erro ao tentar se conectar ao banco de dados";
            }
            


                                 
        }


        

    }
}
