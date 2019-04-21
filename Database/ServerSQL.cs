using System;
using System.Collections.Generic;
using System.Reflection;
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

        public void SelectFrom(string table, Dictionary<string, Type> columns, object modelClass, object modelTable)
        {
            // получаем ссылку на коллекцию
            var collection = (IEnumerable<object>)modelTable;
            // создаём пустой объект требуемого типа
            var item = Activator.CreateInstance(modelClass.GetType());
            // формируем данные для вызова метода Add коллекции объектов:
            // заказываем типы параметров для вызова метода
            Type[] parameterTypes = { item.GetType() };
            // создаём ссылку на метод Add, с формальным списком параметров 
            MethodInfo method = collection.GetType().GetMethod("Add", parameterTypes);

            var list = new List<string>();
            foreach (var key in columns.Keys)
                list.Add($"`{key}`");
            string SQL = $"SELECT {string.Join(",", list)} FROM `{table}`";
            using (MySqlCommand command = new MySqlCommand(SQL, myConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // создаём пустой объект требуемого типа
                            item = Activator.CreateInstance(modelClass.GetType());

                            for (var col = 0; col < reader.FieldCount; col++)
                            {
                                var propName = list[col].Trim('`');
                                PropertyInfo piInstance = item.GetType().GetProperty(propName);
                                var type = piInstance.PropertyType;
                                var value = reader.GetValue(col);
                                if (table == "Appointments" && (propName == "Description" || propName == "JobDescription"))
                                {
                                    piInstance.SetValue(item, reader.GetString(col));
                                }
                                else if (table == "Employees" && propName == "Photo")
                                {
                                    if (!reader.IsDBNull(col))
                                        piInstance.SetValue(item, (byte[])value);
                                }
                                else if (type == typeof(DateTime))
                                    piInstance.SetValue(item, Convert.ToDateTime(value));
                                else if (type == typeof(bool))
                                    piInstance.SetValue(item, Convert.ToBoolean(value));
                                else if (type == typeof(decimal))
                                    piInstance.SetValue(item, Convert.ToDecimal(value, 
                                        System.Globalization.CultureInfo.GetCultureInfo("en-US")));
                                else if (type == typeof(int))
                                    piInstance.SetValue(item, Convert.ToInt32(value));
                                else if (type == typeof(string))
                                    piInstance.SetValue(item, Convert.ToString(value));
                                else if (type == typeof(Guid))
                                    piInstance.SetValue(item, Guid.Parse(Convert.ToString(value)));
                                
                            }
                            // формируем массив значений параметров для передачи при вызове метода
                            object[] arguments = { item };
                            try
                            {
                                // вызываем метод на коллекции объектов с аргументами
                                method.Invoke(collection, arguments);
                            }
                            catch (Exception ex)
                            {
                                lasterrorString = ex.InnerException != null
                                    ? ex.InnerException.Message
                                    : ex.Message;
                            }
                        }
                    }
                }
            }
        }

        public static bool HostIsLocalhost()
        {
            string host = Properties.Settings.Default.Host.ToLower();
            return host.Equals("localhost") || host.Equals("127.0.0.1");
        }


    }
}
