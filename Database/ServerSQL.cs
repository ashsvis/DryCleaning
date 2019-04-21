using System;
using System.Collections.Generic;
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

        public ServerSQL(bool localhost, string database = null)
        {
            string server = localhost ? "localhost" : Properties.Settings.Default.Host;
            connectionString = "server=" + server +
                ";user=" + Properties.Settings.Default.User +
                ";port=" + Properties.Settings.Default.Port +
                ";password=" + Properties.Settings.Default.Password + ";";
            if (!string.IsNullOrWhiteSpace(database))
                connectionString += "database=" + Properties.Settings.Default.Database + ";";
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

        public bool Connected
        {
            get
            {
                return serverConnected;
            }
        }

        public string CurrentDatabase { get { return databaseName; } }

        public bool ExecSQL(string SQL, Dictionary<string, object> columns = null)
        {
            bool result = false;
            using (MySqlCommand command = new MySqlCommand(SQL, myConnection))
            {
                try
                {
                    if (columns != null)
                    {
                        foreach (var key in columns.Keys)
                            command.Parameters.AddWithValue($"@{key}", columns[key]);
                    }
                    command.ExecuteNonQuery();
                    lasterrorString = String.Empty;
                }
                catch (Exception e)
                {
                    lasterrorString = e.Message;
                    return false;
                }
            }
            return result;
        }

        public void InsertInto(string table, Dictionary<string, object> columns)
        {
            // формирование запроса для изменения
            var props = new List<string>();
            var values = new List<string>();
            foreach (var key in columns.Keys)
            {
                props.Add($"`{key}`");
                var value = columns[key];
                values.Add($"@{key}");
            }
            var sql = $"INSERT INTO `{table}` ({string.Join(",", props)}) VALUES ({string.Join(",", values)})";
            ExecSQL(sql, columns);
        }

        public static bool HostIsLocalhost()
        {
            string host = Properties.Settings.Default.Host.ToLower();
            return host.Equals("localhost") || host.Equals("127.0.0.1");
        }


    }
}
