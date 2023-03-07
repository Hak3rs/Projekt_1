using Zad_9;

var emp1 = new Employee("Karol", "Mikasa");
emp1.AddGrade(5);
emp1.AddGrade(6);
emp1.AddGrade(7);
emp1.AddGrade(8);
emp1.AddGrade(9);
emp1.AddGrade(10);
var statemp1 = emp1.GetStatistics();

Console.WriteLine($"Average: \t{statemp1.Average:N2}");
Console.WriteLine($"Min: \t{statemp1.Min}");
Console.WriteLine($"Max: \t{statemp1.Max}");

