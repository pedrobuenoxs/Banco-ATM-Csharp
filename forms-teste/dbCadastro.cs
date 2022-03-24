using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_teste
{
    public class dbCadastro

    {   
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();

        public String msg;

        public dbCadastro(String Nome,String Cpf,String Senha)
        {
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@senha", Senha);
            //Comando Sql
            cmd.CommandText = "insert into tblClientes values(@nome,@cpf,@senha)";

            //paramePtros
            
            




            try
            {
                //conectar com bd                
                cmd.Connection = dbConexao.Connection();

                //executar comando
                cmd.ExecuteNonQuery();
                //desconect
                dbConexao.Desconectar();
                //msg
                this.msg = "Cadastrado com sucesso";



            }
            catch (Exception e)
            {
                //caso der algum erro
                this.msg = "Erro ao tentar se conectar ao banco de dados";

            }
                
              
                
            
            //desconectar
            //mostrar msg
        }
    }
}
