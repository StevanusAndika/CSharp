using System;

public class KonversiSuhu
{
    public static void Main(string[] args)
    {
        // Input nilai suhu dalam Celcius
        Console.Write("Masukkan suhu dalam Celcius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            // Hitung suhu dalam Reamur
            double reamur = 4.0 / 5.0 * celsius;

            // Hitung suhu dalam Fahrenheit
            double fahrenheit = 9.0 / 5.0 * celsius + 32;

            // Tampilkan suhu dalam Reamur dan Fahrenheit
            Console.WriteLine("Suhu dalam Reamur: {0}°R", reamur);
            Console.WriteLine("Suhu dalam Fahrenheit: {0}°F", fahrenheit);
        }
        else
        {
            Console.WriteLine("Input tidak valid. Masukkan angka.");
        }
    }
}
