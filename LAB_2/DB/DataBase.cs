using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class DataBase : IDataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=logging");

        public void openCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public  MySqlConnection GetConnection()
        {
            return connection;
        }
      public MySqlDataAdapter GetAdapter()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            return adapter;
        }
        public MySqlDataReader GetReader(MySqlCommand command)
        {
            //MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
