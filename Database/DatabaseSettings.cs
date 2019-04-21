using System;
using System.Collections.Generic;

namespace Database
{
    public static class DatabaseSettings
    {
        private static string lasterrorString = String.Empty;

        public static string LastError { get { return lasterrorString; } }


        public static bool CreateDatabase(string database)
        {
            bool result = CreateDatabase(true, database);
            if (!ServerSQL.HostIsLocalhost())
            {
                result = result && CreateDatabase(false, database);
            }
            return result;
        }

        public static bool CreateDatabase(bool localhost, string database)
        {
            bool result = false;
            using (ServerSQL server = new ServerSQL(localhost))
            {
                if (server.Connected)
                {
                    string SQL = $"CREATE DATABASE IF NOT EXISTS `{database}`" +
                                 " DEFAULT CHARACTER SET cp1251" +
                                 " DEFAULT COLLATE cp1251_general_ci";
                    try
                    {
                        server.ExecSQL(SQL);
                        lasterrorString = String.Empty;
                        result = true;
                    }
                    catch (Exception e)
                    {
                        lasterrorString = e.Message;
                        result = false;
                    }
                }
                else
                    lasterrorString = ServerSQL.LastError;
            }
            return result;
        }

        public static bool CreateTable(string database, string createSQL)
        {
            using (ServerSQL server = new ServerSQL(true, database))
            {
                if (server.Connected)
                {
                    try
                    {
                        server.ExecSQL("USE " + database);
                        server.ExecSQL("SET CHARSET cp1251");
                        server.ExecSQL(createSQL);
                        return true;
                    }
                    catch (Exception e)
                    {
                        lasterrorString = e.Message;
                        return false;
                    }
                }
            }
            return false;
        }

        public static bool UpdateTable(string database, string table, Dictionary<string, string> columns)
        {
            using (ServerSQL server = new ServerSQL(true, database))
            {
                if (server.Connected)
                {
                    try
                    {
                        server.ExecSQL("USE " + database);
                        server.ExecSQL("SET CHARSET cp1251");
                        server.InsertInto(table, columns);
                        return true;
                    }
                    catch (Exception e)
                    {
                        lasterrorString = e.Message;
                        return false;
                    }
                }
            }
            return false;
        }

        public static bool EmptyTable(string database, string table)
        {
            using (ServerSQL server = new ServerSQL(true, database))
            {
                if (server.Connected)
                {
                    try
                    {
                        server.ExecSQL("USE " + database);
                        server.ExecSQL($"DELETE FROM `{table}`");
                        return true;
                    }
                    catch (Exception e)
                    {
                        lasterrorString = e.Message;
                        return false;
                    }
                }
            }
            return false;
        }

        public static string Database
        {
            get { return Properties.Settings.Default.Database; }
            set
            {
                Properties.Settings settings = Properties.Settings.Default;
                settings.Database = value;
                settings.Save();
            }
        }

        public static string Host
        {
            get { return Properties.Settings.Default.Host; }
            set
            {
                Properties.Settings settings = Properties.Settings.Default;
                settings.Host = value;
                settings.Save();
            }
        }

        public static string Port
        {
            get { return Properties.Settings.Default.Port; }
            set
            {
                Properties.Settings settings = Properties.Settings.Default;
                settings.Port = value;
                settings.Save();
            }
        }

        public static string User
        {
            get { return Properties.Settings.Default.User; }
            set
            {
                Properties.Settings settings = Properties.Settings.Default;
                settings.User = value;
                settings.Save();
            }
        }

        public static string Password
        {
            get { return Properties.Settings.Default.Password; }
            set
            {
                Properties.Settings settings = Properties.Settings.Default;
                settings.Password = value;
                settings.Save();
            }
        }
    }
}
