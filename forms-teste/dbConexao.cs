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
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pedro\source\repos\forms-teste\forms-teste\banco-atm.mdf;Integrated Security=True;Connect Timeout=30";
        }
        //metodo conectar
        public SqlConnection connection()
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
