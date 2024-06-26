using System; //definisi library dasar
using System.Diagnostics; // for Stopwatch

public class BubbleSort //konstruktor program dalam class bubble sort
{
    private int[] data; // inisialisasi array dengan nama data yang berisi nilai-nilai yang akan diurutkan

    // Konstruktor untuk membuat sebuah array dengan data yang sudah ditentukan
    public BubbleSort(int[] inputData) //metode konstruktor dengan parameter inputData
    {
        data = new int[inputData.Length]; // inisialisasi array data dengan panjang yang sama seperti inputData
        Array.Copy(inputData, data, inputData.Length); // menyalin isi dari inputData ke array data
        // dengan mengambil panjang dari parameter inputData
    }

    // Metode untuk mengurutkan array menggunakan Bubble Sort
    public void Urut()
    {
        //variabel n yang menampung panjang dari array data
        int n = data.Length;
        for (int i = 0; i < n - 1; i++) // loop luar
        //berfungsi sebagai index loop untuk setiap elemmen dari 0 hingga n-1
        {
            for (int j = 0; j < n - i - 1; j++) //loop dalam
            // loop dalam berfungsi  untuk setiap elemen sampai elemen yang sudah diurutkan
            //berfungsi sebagai index loop untuk setiap elemen dari 0 hingga n-i-2
            //setiap i mengurangi jumlah elemen yang diurutkan dan data terbesar yang diurutkan akan
            //mengampung dan berada di akhir
            {
                if (data[j] > data[j + 1]) // cek elemen array data dalam index j lebih besar dari elemen data dalam index j + 1
                {
                    //variabel sementara menampung array data dalam index j
                    int temp = data[j];

                    //data akan dilakukan ditukar jika elemen yang lebih besar dari elemen berikutnya
                    data[j] = data[j + 1];
                    //lalu output data dalam index j adalah data dalam index j + 1 dalam arti index j ditukar dengan index j + 1
                    data[j + 1] = temp;
                    //output data dalam index j + 1 adalah variabel sementara

                    // Menampilkan proses penukaran menggunakan metode SubArray dari panjang 0 sampai terakhir secara berurutan
                    Console.WriteLine("Tukar: " + SubArray(0, data.Length - 1));
                }
            }
        }
    }

    // Metode untuk menampilkan bagian dari array sebagai string
    // Parameter rendah dan tinggi menunjukkan bagian dari array yang ingin ditampilkan
    public string SubArray(int rendah, int tinggi) //metode dengan parameter rendah dan tinggi
    {
        //variabel sementara dengan tipe data string dan data kosong
        string temporer = string.Empty;
        //looping untuk setiap elemen dari rendah sampai tinggi
        for (int i = rendah; i <= tinggi; i++)
        {
            temporer += data[i] + " "; // menambahkan elemen array ke string temporer dalam indeks i dan menambahkan spasi
        }
        return temporer;
        //kemudian kembalikan nilai string temporer
    }

    // Metode Main adalah inti program
    public static void Main(string[] args)
    {
        Console.WriteLine("**************APLIKASI MERGE SORT DAN BUBBLE SORT*************************");
        Console.WriteLine("Nama Anggota Kelompok : 1.Dhaffa Abdillah Hakim (202303110006)" +
            " 2.Stevanus Andika Galih Setiawan(202303110008)" + " 3,Nur Khalida Farhatie(202303110011)");
        Console.WriteLine("******************************************************************");

        //variabel inputData dengan data yang akan diurutkan
        int[] inputData = { 1, 3, 2, 7, 9, 8, 10, 4, 6, 5 }; // array yang akan diurutkan

        // membuat instance dan objek dengan nama urutBubble dan instance dari urutBubble yaitu constructor
        //dari class BubbleSort dengan parameter inputData dari array asli
        
        
        BubbleSort urutBubble = new BubbleSort(inputData);

        Console.WriteLine("Array sebelum diurutkan:");
        Stopwatch stopwatch = new Stopwatch(); // Create a stopwatch instance
        stopwatch.Start(); // Start measuring time
         // menampilkan waktu yang dibutuhkan
        Console.WriteLine(urutBubble.SubArray(0, urutBubble.data.Length - 1));
        
        // menampilkan isi array sebelum diurutkan dengan memanggil objek dan method SubArray,lalu mengambil index 0 sampai index terakhir

        Console.WriteLine("******************************************************************");

        urutBubble.Urut(); // memanggil metode Urut untuk mengurutkan array dengan konstruktor dari BubbleSort dan objek urutBubble
        // dari bubble sort
        Console.WriteLine("******************************************************************");
        stopwatch.Stop(); // Stop measuring time

        Console.WriteLine("Urutan Array :");
        //urutkan array
        Console.WriteLine(urutBubble.SubArray(0, urutBubble.data.Length - 1)); // menampilkan isi array setelah diurutkan
        //dimana mengambil objek yaitu urutBubble dari constructor BubbleSort
        //dan method subArray dengan mengambil panjang dari array data dari index 0 sampai index terakhir
        Console.WriteLine($"Waktu eksekusi: {stopwatch.Elapsed.TotalMilliseconds} ms"); // Display elapsed time in milliseconds

    }
}
