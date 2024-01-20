// 1. Deklarasi pustaka

using System;

// 2.bagian class/blueprint 
class FirstProgram
{

    // // 3. Bagian Fungsi yang akan dieksekusi
    static void Main(String[] args)
    {
        //deklarasi variabel di csharp
        string nama;
        string nama_universitas;
        string password;
        string jurusan;
        int umur;
        //tampilkan output
        Console.WriteLine("=== PROGRAM INPUT OUTPUT DATA ===");

        //Fungsi WriteLine() akan menampilkan teks dalam satu baris atau baris baru, sedangkan Write() tidak akan membuat baris baru.
        //baca inputan 
        Console.Write("INPUT NAMA ANDA :");
        nama = Console.ReadLine();

        Console.Write("INPUT PASSWORD ANDA :");
        
        password = Console.ReadLine();

        Console.Write("INPUT NAMA UNIVERSITAS ANDA SAAT INI : ");
        nama_universitas = Console.ReadLine();

        Console.Write("INPUT JURUSAN ANDA SAAT INI :");
          jurusan = Console.ReadLine();

        Console.Write("INPUT UMUR ANDA :");
      
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine("=== BERIKUT ADALAH HASIL YANG TELAH ANDA INPUT ===");
        Console.WriteLine($"NAMA ANDA: {nama}");
        Console.WriteLine($"PASSWORD ANDA : {password}");
        Console.WriteLine($"NAMA UNIVERSITAS ANDA : {nama_universitas}");
        Console.WriteLine($"JURUSAN ANDA: {jurusan}");
        Console.WriteLine($"UMUR ANDA : {umur}TAHUN");
        Console.WriteLine("PROGRAM BERAKHIR...");
    }
}
