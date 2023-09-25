using System;

public class volume_balok
{
    public static void Main(string[] args)
    {

        float p, l, t, vol;

       
        Console.WriteLine("****************************************************");
        Console.WriteLine("Nama Saya             : Stevanus Andika Galih Setiawan");
        Console.WriteLine("Tempat, Tanggal Lahir : Jakarta, 06 Februari 2005");
        Console.WriteLine("Kelas                 : Karyawan | Jumat dan Sabtu ");
        Console.WriteLine("Fakultas              : Rekayasa Perangkat Lunak");
        Console.WriteLine("Semester              : Semester Satu(1)");
        Console.WriteLine("****************************************************");

        Console.Write("masukkan Panjang Balok =");
        p = Convert.ToSingle(Console.ReadLine());

        Console.Write("masukkan Lebar Balok =");
        l = Convert.ToSingle(Console.ReadLine());

        Console.Write("masukkan Tinggi Balok =");
        t = Convert.ToSingle(Console.ReadLine());

        vol = p * l * t;
        Console.WriteLine("volume balok = " + vol);
        Console.ReadKey();


    }
}
