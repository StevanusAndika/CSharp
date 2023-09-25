using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Deklarasi dan inisialisasi array bilangan bulat
        int[] angka = new int[5];

        // Mengisi array dengan nilai
        angka[0] = 10;
        angka[1] = 20;
        angka[2] = 30;
        angka[3] = 40;
        angka[4] = 50;

        // Menampilkan elemen-elemen array
        Console.WriteLine("Isi array angka:");
        for (int i = 0; i < angka.Length; i++)
        {
            Console.WriteLine("angka[" + i + "] = " + angka[i]);
        }
    }
}
