using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Сотрудник")]
    public class Employee : IComparable<Employee>
    {
        public Guid IdEmployee { get; set; } = Guid.NewGuid();

        [Description("Фамилия"), DataNotEmpty, TextSize(210)]
        public string Surname { get; set; }

        [Description("Имя"), DataNotEmpty, TableBrowsable(false)]
        public string FirstName { get; set; }

        [Description("Отчество"), DataNotEmpty, TableBrowsable(false)]
        public string LastName { get; set; }

        [Description("Дата приёма")]
        public DateTime ReceiptDate { get; set; }

        [Description("Адрес"), DataNotEmpty]
        public string Address { get; set; }

        [Description("Телефон")]
        public string PhoneNumber { get; set; }

        [Description("Паспорт"), DataNotEmpty]
        public string Passport { get; set; }

        [Description("Фотография"), DataNotEmpty, TableBrowsable(false)]
        public byte[] Photo { get; set; }

        [Description("Должность"), DataLookup("IdAppointment", "Appointments")]
        public Guid IdAppointment { get; set; }

        [Description("Замечания")]
        public string Notes { get; set; }

        [Description("Табельный номер"), TableBrowsable(false)]
        public string PersonnelNumber { get; set; }

        [Description("ИНН"), DataNotEmpty, TableBrowsable(false)]
        public string TIN { get; set; }

        [Description("Пенсионное свидетельство"), DataNotEmpty, TableBrowsable(false)]
        public string PensionCertificate { get; set; }

        [Description("Пол"), DataLookup("IdGender", "Genders"), TableBrowsable(false)]
        public Guid IdGender { get; set; }

        [Description("Дата рождения"), TableBrowsable(false)]
        public DateTime BirthDay { get; set; }

        [Description("Место рождения"), DataNotEmpty, TableBrowsable(false)]
        public string BirthPlace { get; set; }

        [Description("Образование"), TableBrowsable(false)]
        public string Education { get; set; }

        public int CompareTo(Employee other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return $"{Surname} {FirstName} {LastName}";
        }
    }

    [Serializable]
    [Description("Список сотрудников")]
    public class Employees : List<Employee>
    {
        public new void Add(Employee item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Сотрудник \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Employee item)
        {
            base.Remove(item);
        }

    }
}
