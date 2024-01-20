using System;

public class Program
{
    // Fungsi sederhana yang menggabungkan dua string
    public static string GabungString(string stringPertama, string stringKedua)
    {
        return stringPertama + " " + stringKedua;
    }

    public static void Main(string[] args)
    {
        string kataPertama = "Halo";
        string kataKedua = "Dunia";

        // Memanggil fungsi GabungString dan menyimpan hasilnya
        string hasilGabung = GabungString(kataPertama, kataKedua);

        // Menampilkan hasil
        Console.WriteLine(hasilGabung);
    }
}
