using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexaoBanco
{
    class Conexao
    {
        const String server = "localhost";
        const String user = "root";
        const String pass = "";
        const String database = "db_rentalcar";

        

        public static MySqlConnection GetConnection ()

        {
            try
            {
                String myConnString = $"server{server};uid={user};pwd = {pass};database{database}";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = myConnString;
                return conn;
            }catch (Exception ex)
            {
                Console.WriteLine("ERRO DE CONEXÃO", ex.Message);
                return null;
            }


        }
    }
}
