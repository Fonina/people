using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace People
{
    class Person : IComparable<Person>
    {
        public String surname{get;set;}
        public String name{get;set;}
        public int age{get;set;}

        public Person(String surname, String name, int age)
        {
            this.surname = surname;
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person person)
        {
            //сначала идет сортировка по фамилии. Но если фамилия совпадает, то мы сортируем по имени.
            var ret = string.CompareOrdinal(surname, person.surname);
            if (ret != 0) return ret;
            return string.CompareOrdinal(name, person.name);
        }
    }
}
