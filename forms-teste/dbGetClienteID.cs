using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace forms_teste
{
    public class dbGetClienteID

    {
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();

        public String msg;
        public int id;
        SqlDataReader dr;
        

        public dbGetClienteID(String Nome, String Senha)
        {
            cmd.Parameters.AddWithValue("@nome", Nome);            
            cmd.Parameters.AddWithValue("@senha", Senha);
            //Comando Sql
            
            // !!!!! PRECISO DESCOBRIR COMO ARMAZERNAR O VALOR DE UM SELECT
            cmd.CommandText = "select idCliente from tblClientes where Nome = @nome and Senha = @senha";           

            
            //paramePtros         

            try
            {
                //conectar com bd                

                cmd.Connection = dbConexao.Connection();
                                                
                this.id = Convert.ToInt32(cmd.ExecuteScalar());
                
                dbConexao.Desconectar();
                


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