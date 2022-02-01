using System;

namespace ConverterSuhu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? celcius;
            double? reamur, fahrenheit, kelvin;

            // Bacaan User
            Console.Write("Masukan Suhu dalam Celcius : ");

            // Input User
            celcius = Convert.ToInt32(Console.ReadLine());

            // Rumus Reamur

            reamur = 0.8 * celcius;

            // Rumus Fahrenheit
            fahrenheit = (1.8 * celcius) + 32;

            // Rumus Kelvin
            kelvin = celcius + 273;

            // Print Hasil Celcius
            Console.WriteLine("\nSuhu dalam Celcius adalah : " + celcius + " C");

            // Print Hasil Reamur
            Console.WriteLine("Suhu dalam Reamur adalah : " + reamur + " R");

            // Print Hasil Fahrenheit
            Console.WriteLine("Suhu dalam Fahreheit adalah : " + fahrenheit + " F");

            // Print Hasil Kelvin
            Console.WriteLine("Suhu dalam Kelvin adalah : " + kelvin + " K");
        }
    }
}
