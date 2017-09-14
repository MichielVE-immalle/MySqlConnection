using System;
using MySql.Data.MySqlClient;

namespace MySqlVerbinding
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT count(*) FROM Artiesten";

            conn.Open();

            int aantalArtiesten = (int)cmd.ExecuteScalar();

            Console.WriteLine("Aantal artiesten : {0}", aantalArtiesten);
        }
    }
}
