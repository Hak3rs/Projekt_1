using Zadanie_12;

Console.WriteLine("===================================================");
Console.WriteLine("WITAMY W PROGRAMIE DO WYSTAWIANIA OCEN PRACOWNINKOM");
Console.WriteLine("===================================================\n");
var emp1 = new Employee("Karol", "Mikasa");
Console.WriteLine("Zatrzymanie dodawania ocen: Q");
int nr = 1;
while (true)
{
    Console.Write($"Podaj {nr} ocene: \t");
    var grade = Console.ReadLine();
    nr++;
    if (grade == "q" || grade=="Q")
    {
        break;
    }
    emp1.AddGrade(grade);
}
var statemp1 = emp1.GetStatistics();

Console.WriteLine("==========FOREACH==========");
Console.WriteLine($"Average: \t{statemp1.Average:N2}");
Console.WriteLine($"Min: \t{statemp1.Min}");
Console.WriteLine($"Max: \t{statemp1.Max}");
Console.WriteLine($"Average Letter: \t{statemp1.AverageLetter}");


