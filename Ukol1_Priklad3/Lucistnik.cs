using System.IO;

namespace Ukol1_Priklad3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
            //Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
            //Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
            //Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
            //Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.

            Lucistnik karel = new Lucistnik(10);
            for (int i = karel.PocetSipu; i >= 0; i--)
            {
                karel.Vystrel();
            }
        }
    }
    public class Lucistnik
    {
        public int PocetSipu;
        public int PocetStrel;
        public Lucistnik(int pocetSipu)
        {
            PocetSipu = pocetSipu;
            PocetStrel = 1;
        }
        public void Vystrel()
        {
            if (PocetSipu > 0)
            {
                Console.WriteLine("Vždy se trefím přímo doprostřed!");
                Console.WriteLine($"Střílím {PocetStrel}. šíp!");
                PocetStrel++;
                PocetSipu--;
            }
            else
            {
                Console.WriteLine("Nemám šípy");
            }
        }
    }
}
