using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        [Description("Описание"), TextSize(230)]
        public string Description { get; set; }

        [Description("Предложение"), DataLookup("IdSentence", "Sentences"), TableBrowsable(false), TableFilterable]
        public Guid IdSentence { get; set; }

        [Description("Количество")]
        public int Quantity { get; set; }

        public int CompareTo(Category other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return $"{IdService}{IdSentence}";
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

        public List<Category> FilteredBySentence(Guid idService)
        {
            return this.Where(item => item.IdSentence == idService).ToList();
        }
    }
}
