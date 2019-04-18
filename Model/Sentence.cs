using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Предложение")]
    public class Sentence : IComparable<Sentence>
    {
        public Guid IdSentence { get; set; } = Guid.NewGuid();

        [Description("Наименование"), DataNotEmpty, TextSize(200)]
        public string Name { get; set; }

        [Description("Тип"), DataLookup("IdSentenceType", "SentenceTypes")]
        public Guid IdSentenceType { get; set; }

        [Description("Цена")]
        public decimal Price { get; set; }

        [Description("Описание")]
        public string Description { get; set; }

        public int CompareTo(Sentence other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    [Description("Предложения")]
    public class Sentences : List<Sentence>
    {
        public new void Add(Sentence item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Предложение \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Sentence item)
        {
            base.Remove(item);
        }

    }
}
