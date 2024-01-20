using System;

class Program
{
    static void Main()
    {
        // Mendeklarasikan variabel dengan var
        var nama = "John";
        var umur = 30;
        var tinggi = 175.5;

        // Mendeklarasikan variabel dengan tipe data eksplisit
        string alamat = "123 Main St";
        int nilaiMatematika = 90;
        double nilaiFisika = 85.5;

        // Menampilkan nilai variabel ke layar
        Console.WriteLine("Nama: " + nama);
        Console.WriteLine("Umur: " + umur + " tahun");
        Console.WriteLine("Tinggi: " + tinggi + " cm");

        Console.WriteLine("Alamat: " + alamat);
        Console.WriteLine("Nilai Matematika: " + nilaiMatematika);
        Console.WriteLine("Nilai Fisika: " + nilaiFisika);

        // Menunggu user menekan tombol Enter sebelum program selesai
        Console.ReadLine();
    }
}
