using System.Linq;

namespace Lekce7_GrafickeObjekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrafickyObjekt o1 = new Obdelnik(12, 4, "blue");
            GrafickyObjekt t1 = new Trojuhelnik(8, "yellow");
            GrafickyObjekt text1 = new Text("Ahoj, Czechitas", "green");

            var list = new List<GrafickyObjekt> { o1, t1, text1 };
            foreach (GrafickyObjekt objekt in list)
            {
                objekt.Vykreslit();
            }
            Console.WriteLine("");

            Console.WriteLine("Zadej šířku obdélníku:");
            int sirkaO2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej výšku obdélníku:");
            int vyskaO2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nyní si můžeš vybrat barvu obdélníku (Red/Blue/Green/White/Yellow):");
            string barvaO2 = Console.ReadLine().ToLower();
            GrafickyObjekt o2 = new Obdelnik(sirkaO2, vyskaO2, barvaO2);

            o2.Vykreslit();

            Console.WriteLine("Zadej výšku trojúhelníku:");
            int vyskaT2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nyní si můžeš vybrat barvu trojúhelníku (Red/Blue/Green/White/Yellow):");
            GrafickyObjekt t2 = new Trojuhelnik(vyskaT2, Console.ReadLine().ToLower());

            t2.Vykreslit();

            Console.WriteLine("Zadej libovolný text:");
            string textUzivatele = Console.ReadLine();
            Console.WriteLine("A nyní si můžeš vybrat barvu svého textu (Red/Blue/Green/White/Yellow):");
            GrafickyObjekt text2 = new Text(textUzivatele,Console.ReadLine().ToLower());

            var list2 = new List<GrafickyObjekt> { o2, t2, text2 };
            foreach (GrafickyObjekt objekt in list2)
            {
                objekt.Vykreslit();
            }
        }
    }
}
