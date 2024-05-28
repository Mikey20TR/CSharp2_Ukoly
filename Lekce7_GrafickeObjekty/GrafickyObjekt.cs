using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce7_GrafickeObjekty
{
    public class GrafickyObjekt
    {
        public int Vyska;
        public int Sirka;
        public string Barva;

        public virtual void Vykreslit()
        {
            Console.WriteLine("X");
        }
        public void Vybarvi()
        {
            switch(Barva)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
        }
    }
    
    public class Obdelnik : GrafickyObjekt
    {
        public Obdelnik(int sirka, int vyska, string barva)
        {
            Sirka = sirka;
            Vyska = vyska;
            Barva = barva;
        }
        public override void Vykreslit()
        {
            Vybarvi();
            for (int cisloRadku = 1; cisloRadku <= Vyska; cisloRadku++)
            {
                for (int i = 0; i < Sirka; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
        }
    }
    public class Trojuhelnik : GrafickyObjekt
    {
        public Trojuhelnik(int vyska, string barva)
        {
            Vyska = vyska;
            Barva = barva;
        }
        public override void Vykreslit()
        {
            Vybarvi();
            for (int cisloRadku = 1; cisloRadku <= Vyska; cisloRadku++)
            {
                for (int i = 1; i <= cisloRadku; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
        }
    }
    public class Text : GrafickyObjekt
    {
        public string _Text;
        public Text(string text, string barva)
        {
            _Text = text;
            Barva = barva;
        }
            
        public override void Vykreslit()
        {
            Vybarvi();
            Console.WriteLine(_Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
