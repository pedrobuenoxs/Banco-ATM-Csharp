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
        public String msg;

        public dbSaque(double valor, int id)
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@valor", valor);

            cmd.CommandText = "update tblConta set Saldo = Saldo + @valor where idCliente = @id";

        }

        

    }
}
