using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    public class Employee
    {
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        private List<double> grades = new List<double>();
        public string Name
        {
            get;
            private set;
        }

        public string Surname
        {
            get;
            private set;
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 10)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Grade !!");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(10);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(8);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(6);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(4);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(2);
                    break;
                default:
                    Console.WriteLine("Wrong letter");
                    this.grades.Add(0);
                    break;
            }
        }

        public void AddGrade(float grade)
        {
            double dgrade = (double)grade;
            this.AddGrade(dgrade);
        }

        public void AddGrade(long grade)
        {
            double dgrade = (double)grade;
            this.AddGrade(dgrade);
        }

        public void AddGrade(decimal grade)
        {
            double dgrade = (double)grade;
            this.AddGrade(dgrade);
        }

        public void AddGrade(string grade)
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
                Console.WriteLine("Value is not DOUBLE");
            }

        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = double.MaxValue;
            statistics.Max = double.MinValue;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            switch (statistics.Average)
            {
                case var a when a >= 8:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 6:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 4:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 2:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
