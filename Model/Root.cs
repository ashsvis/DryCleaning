using Database;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Root
    {
        public Services Services { get; set; }
        public SentenceTypes SentenceTypes { get; set; }
        public Sentences Sentences { get; set; }
        public Implementations Implementations { get; set; }
        public Employees Employees { get; set; }
        public Clients Clients { get; set; }
        public Categories Categories { get; set; }
        public Appointments Appointments { get; set; }
        public Genders Genders { get; set; }
        public Users Users { get; set; }

        public Root()
        {
            RegistryTables();
            if (DatabaseSettings.CreateDatabase("drycleaner"))
            {
                //DatabaseSettings.RestoreTables("drycleaner");
            }
        }

        public void RegistryTables()
        {
            Tables.Clear();

            if (Services == null) Services = new Services();
            RegistryTable("Services", new Service(), Services);

            if (SentenceTypes == null) SentenceTypes = new SentenceTypes();
            RegistryTable("SentenceTypes", new SentenceType(), SentenceTypes);

            if (Sentences == null) Sentences = new Sentences();
            RegistryTable("Sentences", new Sentence(), Sentences);

            if (Implementations == null) Implementations = new Implementations();
            RegistryTable("Implementations", new Implementation(), Implementations);

            if (Employees == null) Employees = new Employees();
            RegistryTable("Employees", new Employee(), Employees);

            if (Clients == null) Clients = new Clients();
            RegistryTable("Clients", new Client(), Clients);

            if (Categories == null) Categories = new Categories();
            RegistryTable("Categories", new Category(), Categories);

            if (Appointments == null) Appointments = new Appointments();
            RegistryTable("Appointments", new Appointment(), Appointments);

            if (Genders == null) Genders = new Genders();
            RegistryTable("Genders", new Gender(), Genders);

            if (Users == null) Users = new Users();
            RegistryTable("Users", new User(), Users);

        }

        public TableInfo GetTableInfo(string name)
        {
            return (TableInfo)Tables[name];
        }

        public string[] GetTableNames()
        {
            var list = new List<string>();
            foreach (var item in Tables.Keys)
                list.Add(item.ToString());
            list.Sort();
            return list.ToArray();
        }

        public Hashtable Tables { get; private set; } = new Hashtable();

        private void RegistryTable(string name, object item, object table)
        {
            if (Tables.ContainsKey(name)) return;
            Tables[name] = new TableInfo
            {
                TableName = name,
                Table = table,
                Item = item
            };
        }
    }

    [Serializable]
    public class TableInfo
    {
        public string TableName { get; set; }
        public object Table { get; set; }
        public object Item { get; set; }
    }
}
