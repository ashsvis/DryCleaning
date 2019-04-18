using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Услуга")]
    public class Service : IComparable<Service>
    {
        public Guid IdService { get; set; } = Guid.NewGuid();

        [Description("Наименование"), DataNotEmpty, TextSize(200)]
        public string Name { get; set; }

        [Description("Описание")]
        public string Description { get; set; }

        [Description("Цена")]
        public decimal Price { get; set; }

        public int CompareTo(Service other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    [Description("Ассортимент")]
    public class Services : List<Service>
    {
        public new void Add(Service item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Услуга \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Service item)
        {
            base.Remove(item);
        }

    }
}
