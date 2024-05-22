namespace C2_Lekce6_BreakOut2
{
    internal class Program
    {
        // BREAKOUT ROOM 2
        /* Vyuzij tridu Obdelnik z prvniho BR.
           Prepis fieldy Sirka a Vyska na properties.
           Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.  
           Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
           Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
           Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
           Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0 (vypiste hlasku a nastavte hodnotu na 1).
           Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
        */
        static void Main(string[] args)
        {
            Obdelnik o1 = new Obdelnik(4, 12);
            Obdelnik o2 = new Obdelnik(8);
            Obdelnik o3 = new Obdelnik(-5, 0);
            Console.WriteLine("první obdélník:");
            o1.VypisInformace();
            o1.Zvetsi();
            Console.WriteLine("první obdélník po zvětšení:");
            o1.VypisInformace();

            Console.WriteLine("druhý obdélník:");
            o2.VypisInformace();

            Console.WriteLine("třetí obdélník:");
            o3.VypisInformace();
        }
    }
}
