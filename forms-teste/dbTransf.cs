using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace forms_teste
{
    internal class dbTransf
    {

        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();
        public String msg = "Transferência não autorizada!";

        public dbTransf(string nome, string senha, int idDestino, double valor)
        {
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@id", idDestino);
            cmd.Parameters.AddWithValue("@valor", valor);

            Conta conta = new Conta();
            conta.setSaldo(nome, senha);

            dbGetClienteID dbGetClienteID = new dbGetClienteID(nome, senha);

            dbLogin dbLogin = new dbLogin();
            dbLogin.Status(nome, senha);    


            int idOut = dbGetClienteID.id;



            if (dbLogin.statusLogin && conta.Sacar(valor))

            {
                dbSaque dbSaque = new dbSaque(valor, idOut);
                dbDeposito dbDeposito = new dbDeposito(valor, idDestino);
                MessageBox.Show("Transferência realizada com sucesso");


            }
            else
            {
                if (dbLogin.statusLogin == false)
                {
                    MessageBox.Show(dbLogin.msg);
                    return;
                }
                else if (!conta.Sacar(valor))
                {
                    MessageBox.Show(conta.statusSaque);
                    return;
                }
            }

        }
    }
}

