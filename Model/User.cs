using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    public class User : IComparable<User>
    {
        public Guid IdUser { get; set; } = Guid.NewGuid();

        [Description("Сотрудник"), DataLookup("IdEmployee", "Employees")]
        public Guid IdEmployee { get; set; }

        [Description("Логин"), TextSize(210)]
        public string Login { get; set; }

        [Description("Пароль"), DataPassword]
        public string Password { get; set; }

        public int CompareTo(User other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return IdEmployee.ToString();
        }
    }

    [Serializable]
    [Description("Список пользователей")]
    public class Users : List<User>
    {
        public new void Add(User item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Пользователь \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(User item)
        {
            base.Remove(item);
        }

    }
}
