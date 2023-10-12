using System;
using System.Collections.Generic;

class AbsensiKelas
{
    static void Main(string[] args)
    {
        // Create a LinkedList to store the attendance list.
        LinkedList<string> absensi = new LinkedList<string>();

        while (true)
        {
            // Display menu options.
            Console.WriteLine("Pilih operasi:");
            Console.WriteLine("1. Tambah absensi");
            Console.WriteLine("2. Hapus absensi terakhir");
            Console.WriteLine("3. Tampilkan absensi");
            Console.WriteLine("4. Keluar");

            // Read the user's choice.
            if (!int.TryParse(Console.ReadLine(), out int pilihan))
            {
                Console.WriteLine("Masukan tidak valid. Harap masukkan nomor yang valid.");
                continue;
            }

            switch (pilihan)
            {
                case 1:
                    // Add a student to the end of the attendance list.
                    Console.Write("Masukkan nama siswa: ");
                    string namaSiswa = Console.ReadLine();
                    absensi.AddLast(namaSiswa);
                    Console.WriteLine($"{namaSiswa} telah dicatat ke dalam absensi.");
                    break;

                case 2:
                    // Remove the last student from the attendance list.
                    if (absensi.Count > 0)
                    {
                        var lastNode = absensi.Last;
                        string siswaYangHadir = lastNode.Value;
                        absensi.RemoveLast();
                        Console.WriteLine($"{siswaYangHadir} telah dihapus dari absensi.");
                    }
                    else
                    {
                        Console.WriteLine("Absensi kosong. Tidak ada yang dapat dihapus.");
                    }
                    break;

                case 3:
                    // Display the current attendance list.
                    Console.WriteLine("Daftar Absensi:");
                    if (absensi.Count == 0)
                    {
                        Console.WriteLine("Absensi masih kosong.");
                    }
                    else
                    {
                        foreach (var siswa in absensi)
                        {
                            Console.WriteLine(siswa);
                        }
                    }
                    break;

                case 4:
                    // Exit the program.
                    Console.WriteLine("Terima kasih!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih angka 1-4.");
                    break;
            }
        }
    }
}
