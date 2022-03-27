using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
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
            con.ConnectionString = @"Data Source=DESKTOP-620JRHR;Initial Catalog=bancoSQL;Integrated Security=True;TrustServerCertificate=True";
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
