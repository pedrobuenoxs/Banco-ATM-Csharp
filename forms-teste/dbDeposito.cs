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

        public String msg;

        public dbDeposito(String Nome, String Senha, double valor )
        {
            cmd.Parameters.AddWithValue("@nomeCliente", Nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@senha", Senha);
            
            //Comando Sql
            int id = Convert.ToInt32(cmd.CommandText = "select idCliente from tblClientes wherer Nome = @nomeCliente and Senha = @Senha");
            //cmd.CommandText = "insert into tblConta values(@nome,@cpf,@senha)";

            /*
             * select idCliente from tblClientes
            where Nome = 'Pedro'
            and Senha = '123456'*/

            //
            cmd.CommandText = "update tblConta set Saldo = Saldo + @valor where idCliente = @id";
            

            /*update tblConta
            set Saldo = Saldo + 100
            where idCliente = 1*/

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
                this.msg = "Deposito realizado com sucesso!";



            }
            catch (Exception e)
            {
                //caso der algum erro
                this.msg = "Deposito não autorizado!";

            }




            //desconectar
            //mostrar msg
        }
    }
}
