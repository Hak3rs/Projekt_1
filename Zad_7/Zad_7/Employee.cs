using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_7
{
    public class Employee
    {
        public static string firma = "HAK3RS";
        //lista punktów
        private List<int> punkty = new List<int>();
        //konstruktor
        public Employee(string imie1, string nazwisko1, int wiek1)
        {
            this.imie = imie1;
            this.nazwisko = nazwisko1;
            this.wiek = wiek1;
        }

        //propetries
        public string imie
        {
            get;
            private set;
        }
        public string nazwisko
        {
            get;
            private set;
        }
        public int wiek
        {
            get;
            private set;
        }

        //punkty
        public void DodajPKT(int pkt)
        {
            this.punkty.Add(pkt);
        }
        public int suma_pkt
        {
            get
            {
                return punkty.Sum();
            }
        }
    }
}
