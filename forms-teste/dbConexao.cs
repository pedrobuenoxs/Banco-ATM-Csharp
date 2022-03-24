using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace forms_teste
{
    public class dbConexao
    {
        SqlConnection con = new SqlConnection();    
        //construtor
        public dbConexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-KKPDQLR;Initial Catalog=bancoAtm;Integrated Security=True";
        }
        //metodo conectar
        public SqlConnection Connection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;               

                 
        }
        //desconectar
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            

        }
        
    }

    
}
