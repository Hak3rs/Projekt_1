using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_9
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
            else 
            {
                Console.WriteLine("Value is not DOUBLE");
            }
            
        }

        public Statistics GetStatisticsWithForeach()
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

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = double.MaxValue;
            statistics.Max = double.MinValue;

            for (int id = 0; id < this.grades.Count; id++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[id]);
                statistics.Min = Math.Min(statistics.Min, this.grades[id]);
                statistics.Average += this.grades[id];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = double.MaxValue;
            statistics.Max = double.MinValue;
            int id = 0;
            while (id < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[id]);
                statistics.Min = Math.Min(statistics.Min, this.grades[id]);
                statistics.Average += this.grades[id];
                id++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = double.MaxValue;
            statistics.Max = double.MinValue;
            int id = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[id]);
                statistics.Min = Math.Min(statistics.Min, this.grades[id]);
                statistics.Average += this.grades[id];
                id++;
            } while (id < this.grades.Count) ;
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
