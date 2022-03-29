using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace forms_teste
{
    public class dbCadastroConta
    {
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();
        public bool statusCPF;
        //SqlDataReader dbCmdReader;
        public String msg;

        public dbCadastroConta(int id)
        {
            double saldo = 0;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@saldo", saldo);

            cmd.CommandText = "insert into tblContas values(@id,@saldo)";


            try
            {
                cmd.Connection = dbConexao.Connection();

                cmd.ExecuteNonQuery();

                dbConexao.Desconectar();

                this.msg = "Conta criada com sucesso!";


            }
            catch (Exception e)
            {
                this.msg = "Erro ao tentar se conectar ao banco de dados";
            }


        }
    }
}
