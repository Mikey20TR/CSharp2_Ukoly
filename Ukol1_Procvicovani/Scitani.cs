namespace Ukol1_Procvicovani
{
    internal class Scitani
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, uživateli, mohu ti pomoci sečíst dvě zadaná čísla");
            Console.WriteLine("=======================================================");
            Console.WriteLine("Zadej první číslo:");
            int cislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo:");
            int cislo2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Součet čísel {cislo1} a {cislo2} je {cislo1 + cislo2}");
        }
    }
}
