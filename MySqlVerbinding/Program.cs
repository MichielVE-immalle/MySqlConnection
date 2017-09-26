using System;
using MySql.Data.MySqlClient;

namespace MySqlVerbinding
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = 
                "Server=192.168.56.101;Port=3306;Database=Concerten;Uid=Imma;Pwd=imma;";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT count(*) FROM Artiesten";

            conn.Open();

            int aantalArtiesten = Convert.ToInt32(cmd.ExecuteScalar());

            Console.WriteLine("Aantal artiesten : {0}", aantalArtiesten);
        }
    }
}
