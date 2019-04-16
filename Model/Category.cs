using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Категория")]
    public class Category : IComparable<Category>
    {
        public Guid IdCategory { get; set; } = Guid.NewGuid();

        [Description("Ассортимент"), DataLookup("IdService", "Services")]
        public Guid IdService { get; set; }

        [Description("Описание")]
        public string Description { get; set; }

        [Description("Предложение"), DataLookup("IdSentenceType", "SentenceTypes")]
        public Guid IdSentenceType { get; set; }

        [Description("Количество")]
        public int Quantity { get; set; }

        public int CompareTo(Category other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return $"{IdService}{IdSentenceType}";
        }
    }

    [Serializable]
    [Description("Категории")]
    public class Categories : List<Category>
    {
        public new void Add(Category item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Категория \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Category item)
        {
            base.Remove(item);
        }

    }
}
