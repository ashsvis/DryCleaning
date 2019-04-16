using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Должность")]
    public class Appointment : IComparable<Appointment>
    {
        public Guid IdAppointment { get; set; } = Guid.NewGuid();

        [Description("Наименование"), DataNotEmpty]
        public string Name { get; set; }

        [Description("Описание"), DataNotEmpty]
        public string Description { get; set; }

        [Description("Оклад")]
        public decimal Salary { get; set; }

        [Description("Процент с продаж")]
        public decimal SalesPercentage { get; set; }

        [Description("Инструкция"), DataNotEmpty]
        public string JobDescription { get; set; }

        public int CompareTo(Appointment other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    [Description("Должности")]
    public class Appointments : List<Appointment>
    {
        public new void Add(Appointment item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Должность \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Appointment item)
        {
            base.Remove(item);
        }

    }
}
