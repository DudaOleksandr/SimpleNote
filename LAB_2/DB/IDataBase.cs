using MySql.Data.MySqlClient;

namespace LAB_2
{
    internal interface IDataBase
    {
        void openCon();
        void closeCon();
        MySqlConnection GetConnection();
        MySqlDataAdapter GetAdapter();
        MySqlDataReader GetReader(MySqlCommand command);
    }
}