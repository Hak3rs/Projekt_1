/*int myAge = 24;
int newAge = myAge + 5;
var myYear = 1998;
var myMonth = "Czerwiec";
var myDay = 18;
    Console.WriteLine("====================");
    Console.WriteLine("Moj wiek:\t" + myAge);
    Console.WriteLine("NEW AGE:\t" + newAge);
    Console.WriteLine("Moj rok:\t" + myYear);
    Console.WriteLine("Moj wiek:\t" + myMonth);
    Console.WriteLine("Moj wiek:\t" + myDay);
    Console.WriteLine("====================\n");

string name = "Dominik";
string surname = "Ksiazek";
char myVar5 = '_';
    Console.WriteLine(name + myVar5 + surname);
var result = name.ToArray();
bool isActive = true;
    Console.WriteLine(isActive);
isActive = false;
    Console.WriteLine(isActive);*/


//&& = i
// || = lub
//!() = negacja
/*int[] nr = new int[2];
    for (int i = 0; i <= 1 ; i++)
    {
        Console.WriteLine("Podaj liczbe: ");
        nr[i]=Int32.Parse(Console.ReadLine());
    }

    if (nr[0] < nr[1])
    {
        Console.WriteLine("Liczba nr[0] < nr[1]\nnr[0] = " + nr[0]);
    }
    else if (nr[0] == nr[1])
    {
        Console.WriteLine("Liczba nr[0] = nr[1]");
        Console.WriteLine("nr[0] = " + nr[0]);
        Console.WriteLine("nr[1] = " + nr[1]);
    }
    else
    {
        Console.WriteLine("Liczba nr[1] < nr[0]\nnr[1] = " + nr[1]);
    }
*/

//ZAD DZ.4
string imie;
int wiek;
string plec;
    Console.WriteLine("Podaj imie: ");
    imie = Console.ReadLine();

    Console.WriteLine("Podaj wiek: ");
    wiek = Int32.Parse(Console.ReadLine());

if (wiek < 18)
{
    Console.WriteLine("Wybierz plec [M/K]: ");
    plec = Console.ReadLine();
    if (plec == "M")
    {
        Console.WriteLine("Niepelnoletni mezczyzna");
    }
    else if (plec == "K")
    {
        Console.WriteLine("Niepelnoletnia kobieta");
    }
    else
    {
        Console.WriteLine("Niewlasciwa plec");
    }

}
else if (wiek >= 18 && wiek < 50)
{
    Console.WriteLine("Wybierz plec [M/K]: ");
    plec = Console.ReadLine();
    if (plec == "M")
    {
        Console.WriteLine("Mezczyzna w wieku " + wiek + " lat");
        Console.WriteLine("Imie: " + imie);
    }
    else if (plec == "K")
    {
        Console.WriteLine("Kobieta w wieku " + wiek + " lat");
        Console.WriteLine("Imie: " + imie);
    }
    else
    {
        Console.WriteLine("Niewlasciwa plec");
    }
}
else
{
    Console.WriteLine("Wybierz plec [M/K]: ");
    plec = Console.ReadLine();
    if (plec == "M")
    {
        Console.WriteLine("W podeszlym wieku mezczyzna " + wiek + " lat");
        Console.WriteLine("Imie: " + imie);
    }
    else if (plec == "K")
    {
        Console.WriteLine("W podeszlym wiekukobieta " + wiek + " lat");
        Console.WriteLine("Imie: " + imie);
    }
    else
    {
        Console.WriteLine("Niewlasciwa plec");
    }
}


