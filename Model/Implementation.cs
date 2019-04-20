using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Реализация")]
    public class Implementation : IComparable<Implementation>
    {
        public Guid IdImplementation { get; set; } = Guid.NewGuid();

        [Description("Предложение"), DataLookup("IdSentence", "Sentences")]
        public Guid IdSentence { get; set; }

        [Description("Клиент"), DataLookup("IdClient", "Clients")]
        public Guid IdClient { get; set; }

        [Description("Ответственный сотрудник"), DataLookup("IdEmployee", "Employees")]
        public Guid IdEmployee { get; set; }

        [Description("Дата реализации")]
        public DateTime ImplementationDate { get; set; }

        [Description("Замечания"), TextSize(220)]
        public string Notes { get; set; }

        public int CompareTo(Implementation other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return $"{ImplementationDate.ToString()}{IdSentence}{IdClient}{IdEmployee}";
        }
    }

    [Serializable]
    [Description("Реализации")]
    public class Implementations : List<Implementation>
    {
        public new void Add(Implementation item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Реализация \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Implementation item)
        {
            base.Remove(item);
        }

    }

}
