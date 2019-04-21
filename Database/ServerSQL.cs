using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Database
{
    public sealed class ServerSQL : IDisposable
    {
        private string connectionString = String.Empty;
        private static string lasterrorString = String.Empty;
        public MySqlConnection myConnection;
        private bool serverConnected = false;
        private string databaseName = String.Empty;

        public static string LastError { get { return lasterrorString; } }

        public ServerSQL(bool localhost = false)
        {
            databaseName = Properties.Settings.Default.Database;
            string server = localhost ? "localhost" : Properties.Settings.Default.Host;
            connectionString = "server=" + server +
                ";user=" + Properties.Settings.Default.User +
                ";database=" + databaseName +
                ";port=" + Properties.Settings.Default.Port +
                ";password=" + Properties.Settings.Default.Password + ";";
            myConnection = new MySqlConnection(connectionString);
            serverConnected = tryToConnect();
        }

        public void Dispose()
        {
            myConnection.Dispose();
        }

        private bool tryToConnect()
        {
            try
            {
                // произведем попытку подключения
                myConnection.Open();
                lasterrorString = String.Empty;
                return true;
            }
            catch (Exception e)
            {
                lasterrorString = e.Message;
                return false;
            }
        }
    }
}
