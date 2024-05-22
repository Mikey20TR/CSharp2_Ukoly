using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Lekce6_BreakOut2
{
    public class Obdelnik
    {
        private int sirka;
        public int Sirka
        { 
            get
            { 
                return sirka; 
            }
            private set
            {
                sirka = value;
                if (value <= 0)
                {
                    Console.WriteLine("Šířka obdélníku nesmí být menší než 1");
                    sirka = 1;
                }
                else
                {
                    sirka = value;
                }
            } 
        }
        private int vyska;
        public int Vyska
        {
            get
            {
                return vyska;
            }
            private set
            {
                vyska = value;
                if (value <= 0)
                {
                    Console.WriteLine("Výška obdélníku nesmí být menší než 1");
                    vyska = 1;
                }
                else
                {
                    vyska = value;
                }
            }
        }
        private int obsah;
        public int Obsah
        {
            get
            {
                return obsah;
            }
            set
            {
                obsah = Sirka * Vyska;
            }
        }
        private int obvod;
        public int Obvod
        {
            get
            {
                return obvod;
            }
            set
            {
                obvod = (Sirka * 2) + (Vyska * 2);
            }
        }

        public void Zvetsi()
        {
            Vyska++;
            Sirka++;
        }
        public Obdelnik(int sirka, int vyska)
        {
           Sirka = sirka;
           Vyska = vyska;
        }
        public Obdelnik(int sirka)
        {
            Sirka = sirka;
            Vyska = sirka;
        }
        public void VypisInformace()
        {
            if (Sirka == Vyska)
            {
                Console.WriteLine("Toto je čtverec");
            }
            Console.WriteLine("Šířka: " + Sirka);
            Console.WriteLine("Výška: " + Vyska);
            Console.WriteLine("Obsah: " + Obsah);
            Console.WriteLine("Obvod: " + Obvod);
            Console.WriteLine("");
        }
    }

}
