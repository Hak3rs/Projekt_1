using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddDelegate GradeAdded;
        private List<double> grades = new List<double>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
        public EmployeeInMemory(string name, string surname, int age, char sex) : base(name, surname, age, sex)
        {
            this.Name = name; ;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }

        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine("Thank you");
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    Console.WriteLine(grade);
                    GradeAdded(this,new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid Grade !!");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override void AddGrade(float grade)
        {
            double dgrade = (double)grade;
            this.AddGrade(dgrade);
        }

        public override void AddGrade(long grade)
        {
            double dgrade = (double)grade;
            this.AddGrade(dgrade);
        }

        public override void AddGrade(decimal grade)
        {
            double dgrade = (double)grade;
            this.AddGrade(dgrade);
        }

        public override void AddGrade(string grade)
        {
            if (double.TryParse(grade, out double dgrade))
            {
                this.AddGrade(dgrade);
            }
            else if (char.TryParse(grade, out char letter))
            {
                this.AddGrade(letter);
            }
            else
            {
                throw new Exception("Value is not DOUBLE");
            }
        }

        public override Statistics GetStatistics()
        {
            var stat = new Statistics();

            foreach (var grade in this.grades) 
            {
                stat.AddGrade(grade);
            }
            return stat;

        }
    }
}
