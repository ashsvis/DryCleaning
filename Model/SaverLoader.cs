using Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Model
{
    /// <summary>
    /// Класс поддержки чтения/записи конфигурации в файл на локальном диске
    /// </summary>
    public static class SaverLoader
    {
        /// <summary>
        /// Метод загрузки сохранённой ранее конфигурации из локального файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Root LoadFromFile(string fileName)
        {
            using (var fs = File.OpenRead(fileName))
            using (var zip = new GZipStream(fs, CompressionMode.Decompress))
            {
                var formatter = new BinaryFormatter();
                return (Root)formatter.Deserialize(zip);
            }
        }

        /// <summary>
        /// Метод сохранения конфигурации в файл на локальном диске
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="root"></param>
        public static void SaveToFile(string fileName, Root root)
        {
            using (var fs = File.Create(fileName))
            using (var zip = new GZipStream(fs, CompressionMode.Compress))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(zip, root);
            }
        }

        public static bool RestoreTables(Root root)
        {
            var database = "drycleaner";
            if (!DatabaseSettings.CreateDatabase(database)) return false;

            foreach (var tableName in root.GetTableNames())
            {
                var tableInfo = root.GetTableInfo(tableName);
                var type = tableInfo.Item.GetType();
                MemberInfo[] m = type.GetProperties();
                var columns = new Dictionary<string, Type>();
                foreach (var info in m)
                {
                    var prop = type.GetProperty(info.Name);
                    columns.Add(info.Name, prop.PropertyType);
                }
                DatabaseSettings.SelectTable(database, tableName, columns, tableInfo.Item, tableInfo.Table);
            }
            return false;
        }

        public static bool StoreTables(Root root)
        {
            var database = "drycleaner";
            if (!DatabaseSettings.CreateDatabase(database)) return false;

            foreach (var tableName in root.GetTableNames())
            {
                var tableInfo = root.GetTableInfo(tableName);
                var type = tableInfo.Item.GetType();
                MemberInfo[] m = type.GetProperties();
                var list = new List<string>();
                foreach (var info in m)
                {
                    var prop = type.GetProperty(info.Name);
                    var typeName = prop.PropertyType.ToString();
                    string coltype;
                    switch (typeName)
                    {
                        case "System.Guid":
                            coltype = "NVARCHAR( 50 )";
                            break;
                        default:
                            coltype = "NVARCHAR( 250 )";
                            break;
                    }
                    if (tableName == "Appointments" && 
                        (info.Name == "Description" || info.Name == "JobDescription") ||
                        tableName == "Employees" && info.Name == "Photo")
                        coltype = "LONGBLOB";
                    list.Add($"`{info.Name}` {coltype}");
                }
                var createSQL = $"CREATE TABLE IF NOT EXISTS `{tableName}` ({string.Join(", ", list)}) ENGINE = MYISAM";
                DatabaseSettings.CreateTable(database, createSQL);
                DatabaseSettings.EmptyTable(database, tableName);
                // получаем ссылку на коллекцию
                var collection = (IEnumerable<object>)tableInfo.Table;
                foreach (var item in collection)
                {
                    type = item.GetType();
                    m = type.GetProperties();
                    var columns = new Dictionary<string, object>();
                    foreach (var info in m)
                    {
                        var prop = type.GetProperty(info.Name);
                        columns.Add(info.Name, prop.GetValue(item));
                    }
                    DatabaseSettings.UpdateTable(database, tableName, columns);
                }

            }
            return true;
        }
    }
}
