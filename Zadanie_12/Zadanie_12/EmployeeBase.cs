using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    public abstract class EmployeeBase : IEmployee
    {
        private const string corpo = "Hak3rs";
        public delegate void GradeAddDelegate(object sender, EventArgs args);
        public abstract event GradeAddDelegate GradeAdded;
        public EmployeeBase(string name, string surname, int age, char sex) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public char Sex { get; private set; }

        public abstract void AddGrade(double grade);

        public virtual void SayHello()
        {
            Console.WriteLine($"Welcome to company {corpo} ");
            Console.WriteLine("===================================================\n");
            Console.WriteLine($"Name:\t {Name}");
            Console.WriteLine($"Surname:\t {Surname}");
            Console.WriteLine($"Age:\t {Age}");
            Console.WriteLine($"Sex:\t {Sex}");
            Console.WriteLine("===================================================\n");
        }

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(decimal grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}
