using System;

public class Umur
{
    public static void Main(string[] args)
    {
        int day;int month;int year;

        Console.Out.WriteLine("Menghitung Umur");
        Console.WriteLine("****************************************************");
        Console.WriteLine("Nama Saya             : Stevanus Andika Galih Setiawan");
        Console.WriteLine("Tempat, Tanggal Lahir : Jakarta, 06 Februari 2005");
        Console.WriteLine("Kelas                 : Karyawan | Jumat dan Sabtu ");
        Console.WriteLine("Fakultas              : Rekayasa Perangkat Lunak");
        Console.WriteLine("Semester              : Semester Satu(1)");
        Console.WriteLine("****************************************************");

        try {
            Console.Out.WriteLine("Masukkan Tanggal : ");
            day = Convert.ToInt32(Console.In.ReadLine());


            Console.Out.WriteLine("Masukkan Bulan : ");
            month = Convert.ToInt32(Console.In.ReadLine());

            Console.Out.WriteLine("Masukkan  Tahun : ");
          year = Convert.ToInt32(Console.In.ReadLine());

            DateTime birthDate = new DateTime(year, month, day); DateTime today = DateTime.Now;
            TimeSpan age = today.Subtract(birthDate);Console.Out.WriteLine("Saat ini umur anda adalah : {0}hari,{1}jam," +"{2}minutes",age.Days,age.Hours,age.Minutes);

        }catch (FormatException e)
        {
            Console.Out.WriteLine("Data tanggal,bulan dan tahun harus berupa angka.");


        }catch(Exception e) {
            Console.Out.WriteLine("Terjadi kesalahan : " + e.Message);

                }

    }
}
