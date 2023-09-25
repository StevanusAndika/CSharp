using System;

public class nilai_rata_rata
{
    public static void Main(string[] args)
    {
        int nilai_a, nilai_b, nilai_c;
        float rerata;
        Console.WriteLine("****************************************************");
        Console.WriteLine("Nama Saya             : Stevanus Andika Galih Setiawan");
        Console.WriteLine("Tempat, Tanggal Lahir : Jakarta, 06 Februari 2005");
        Console.WriteLine("Kelas                 : Karyawan | Jumat dan Sabtu ");
        Console.WriteLine("Fakultas              : Rekayasa Perangkat Lunak");
        Console.WriteLine("Semester              : Semester Satu(1)");
        Console.WriteLine("****************************************************");

        Console.Write("Masukkan Nilai_a =");
        nilai_a = Convert.ToInt16(Console.ReadLine());

        Console.Write("Masukkan Nilai_b =");
        nilai_b = Convert.ToInt16(Console.ReadLine());

        Console.Write("Masukkan Nilai_c =");
        nilai_c = Convert.ToInt16(Console.ReadLine());

        rerata = (nilai_a + nilai_b + nilai_c) / 3;
        Console.WriteLine(nilai_a + "," + nilai_b + "," + nilai_c);
        Console.WriteLine("rerata =" + rerata);
        Console.ReadKey();

    }
}
