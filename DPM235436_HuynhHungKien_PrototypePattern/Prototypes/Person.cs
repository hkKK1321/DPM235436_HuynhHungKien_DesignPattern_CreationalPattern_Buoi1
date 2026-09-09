using System;

namespace DPM235436_HuynhHungKien_PrototypePattern
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        // Shallow Copy
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        // Deep Copy
        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();

            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(Name);

            return clone;
        }
    }
}