using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    public class Person
    {
        public Person(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            try
            {
                if (sex =='M'|| sex == 'K')
                {
                    this.Sex = sex;
                }
            } catch (Exception)
            {
                Console.WriteLine("EXCEPTION\tNIEPRAWIDLOWA PLEC !!!");
            }
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
    }
}
