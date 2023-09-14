using System;

class Program
{
    static void Main()
    {
        int angka1 = 10;
        int angka2 = 5;

        // Operator lebih besar dari
        bool lebihBesarDari = angka1 > angka2;
        Console.WriteLine("Apakah angka1 lebih besar dari angka2? " + lebihBesarDari);

        // Operator lebih kecil dari
        bool lebihKecilDari = angka1 < angka2;
        Console.WriteLine("Apakah angka1 lebih kecil dari angka2? " + lebihKecilDari);

        // Operator lebih besar atau sama dengan
        bool lebihBesarSamaDengan = angka1 >= angka2;
        Console.WriteLine("Apakah angka1 lebih besar atau sama dengan angka2? " + lebihBesarSamaDengan);

        // Operator lebih kecil atau sama dengan
        bool lebihKecilSamaDengan = angka1 <= angka2;
        Console.WriteLine("Apakah angka1 lebih kecil atau sama dengan angka2? " + lebihKecilSamaDengan);

        // Operator sama dengan
        bool samaDengan = angka1 == angka2;
        Console.WriteLine("Apakah angka1 sama dengan angka2? " + samaDengan);

        // Operator tidak sama dengan
        bool tidakSamaDengan = angka1 != angka2;
        Console.WriteLine("Apakah angka1 tidak sama dengan angka2? " + tidakSamaDengan);
    }
}
