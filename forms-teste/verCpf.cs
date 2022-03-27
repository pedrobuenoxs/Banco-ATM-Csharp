using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_teste
{
    internal class verCpf
    {

        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();
        public bool statusCPF;
        SqlDataReader dbCmdReader;

        public String msg;


        public verCpf(String Nome, String CPF)
        {
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@cpf", CPF);

            cmd.CommandText = "select * from tblClientes where CPF = @cpf";

            try
            {
                cmd.Connection = dbConexao.Connection();

                cmd.ExecuteNonQuery();

                dbCmdReader = cmd.ExecuteReader();

                if (dbCmdReader.HasRows)
                {
                    this.msg = "Já existe um usuário com este CPF";
                    this.statusCPF = true;


                }


            }
            catch (Exception e)
            {
                //caso der algum erro
                this.msg = "Erro ao tentar se conectar ao banco de dados";

                statusCPF = false;
            }
        }
    }
}
