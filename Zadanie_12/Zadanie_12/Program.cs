using Zadanie_12;

Console.WriteLine("===================================================");
Console.WriteLine("WITAMY W PROGRAMIE DO WYSTAWIANIA OCEN PRACOWNINKOM");
Console.WriteLine("===================================================\n");
var emp1 = new Supervisor("Karol", "Mikasa", 28,'M');
Console.WriteLine("\n===================================================");
Console.WriteLine("PRACOWNIK");
Console.WriteLine("IMIE:\t" + emp1.Name);
Console.WriteLine("NAZWISKO:\t" + emp1.Surname);
Console.WriteLine("WIEK:\t" + emp1.Age);
Console.WriteLine("PLEC:\t" + emp1.Sex);
Console.WriteLine("===================================================\n");
Console.WriteLine("Zatrzymanie dodawania ocen: Q");

Console.WriteLine();

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
    try
    {
        emp1.AddGrade(grade);
    }
    catch(Exception e)
    {
        Console.WriteLine("Exception catched\t" + e.Message);
    }
    
}
var statemp1 = emp1.GetStatistics();

Console.WriteLine("==========FOREACH==========");
Console.WriteLine($"Average: \t{statemp1.Average:N2}");
Console.WriteLine($"Min: \t{statemp1.Min}");
Console.WriteLine($"Max: \t{statemp1.Max}");
Console.WriteLine($"Average Letter: \t{statemp1.AverageLetter}");


