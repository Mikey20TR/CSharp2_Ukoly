namespace Ukol1_Priklad2
{
    internal class Hvezdicky
    {
        static void Main(string[] args)
        {
            //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.

            Console.WriteLine("Ahoj uživateli, kolik hvězdiček by jsi rád viděl?");
            int pocetHvezd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= pocetHvezd; i++)
            {
                Console.Write("*");
            }
        }
    }
}
