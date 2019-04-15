using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Клиент")]
    public class Client : IComparable<Client>
    {
        public Guid IdClient { get; set; } = Guid.NewGuid();

        [Description("Фамилия"), DataNotEmpty]
        public string Surname { get; set; }

        [Description("Имя"), DataNotEmpty]
        public string FirstName { get; set; }

        [Description("Отчество"), DataNotEmpty]
        public string LastName { get; set; }

        [Description("Адрес"), DataNotEmpty]
        public string Address { get; set; }

        [Description("Паспорт"), DataNotEmpty]
        public string Passport { get; set; }

        [Description("Дата регистрации")]
        public DateTime RegistrationDate { get; set; }

        public int CompareTo(Client other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return $"{Surname} {FirstName} {LastName}";
        }
    }

    [Serializable]
    [Description("Клиенты")]
    public class Clients : List<Client>
    {
        public new void Add(Client item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Клиент \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Client item)
        {
            base.Remove(item);
        }

    }
}
