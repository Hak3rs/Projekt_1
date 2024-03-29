﻿using Zadanie_12;

Console.WriteLine("===================================================");
Console.WriteLine("WITAMY W PROGRAMIE DO WYSTAWIANIA OCEN PRACOWNINKOM");
Console.WriteLine("===================================================\n");
var emp1 = new EmployeeInFile("Karol", "Mikasa", 28,'M');
emp1.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano Ocene");
}
Console.WriteLine("\n===================================================");
emp1.SayHello();
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


