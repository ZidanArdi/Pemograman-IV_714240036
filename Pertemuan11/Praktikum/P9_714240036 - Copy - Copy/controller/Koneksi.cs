using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace P9_714240036
{
    internal class Koneksi
    {
        string connectionString = "Server=localhost;Initial Catalog=pemrog2ulbi;Uid=root;Password=;";
        MySqlConnection kon;


        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionString);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }   

        public object ShowData(string query)
        {
            OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
            DataTable table = new DataTable();
            adapter.Fill(table);

            CloseConnection();
            return table;

        }

        public void ExecuteQuery(MySqlCommand command)
        {
            command.Connection = kon;
            command.ExecuteNonQuery();
        }

        public object ShowDataParam(string query, params MySqlParameter[] parameters)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, kon);
            cmd.Parameters.AddRange(parameters);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CloseConnection();
            return table;
        }

        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}