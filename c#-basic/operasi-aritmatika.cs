using System;

class Program
{
    static void Main()
    {
        // Contoh penjumlahan
        int angka1 = 10;
        int angka2 = 5;
        int hasilPenjumlahan = angka1 + angka2;
        Console.WriteLine("Hasil penjumlahan: " + hasilPenjumlahan);

        // Contoh pengurangan
        int angka3 = 20;
        int angka4 = 7;
        int hasilPengurangan = angka3 - angka4;
        Console.WriteLine("Hasil pengurangan: " + hasilPengurangan);

        // Contoh perkalian
        int angka5 = 8;
        int angka6 = 4;
        int hasilPerkalian = angka5 * angka6;
        Console.WriteLine("Hasil perkalian: " + hasilPerkalian);

        // Contoh pembagian (pembagian pecahan)
        double angka7 = 15.0;
        double angka8 = 3.0;
        double hasilPembagian = angka7 / angka8;
        Console.WriteLine("Hasil pembagian: " + hasilPembagian);

        // Contoh modulus (sisa pembagian)
        int angka9 = 17;
        int angka10 = 4;
        int sisaPembagian = angka9 % angka10;
        Console.WriteLine("Sisa pembagian: " + sisaPembagian);

        // Operasi aritmatika kompleks
        double kompleks = (angka1 + angka2) * (angka3 - angka4) / angka5;
        Console.WriteLine("Hasil operasi aritmatika kompleks: " + kompleks);
    }
}
