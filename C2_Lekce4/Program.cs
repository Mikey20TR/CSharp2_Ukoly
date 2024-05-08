namespace C2_Lekce4
{
    /* Vytvorte tridu TelefonniSeznam
- uvnitr ni budete ukladat dvojice Jmeno - Telefonni cislo
- k tomu pouzijte Dictionary, jehoz klice budou stringy a hodnoty integery
- v ramci konstruktoru vyplnte nekolik jmen a cisel
- vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
- vytvorte metodu, ktera vrati telefonni cislo cloveka
- vytvorte metodu, ktera vypise cely telefonni seznam
- vytvorte metodu, ktera smaze daneho cloveka
- vytvorte metodu, ktera smaze cely telefonni seznam .Clear()
- myslete na mozne chybove stavy (co kdyz tam dany clovek neni, co kdyz pridavam cloveka, ktery uz tam je)
- napiste kratky program, ktery overi funkcnost teto tridy */
    public class TelefonniSeznam
    {
        private Dictionary<string, int> telSeznam;
        public TelefonniSeznam()
        {
            telSeznam = new Dictionary<string, int>();
            telSeznam.Add("Pavel Nový", 701222333);
            telSeznam.Add("Martina Nová", 701555666);
            telSeznam.Add("Richard Smutný", 736700800);
            telSeznam.Add("Pavlína Malá", 705800800);
        }
        public void PridejZaznam(string jmeno, int cislo)
        {
            if (!telSeznam.ContainsKey(jmeno))
            {
                telSeznam.Add(jmeno, cislo);
            }
            else Console.WriteLine("Tento záznam v seznamu již existuje");
        }
        public int NajdiCislo(string jmeno)
        {
            if (telSeznam.ContainsKey(jmeno))
            {
                return telSeznam[jmeno];
            }
            else throw new Exception(jmeno + " nebylo v seznamu nalezeno");
        }
        public void VypisSeznam()
        {
            Console.WriteLine("Aktuální telefonní seznam:");
            foreach(KeyValuePair<string,int> zaznam in telSeznam)
            {
                Console.WriteLine($"Jméno: {zaznam.Key}");
                Console.WriteLine($"Tel. číslo: {zaznam.Value}");
                Console.WriteLine("");
            }
        }
        public void SmazZaznam(string jmeno)
        {
            if (telSeznam.ContainsKey(jmeno))
            {
                telSeznam.Remove(jmeno);
                Console.WriteLine($"Uživatel {jmeno} byl smazán");
            }
            else throw new Exception(jmeno + " nebylo nalezeno v seznamu");
        }
        public void SmazCelySeznam()
        {
            telSeznam.Clear();
        }
        
    }
    public class Program
    {
        public static void Main()
        {
            TelefonniSeznam ts = new TelefonniSeznam();

            Console.WriteLine("Vložte do telefonního seznamu nové jméno a poté číslo:");
            ts.PridejZaznam((Console.ReadLine()),int.Parse(Console.ReadLine()));
            Console.WriteLine("");
            
            Console.WriteLine("- vytvorte metodu, ktera vrati telefonni cislo cloveka");
            Console.WriteLine(ts.NajdiCislo("Martina Nová"));
            Console.WriteLine("");
            
            Console.WriteLine("- vytvorte metodu, ktera vypise cely telefonni seznam");
            ts.VypisSeznam();
            Console.WriteLine("");
            
            Console.WriteLine("- vytvorte metodu, ktera smaze daneho cloveka");
            ts.SmazZaznam("Richard Smutný");
            ts.VypisSeznam();
            Console.WriteLine("");
            
            Console.WriteLine("- vytvorte metodu, ktera smaze cely telefonni seznam .Clear()");
            ts.SmazCelySeznam();
            Console.WriteLine("");
            
            ts.VypisSeznam();
            Console.WriteLine("...");
        }
    }
}
