using System;
using System.Diagnostics; // for Stopwatch

public class PengurutanMerge//class PengurutanMerge yang berisi kontrustor dan metode
{
    private int[] data; // array asli dengan nilai-nilai yang akan diurutkan

    // Konstruktor untuk membuat sebuah array dengan data yang sudah ditentukan
    public PengurutanMerge(int[] inputData)//method konstruktor dengan parameter inputData tipe data integer
    {
        data = new int[inputData.Length]; // inisialisasi array data dengan panjang yang sama seperti inputData
        Array.Copy(inputData, data, inputData.Length); // menyalin isi dari inputData ke array data
        //method Array.Copy digunakan untuk menyalin isi dari inputData ke array data
    }

    // Metode untuk memanggil urutan array secara rekursif
    //awal method urut
    public void Urut()

    {
        UrutArray(0, data.Length - 1); // memulai proses pengurutan dengan seluruh array dari indeks 0 sampai indeks terakhir
        //dengan memanggil method UrutArray
    } // akhir method  Urut

    // Metode untuk memecah array, mengurutkan subarray, dan menggabungkannya
    //menggunakan rekursif
    //metode pengulangan yang melibatkan penggunaan diri sendiri. Dalam konteks pemrograman,
     //fungsi rekursif adalah suatu bentuk perulangan yang tidak melibatkan iterasi.
    private void UrutArray(int rendah, int tinggi)//method untuk UrutArray dengan params rendah dan tingggi

    {
        if ((tinggi - rendah) >= 1) // jika selisih tinggi dan besar lebih besar  atau sama dengan 1
        
        {//insialisasi variabel untuk pecah array

            //tengah1 adalah indeks tengah dari subarray saat ini
            //lakukan kalkulasi

            int tengah1 = (rendah + tinggi) / 2; //hitung dengan ambil nilai dari parameter rendah tambah tinggi  dibagi dua 
            //tengah 2 adalah indeks awal  dari subarray kedua yaitu satu posisi dari tengah1
            int tengah2 = tengah1 + 1; // indeks elemen pertama dari subarray kedua

            // Menampilkan langkah pemecahan
            
            //mengambil dari method subarray yang sedang dipecah, yaitu subarray dari indeks rendah hingga tinggi
            //Metode SubArray digunakan untuk memberi tahu kita bagian dari array mana yang sedang diproses.

            Console.WriteLine("Pecah :" + SubArray(rendah, tinggi));

            //menampilkan subarray kiri yang dihasilkan dari pemecahan array, yaitu dari indeks rendah hingga tengah1
            Console.WriteLine("     " + SubArray(rendah, tengah1));
            //menampilkan subarray kanan yang diurutkan dari pemecahan array, yaitu dari indeks tengah2 hingga tinggi
            Console.WriteLine("     " + SubArray(tengah2, tinggi));
            //spasi kosong
            Console.WriteLine();
            
            //proses rekursif dari rendah hingga tengah1
            //proses rekursif dari tengah2 hingga tinggi
            UrutArray(rendah, tengah1); // rekursif untuk subarray kiri
            UrutArray(tengah2, tinggi); // rekursif untuk subarray kanan

            // Menggabungkan dua subarray yang sudah diurutkan dengan parameter kiri, tengah1, tengah2, dan tinggi
            //dengan metode Gabung
            Gabung(rendah, tengah1, tengah2, tinggi);
        }
    }

    // Metode untuk menggabungkan dua subarray terurut menjadi satu array terurut
    //parameter kiri,tengah1,tengah2 dan kanan dengan tipe data integer
    private void Gabung(int kiri, int tengah1, int tengah2, int kanan)
    {
        int indeksKiri = kiri; // indeks dari subarray kiri untuk melacak elemen di subarray kiri
        int indeksKanan = tengah2; // indeks dari subarray kanan untuk melacak elemen di subarray kanan
        int indeksGabung = kiri; // indeks  sementara untuk hasil gabungan untuk melacak elemen di subarray gabungan
        int[] tergabung = new int[data.Length]; // menampung array sementara dengan ukuran yang sama dengan array asli yaitu data
        // Menampilkan dua subarray sebelum penggabungan
        Console.WriteLine("Gabung :" + SubArray(kiri, tengah1));//cetak output dari method SubArray dengan params kiri, tengah1
        Console.WriteLine("     " + SubArray(tengah2, kanan));//cetak output dari method SubArray dengan params tengah2, kanan

        // gunakan while untuk membandingkan elemen dari subararray kiri dan subarray kanan dalam batas subarray masing-masing
        // dan menambahkan elemen ke array gabungan
        while (indeksKiri <= tengah1 && indeksKanan <= kanan)
        {
            //bandingkan elemen dari subarray kiri dan subarray kanan
            //jika salah satu subarray  habis, tambahkan elemen ke array sementara yaitu tergabung
            if (data[indeksKiri] <= data[indeksKanan])
            {
                // lalu array sementara  yang menampung subarray kiri ditambahkan ke array asli yaitu data
                
                tergabung[indeksGabung++] = data[indeksKiri++]; 
            }

            //jika index kanan yang habis duluan, tambahkan elemen ke array sementara yaitu tergabung
            //lalu tambahkan array sementara yang menampung subarray kanan  ke array asli yaitu data

            else
            {
                tergabung[indeksGabung++] = data[indeksKanan++]; 
            }
        } // akhir while

        // lalu bandingkan lagi subarray kiri dan subarray kanan
        if (indeksKiri == tengah2)// jika subarray kiri sama dengan subarray kanan
        {
            //lakukan perulangan untuk array kanan dan subarraynya
            while (indeksKanan <= kanan)
            {
                // tambahkan ke array gabungan dan array gabungan ditambahkan ke array asli yaitu data
                tergabung[indeksGabung++] = data[indeksKanan++];// tambahkan ke array gabungan
            }
        }
        else // jika subarray  kiri kosong, salin sisa array kanan

        {//lakukan perulangan untuk subarray kiri  dan array kanan 
            while (indeksKiri <= tengah1)
            {
                // tambahkan subarray kiri ke array sementara dan array gabungan ditambahkan ke array asli yaitu data

                tergabung[indeksGabung++] = data[indeksKiri++];
            }
        }

        // Salin nilai-nilai dari array sementara  ke array asli dengan ambil nilai dari indeks kiri hingga indeks kanan
        for (int i = kiri; i <= kanan; i++)

        {
            //pastikan array asli yaitu data dengan indeks i sama dengan isi array sementara dengan indeks i
            data[i] = tergabung[i];
            //tampung Dalam array asli yang ditampung dalam array sementara dengan indeks i


        }

        // Menampilkan data yang sudah digabung
        //cetak output dari method SubArray dengan params kiri, kanan
        Console.WriteLine(" " + SubArray(kiri, kanan));
        //spasi baru
        Console.WriteLine();
    }

    // Metode untuk menampilkan bagian dari array sebagai string
    public string SubArray(int rendah, int tinggi)//metode dengan parameter rendah dan tinggi
    {
        string temporer = string.Empty;//variabel sementara dengan tipe data string dan data kosong
        for (int i = rendah; i <= tinggi; i++)//loop untuk setiap elemen dari rendah hingga tinggi
        {
            temporer += data[i] + " "; // menambahkan elemen array ke string temporer dalam indeks i dan  menambahkan spasi
        }
        return temporer;//kembalikan nilai temporer
    }

    // Metode Main adalah inti program
    static void Main(string[] args)
    {
        Console.WriteLine("**************APLIKASI MERGE SORT DAN BUBBLE SORT*************************");
        Console.WriteLine("Nama Anggota Kelompok : 1.Stevanus Andika Galih Setiawan(202303110008)"+
            "2.Dhaffa Abdillah Hakim (202303110006)"+"3.Nur Khalida Farhatie(202303110011)" );
            Console.WriteLine("************************************************************************");

        int[] inputData = { 1, 3, 2, 7, 9, 8, 10, 4, 6, 5 }; //panggil array sementara
        PengurutanMerge urutArray = new PengurutanMerge(inputData); 
        // membuat instance dan objek  dengan nama urutArray  dari pengurutanMerge yaitu constructor
        //dari  class PengurutanMerge  parameter inputData
        
        Console.WriteLine("Array sebelum diurutkan:");

        //panggil objek yang telah diinisialisasi dengan nama urutArray
        //  dan gabungkan dengan method SubArray   untuk mencetak isi array data 
        //dari indeks 0 sampai indeks terakhir
        Console.WriteLine(urutArray.SubArray(0, urutArray.data.Length - 1)); 
        
        Console.WriteLine("******************************************************************");
        Stopwatch stopwatch = new Stopwatch(); // Create a stopwatch instance
        stopwatch.Start(); // Start measuring time
        //menjalankan method Urut untuk mengurutkan array
        urutArray.Urut(); // memanggil metode Urut untuk mengurutkan array
        Console.WriteLine("******************************************************************");
        //mencetak isi array setelah diurutkan dengan method SubArray diambil index 0 sampai index terakhir
        Console.WriteLine("Urutan Array :");
        Console.WriteLine(urutArray.SubArray(0, urutArray.data.Length - 1)); // menampilkan isi array setelah diurutkan
        //tampilkan dengan string dengan mengambil dari index 0 hingga index terakhir
                Console.WriteLine($"Waktu eksekusi: {stopwatch.Elapsed.TotalMilliseconds} ms"); // Display elapsed time in milliseconds

    }
}