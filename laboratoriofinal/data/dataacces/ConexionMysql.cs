using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratoriofinal.data.dataacces
{
    internal class ConexionMysql
    {
        string connectionString = "server=localhost;database=LaboratorioCRUD;user=root;password=Soynoob9182";
        MySqlConnection connection;


        //constructor
        public ConexionMysql()
        {
            connection = new MySqlConnection(connectionString);
        }
    }
}
