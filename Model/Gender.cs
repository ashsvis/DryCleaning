using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewGenerator;

namespace Model
{
    [Serializable]
    [Description("Пол")]
    public class Gender : IComparable<Gender>
    {
        public Guid IdGender { get; set; } = Guid.NewGuid();
        [Description("Пол"), DataNotEmpty]
        public string Name { get; set; }

        public int CompareTo(Gender other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return Name;
        }

    }

    [Serializable]
    [Description("Выбор пола")]
    public class Genders : List<Gender>
    {
        public new void Add(Gender item)
        {
            if (base.Exists(x => x.ToString() == item.ToString()))
                throw new Exception($"Пол \"{item}\" уже существует!");
            base.Add(item);
            base.Sort();
        }

        public new void Remove(Gender item)
        {
            base.Remove(item);
        }

    }
}
