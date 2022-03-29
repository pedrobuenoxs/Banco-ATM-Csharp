using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace forms_teste
{
    internal class getContaSaldo
    {
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();
        public bool statusCPF;
        SqlDataReader dbCmdReader;
        public String msg;
        public int saldo;
            

        public getContaSaldo(int id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            
            

            
            cmd.CommandText = "select Saldo from tblContas where idCliente = @id";


            //paramePtros         

            try
            {
                //conectar com bd                

                cmd.Connection = dbConexao.Connection();

                this.saldo = Convert.ToInt32(cmd.ExecuteScalar());

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
