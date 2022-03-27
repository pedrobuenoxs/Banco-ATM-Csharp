using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace forms_teste
{
    public class dbLogin

    {
        dbConexao dbConexao = new dbConexao();
        SqlCommand cmd = new SqlCommand();

        public String msg;

        public dbLogin()
        {
                        
            try
            {                              
                cmd.Connection = dbConexao.Connection();
                this.msg = "Logado com sucesso!";            }
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
