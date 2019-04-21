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

        public bool ExecSQL(string SQL)
        {
            bool result = false;
            using (MySqlCommand command = new MySqlCommand(SQL, myConnection))
            {
                try
                {
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

        public void InsertInto(string table, Dictionary<string, string> columns)
        {
            // формирование запроса для изменения
            var props = new List<string>();
            var values = new List<string>();
            foreach (var key in columns.Keys)
            {
                props.Add($"`{key}`");
                var value = columns[key];
                //if (value.Length > 250) value = value.Substring(0, 250);
                values.Add($"'{value}'");
            }
            var sql = $"INSERT INTO `{table}` ({string.Join(",", props)}) VALUES ({string.Join(",", values)})";
            ExecSQL(sql);
        }

        public static bool HostIsLocalhost()
        {
            string host = Properties.Settings.Default.Host.ToLower();
            return host.Equals("localhost") || host.Equals("127.0.0.1");
        }

        public void WriteTableValue(string tableName, string[] props, string[] values)
        {
            if (serverConnected)
            {
                var propnames = string.Join("`,`", props);
                var propvalues = string.Join("','", values);
                var SQL = $"replace into `{tableName}` (`{propnames}`) values ('{propvalues}')";
                ExecSQL(SQL);
            }
        }


    }
}
