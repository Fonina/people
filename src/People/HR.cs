using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace People
{
    class HR
    {
        Person[] people;
        int size=0;
        int inc = 0;

        public HR(int size)
        {
            this.size = size;
            people = new Person[size];
        }

        public void Add(String surname, String name, int age)
        {
            if (inc > size) return;

            people[inc++]=new Person(surname,name,age);
        }

        public void Sort()
        {
            Array.Sort(people);
        }

        public bool writeToFile(String filename)
        {
            try
            {
                // добавление в файл
                using (StreamWriter writer = new StreamWriter(filename, false))
                {
                    for (int i = 0; i < size; i++)
                        writer.WriteLine(people[i].surname + " " + people[i].name + " " + people[i].age.ToString() + '\n');
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка записи в файл! Подробности:" + e.Message.ToString());
                return false;
            }

            return true;
        }
    }
}
