using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace forms_teste
{
    public class dbDeposito

    {
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();

        public String msg = "Deposito não autorizado";

        public dbDeposito(double valor, int id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@valor", valor);

            //
            cmd.CommandText = "update tblContas set Saldo = Saldo + @valor where idCliente = @id";
            

             

            try
            {
                //conectar com bd                

                cmd.Connection = dbConexao.Connection();


                //executar comando
                cmd.ExecuteNonQuery();
                //desconect
                dbConexao.Desconectar();
                //msg
                this.msg = "Deposito realizado com sucesso!";



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
