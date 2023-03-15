using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zadanie_12.EmployeeBase;

namespace Zadanie_12
{
    public interface IEmployee
    {
        Statistics GetStatistics();
        void AddGrade(double grade);
        void AddGrade(char grade);
        void AddGrade(float grade);
        public void AddGrade(long grade);

        void AddGrade(decimal grade);

        void AddGrade(string grade);

        event GradeAddDelegate GradeAdded;
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        char Sex { get; }
    }
}
