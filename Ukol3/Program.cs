namespace Ukol3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            Console.WriteLine("Aktuální datum a čas:");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("");

            //// 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
            //DateTime datumNarozeni = new DateTime(0001,01,01);
            //Console.WriteLine("Zadej datum svého narození:");
            //datumNarozeni = DateTime.Parse(Console.ReadLine());
            //string datumText = datumNarozeni.ToString("dd.MM.yyyy");
            //TimeSpan ts = DateTime.Today - datumNarozeni;
            //Console.WriteLine($"Od tvého narození dne {datumText} uplynulo {ts.TotalDays} dní");
            //Console.WriteLine("");

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> planety = new List<string>() { "Merkur", "Země", "Mars", "Saturn", "Pluto" };
            Console.WriteLine($"Seznam {planety.Count} planet:");
            foreach (string planeta in planety)
            {
                Console.Write(planeta+ ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            planety.Remove("Pluto");
            Console.WriteLine("Pluto ale smažeme, protože to není planeta.");
            Console.WriteLine($"Nyní už máme seznam pouze {planety.Count} planet:");
            foreach (string planeta in planety)
            {
                Console.Write(planeta + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            //Console.WriteLine("Zadej libovolnou planetu a zjisti zda ji náš seznam obsahuje:");
            //string planetaVstup = Console.ReadLine();
            //if (planety.Contains(planetaVstup))
            //{
            //    Console.WriteLine($"Ano, planeta {planetaVstup} je na seznamu");
            //}
            //else
            //{
            //    Console.WriteLine($"Ne, planeta {planetaVstup} není na seznamu");
            //}
            //Console.WriteLine("");

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            Console.Write($"Stále máme v seznamu {planety.Count} planety: ");
            foreach (string planeta in planety)
            {
                Console.Write(planeta + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> nakup = new Dictionary<string, int>()
            {
                { "chleba", 20 },
                { "maslo", 35 },
                { "syr", 25},
                { "salam", 30 },
                { "jogurt", 15 },
                { "cokolada", 40 },
                { "rum", 95 }
            };

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            Console.WriteLine("Zadej libovolnou potravinu a pokud je na seznamu, zjistíš její cenu:");
            while (true)
            {
                string potravina = Console.ReadLine();
                if (nakup.ContainsKey(potravina))
                {
                    Console.WriteLine($"Ano, {potravina} je na seznamu, cena je {nakup[potravina]},-Kč");
                }
                else
                {
                    Console.WriteLine($"Ne, {potravina} není na seznamu");
                }

                Console.WriteLine("");

                // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě
                // jeden -> uprav hodnotu k tomu klíči tak,aby obsahovala hromadnou cenu za všechny stejné položky.
                if (nakup.ContainsKey(potravina))
                {
                    nakup[potravina] = nakup[potravina] + nakup[potravina];
                }
            }

        }
    }
}