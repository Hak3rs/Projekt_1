using Zad_9;

var emp1 = new Employee("Karol", "Mikasa");
/*emp1.AddGrade(6);
emp1.AddGrade(7);
emp1.AddGrade(2000);
emp1.AddGrade(8);
emp1.AddGrade(9);
emp1.AddGrade(3L);
emp1.AddGrade(8L);
emp1.AddGrade("4");
emp1.AddGrade(9.5f);
emp1.AddGrade(5);
emp1.AddGrade(9.8M);
emp1.AddGrade("Ola");*/
Console.WriteLine("Zatrzymanie liczba 11");
int nr = 1;
int grade;
while (true)
{
    Console.Write($"Podaj {nr} ocene: \t");
    grade = Int32.Parse(Console.ReadLine());
    emp1.AddGrade(grade);
    nr++;
    if (grade == 11)
    {
        break;
    }
}




var statemp1 = emp1.GetStatisticsWithForeach();
var statemp2 = emp1.GetStatisticsWithFor();
var statemp3 = emp1.GetStatisticsWithWhile();
var statemp4 = emp1.GetStatisticsWithDoWhile();


Console.WriteLine("==========FOREACH==========");
Console.WriteLine($"Average: \t{statemp1.Average:N2}");
Console.WriteLine($"Min: \t{statemp1.Min}");
Console.WriteLine($"Max: \t{statemp1.Max}");

Console.WriteLine("\n==========FOR==========");
Console.WriteLine($"Average: \t{statemp2.Average:N2}");
Console.WriteLine($"Min: \t{statemp2.Min}");
Console.WriteLine($"Max: \t{statemp2.Max}");
Console.WriteLine("\n==========WHILE==========");
Console.WriteLine($"Average: \t{statemp3.Average:N2}");
Console.WriteLine($"Min: \t{statemp3.Min}");
Console.WriteLine($"Max: \t{statemp3.Max}");
Console.WriteLine("\n==========DO WHILE==========");
Console.WriteLine($"Average: \t{statemp4.Average:N2}");
Console.WriteLine($"Min: \t{statemp4.Min}");
Console.WriteLine($"Max: \t{statemp4.Max}");

