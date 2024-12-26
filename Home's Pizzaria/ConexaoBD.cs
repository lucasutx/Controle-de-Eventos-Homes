using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_s_Pizzaria
{
    class ConexaoBD
    {
        SqlConnection con = new SqlConnection();
        public ConexaoBD() 
        {
            con.ConnectionString = "Data Source=DESKTOP-LUCAS;Initial Catalog=Homes;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;

        }

        public void Desconectar () 
        {

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }


    }
}
