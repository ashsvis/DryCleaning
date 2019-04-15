using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Тип предложения")]
    public class SentenceType : IComparable<SentenceType>
    {
        public Guid IdSentenceType { get; set; } = Guid.NewGuid();

        [Description("Наименование"), DataNotEmpty]
        public string Name { get; set; }

        [Description("Описание"), DataNotEmpty]
        public string Description { get; set; }

        public int CompareTo(SentenceType other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    [Description("Типы предложений")]
    public class SentenceTypes : List<SentenceType>
    {
        public new void Add(SentenceType item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Тип предложения \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(SentenceType item)
        {
            base.Remove(item);
        }

    }
}
