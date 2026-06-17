using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Pole
{
    double a;
    double b;
    double oblicz_pole;

        public void czytaj_dane()
        {
        Console.WriteLine("Podaj bok a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj bok b: ");
        b = double.Parse(Console.ReadLine());
        }
        public void przetworz_dane()
        {
        
        
        oblicz_pole = a * b;

        }
        public void wyswietl_dane()
        {
        Console.WriteLine($"Wartości a oraz b {a},{b}");
        Console.WriteLine($"Pole: {oblicz_pole:F2}");

        }
    
    static void Main (string[] args)
    {

        Pole prostokat = new Pole();
        prostokat.czytaj_dane();
        prostokat.przetworz_dane();
        prostokat.wyswietl_dane();
        Console.ReadLine();


        
        





    }


}
