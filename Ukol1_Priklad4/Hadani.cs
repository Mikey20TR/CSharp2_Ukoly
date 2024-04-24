namespace Ukol1_Priklad4
{
    internal class Hadani
    {
        static void Main(string[] args)
        {
            //Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím.
            //Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí

            Console.WriteLine("Ahoj uživateli, uhádni na jaké číslo od 1 do 50 myslím:");
            Random generator = new Random();
            int nahodneCislo = generator.Next(51);
            int cisloUzivatele = int.Parse(Console.ReadLine());

            while (cisloUzivatele != nahodneCislo)
            {
                if (cisloUzivatele > nahodneCislo)
                {
                    Console.WriteLine("Neuhádl jsi, tvé číslo je moc velké, zkus to znovu:");
                    cisloUzivatele = int.Parse(Console.ReadLine());
                }
                else if (cisloUzivatele < nahodneCislo)
                {
                    Console.WriteLine("Neuhádl jsi, tvé číslo je moc malé, zkus to znovu:");
                    cisloUzivatele = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=");
            Console.WriteLine($"Gratuluji, uhádl jsi! Opravdu jsem myslel číslo {nahodneCislo}");
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=");

        }
    }
}
