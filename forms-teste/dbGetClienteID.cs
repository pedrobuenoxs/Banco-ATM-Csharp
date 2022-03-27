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
        public String id;
        public string idCliente;

        public dbGetClienteID(String Nome, String Senha)
        {
            cmd.Parameters.AddWithValue("@nome", Nome);
            
            cmd.Parameters.AddWithValue("@senha", Senha);
            //Comando Sql
            
            // !!!!! PRECISO DESCOBRIR COMO ARMAZERNAR O VALOR DE UM SELECT
            cmd.CommandText = "select idCliente from tblClientes wherer Nome = @nomeCliente and Senha = @Senha";
            idCliente = Convert.ToString(cmd.Parameters[0].Value);
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
                this.msg = idCliente;



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