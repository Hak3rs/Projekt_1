using System.Reflection.Metadata;
using Zad_6;
//pracownicy
Employee p1 = new Employee("Kamil", "Maciaszczyk", 26);
Employee p2 = new Employee("Kasia", "Miller", 31);
Employee p3 = new Employee("Krzysztof", "Ksiazek", 25);

List<Employee> pracownicy = new List<Employee>();
pracownicy.Add(p1);
pracownicy.Add(p2);
pracownicy.Add(p3);

//oceny
p1.DodajPKT(4);
p1.DodajPKT(5);
p1.DodajPKT(7);
p1.DodajPKT(10);
p1.DodajPKT(3);

p2.DodajPKT(6);
p2.DodajPKT(8);
p2.DodajPKT(9);
p2.DodajPKT(1);
p2.DodajPKT(3);

p3.DodajPKT(6);
p3.DodajPKT(8);
p3.DodajPKT(9);
p3.DodajPKT(5);
p3.DodajPKT(7);

int punkty = 0;
var corporation = Employee.firma;
Employee NajlepszyPracownik = null;

foreach (var pr in pracownicy)
{
    if (pr.suma_pkt > punkty)
    {
        punkty = pr.suma_pkt;
        NajlepszyPracownik = pr;
    }
}
Console.WriteLine("\nFirma: \t" + corporation);
Console.WriteLine("Imie: \t" + NajlepszyPracownik.imie);
Console.WriteLine("Nazwisko: \t" + NajlepszyPracownik.nazwisko);
Console.WriteLine("Wiek: \t" + NajlepszyPracownik.wiek);
Console.WriteLine("Punkty: \t" + NajlepszyPracownik.suma_pkt);