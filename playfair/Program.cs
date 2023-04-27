namespace playfair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PlayfairKodolo kodolo = new PlayfairKodolo(@"..\..\..\..\src\kulcstabla.txt");

            Console.Write("6. feladat - Kérek egy nagybetűt: ");
            char karakter = Console.ReadLine()[0];
            Console.WriteLine($"A karakter sorának az indexe: {kodolo.SorIndex(karakter)}");
            Console.WriteLine($"A karakter oszlopának az indexe: {kodolo.OszlopIndex(karakter)}");

            Console.Write("8. feladat - Kérek egy karakterpárt: ");
            string karakterpar = Console.ReadLine();
            string kodoltpar = kodolo.KodolBetupar(karakterpar);
            Console.WriteLine($"Kódolva: {kodoltpar}");

            Console.ReadLine();
        }
    }
}