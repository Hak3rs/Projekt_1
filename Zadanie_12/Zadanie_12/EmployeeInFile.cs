using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string filename = "grades.txt";
        public EmployeeInFile(string name, string surname, int age, char sex) : base(name, surname, age, sex)
        {
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(filename))
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        writer.WriteLine(100);
                        break;
                    case 'B':
                    case 'b':
                        writer.WriteLine(80);
                        break;
                    case 'C':
                    case 'c':
                        writer.WriteLine(60);
                        break;
                    case 'D':
                    case 'd':
                        writer.WriteLine(40);
                        break;
                    case 'E':
                    case 'e':
                        writer.WriteLine(20);
                        break;
                    default:
                        throw new Exception("Wrong letter");
                        break;
                }
            }
        }

        public override void AddGrade(float grade)
        {
            double dgrade = (double)grade;
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(dgrade);
            }
        }

        public override void AddGrade(long grade)
        {
            double dgrade = (double)grade;
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(dgrade);
            }
        }

        public override void AddGrade(decimal grade)
        {
            double dgrade = (double)grade;
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(dgrade);
            }
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(filename))
            {
                if (double.TryParse(grade, out double dgrade))
                {
                    writer.WriteLine(dgrade);
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
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Min = double.MaxValue;
            result.Max = double.MinValue;
            result.Average = 0;
            int nr = 1;
            using (var reader = File.OpenText(filename)) 
            {
                var line = reader.ReadLine();
                if (File.Exists(filename))
                {
                    while (line != null)
                    {
                        var number = double.Parse(line);
                        Console.WriteLine(line);
                        result.Min = Math.Min(result.Min,number);
                        result.Max = Math.Max(result.Max,number);
                        result.Average += number;
                        line = reader.ReadLine();
                        nr++;
                    }
                    result.Average /= nr;
                    switch (result.Average)
                    {
                        case var a when a >= 80:
                            result.AverageLetter = 'A';
                            break;
                        case var a when a >= 60:
                            result.AverageLetter = 'B';
                            break;
                        case var a when a >= 40:
                            result.AverageLetter = 'C';
                            break;
                        case var a when a >= 20:
                            result.AverageLetter = 'D';
                            break;
                        default:
                            result.AverageLetter = 'E';
                            break;
                    }
                }
            }
            return result;
        }
    }
}
