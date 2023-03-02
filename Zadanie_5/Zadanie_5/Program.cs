/*int[] grades = new int[5];
string[] days = { "PONIEDZIALEK", "WTOREK", "SRODA", "CZWARTEK", "PIATEK", "SOBOTA", "NIEDZIELA" };

Console.WriteLine("========================================");
Console.WriteLine("\tPETLA FOREACH");
Console.WriteLine("========================================");
foreach (var item in days)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n========================================");
Console.WriteLine("\tPETLA FOR");
Console.WriteLine("========================================");
for (int i = 0; i < days.Length; i=i+2)
{
    Console.WriteLine(days[i]);
}*/

/*List<string> imie = new List<string>();
imie.Add("Kamil");
imie.Add("Dominik");
imie.Add("Jakub");
imie.Add("Adam");
imie.Add("Krzysztof");
foreach (string name in imie)
{
    Console.WriteLine(name);
}*/
/*Wlasne cwiczenia <3

Console.WriteLine("Podaj liczbe: ");
string num1 = Console.ReadLine();
char[] num2 = num1.ToArray();
List<int> num3 = new List<int>();

for (int i = 0; i < num2.Length; i++)
{
    num3.Add((int)Char.GetNumericValue(num2[i]));
}
foreach (int i in num3)
{
    Console.WriteLine(i);
}


*/




//Zad_5

#region I_wersja
#region zmienne
int liczba1 = 8567894;
string numberIsString = liczba1.ToString();
char[] liczby = numberIsString.ToArray();
int liczba_0 = 0;
int liczba_1 = 0;
int liczba_2 = 0;
int liczba_3 = 0;
int liczba_4 = 0;
int liczba_5 = 0;
int liczba_6 = 0;
int liczba_7 = 0;
int liczba_8 = 0;
int liczba_9 = 0;
#endregion zmienne

#region ciało
for (int i = 0; i < liczby.Length; i++)
{
    if (liczby[i] == '0')
    {
        liczba_0++;
    }
    else if (liczby[i] == '1')
    {
        liczba_1++;
    }
    else if (liczby[i] == '2')
    {
        liczba_2++;
    }
    else if (liczby[i] == '3')
    {
        liczba_3++;
    }
    else if (liczby[i] == '4')
    {
        liczba_4++;
    }
    else if (liczby[i] == '5')
    {
        liczba_5++;
    }
    else if (liczby[i] == '6')
    {
        liczba_6++;
    }
    else if (liczby[i] == '7')
    {
        liczba_7++;
    }
    else if (liczby[i] == '8')
    {
        liczba_8++;
    }
    else
    {
        liczba_9++;
    }
}
Console.WriteLine("0===>" + liczba_0);
Console.WriteLine("1===>" + liczba_1);
Console.WriteLine("2===>" + liczba_2);
Console.WriteLine("3===>" + liczba_3);
Console.WriteLine("4===>" + liczba_4);
Console.WriteLine("5===>" + liczba_5);
Console.WriteLine("6===>" + liczba_6);
Console.WriteLine("7===>" + liczba_7);
Console.WriteLine("8===>" + liczba_8);
Console.WriteLine("9===>" + liczba_9);
#endregion ciało
#endregion I_wersja



#region II_Wersja
Console.WriteLine("Podaj liczbe: ");
string num1 = Console.ReadLine();
char[] num2 = num1.ToArray();
int[] liczby_razy = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; //tablica ilości liczb
for (int i = 0; i < num2.Length; i++)
{
    if (num2[i] == '0')
    {
        liczby_razy[0]++;
    }
    else if (num2[i] == '1')
    {
        liczby_razy[1]++;
    }
    else if (num2[i] == '2')
    {
        liczby_razy[2]++;
    }
    else if (num2[i] == '3')
    {
        liczby_razy[3]++;
    }
    else if (num2[i] == '4')
    {
        liczby_razy[4]++;
    }
    else if (num2[i] == '5')
    {
        liczby_razy[5]++;
    }
    else if (num2[i] == '6')
    {
        liczby_razy[6]++;
    }
    else if (num2[i] == '7')
    {
        liczby_razy[7]++;
    }
    else if (num2[i] == '8')
    {
        liczby_razy[8]++;
    }
    else
    {
        liczby_razy[9]++;
    }
}
for (int j = 0; j <=9; j++)
{
    Console.WriteLine("Liczba " + j + " występuje: " + liczby_razy[j]);
}
#endregion II_Wersja



