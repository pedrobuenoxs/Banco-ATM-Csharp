using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace forms_teste
{
    internal class dbSaque
    {
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();
        public bool statusCPF;
        SqlDataReader dbCmdReader;
        public String msg = "Saque não autorizado!";
        

        public dbSaque(double valor, int id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@valor", valor);

            cmd.CommandText = "update tblContas set Saldo = Saldo - @valor where idCliente = @id";


            try
            {
                cmd.Connection = dbConexao.Connection();

                cmd.ExecuteNonQuery();

                dbConexao.Desconectar();

                this.msg = "Saque realizado com sucesso!";


            }
            catch (Exception e)
            {
                this.msg = "Erro ao tentar se conectar ao banco de dados";
            }

        }

        

    }
}
