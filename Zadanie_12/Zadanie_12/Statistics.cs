using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    public class Statistics
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public double Suma { get; private set; }
        public int Count { get; private set; }
        public double Average 
        {
            get 
            {
                return this.Suma / this.Count;
            }
        }
        public char AverageLetter 
        {
            get 
            {
                switch (this.Average)
                {
                    case var a when a >= 80:
                        return 'A';
                    case var a when a >= 60:
                        return 'B';
                    case var a when a >= 40:
                        return 'C';
                    case var a when a >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Min = double.MaxValue;
            this.Max = double.MinValue;
            this.Suma = 0;
            this.Count = 0;
        }
        public void AddGrade(double grade)
        {
            this.Count++;
            this.Suma += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);

        }
    }
}
