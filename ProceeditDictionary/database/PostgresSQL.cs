using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;

namespace ProceeditDictionary.database
{
    public class PostgresSQL
    {
        List<string> dataItems = new List<string>();

        public void PostgreSQL()
        { }

        public List<string> PostgresSQLT1()
        {
            try
            {
                var connString = "Host=18.184.42.152; Username=postgres; Password=Proc017postgres; Database=dyWORDS";

                using (var connection = new NpgsqlConnection(connString))
                {
                    connection.Open();
                    /*
                    // Insert some data
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO data (some_field) VALUES (@p)";
                        cmd.Parameters.AddWithValue("p", "Hello world");
                        cmd.ExecuteNonQuery();
                    }
                    */
                    // Retrieve all rows
                    using (var cmd = new NpgsqlCommand("SELECT * FROM word_main", connection))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            Console.WriteLine(reader.GetString(0));
                }
                /*
                    string connstring = "Server=18.184.42.152; User Id=postgres; Password=Proc017postgres; Database=dyWORDS;";
                    NpgsqlConnection connection = new NpgsqlConnection(connstring);
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT 1 as c1,2 as c2", connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();//select
                    //command.ExecuteNonQuery();//insert

                    for (int i=0; dataReader.Read();i++)
                    {
                        dataItems.Add(dataReader[0].ToString() + "," + dataReader[1].ToString() + "\r\n");
                    }
                */
                return dataItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
