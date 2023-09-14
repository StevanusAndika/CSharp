Dalam bahasa pemrograman C#, Anda dapat membuat dan menggunakan fungsi (function) untuk mengelompokkan kode tertentu ke dalam blok yang dapat dipanggil secara berulang. Berikut adalah contoh-contoh fungsi dalam C#:

1. **Fungsi Tanpa Parameter dan Tanpa Nilai Kembali (Void):**
   Fungsi ini tidak menerima parameter dan tidak mengembalikan nilai.

   ```csharp
   void Sapa()
   {
       Console.WriteLine("Halo, selamat datang!");
   }
   ```

   Anda dapat memanggilnya dengan:

   ```csharp
   Sapa();
   ```

2. **Fungsi dengan Parameter:**
   Fungsi ini menerima satu atau lebih parameter.

   ```csharp
   void Perkalian(int angka1, int angka2)
   {
       int hasil = angka1 * angka2;
       Console.WriteLine("Hasil perkalian: " + hasil);
   }
   ```

   Anda dapat memanggilnya dengan:

   ```csharp
   Perkalian(5, 3);
   ```

3. **Fungsi yang Mengembalikan Nilai:**
   Fungsi ini mengembalikan nilai.

   ```csharp
   int Penjumlahan(int angka1, int angka2)
   {
       int hasil = angka1 + angka2;
       return hasil;
   }
   ```

   Anda dapat memanggilnya dan menyimpan hasilnya:

   ```csharp
   int hasilPenjumlahan = Penjumlahan(10, 20);
   Console.WriteLine("Hasil penjumlahan: " + hasilPenjumlahan);
   ```

4. **Fungsi dengan Nilai Kembali Tidak Wajib (Optional Return):**
   Fungsi ini dapat mengembalikan nilai, tetapi pengembalian nilai tidak wajib.

   ```csharp
   int Faktorial(int n)
   {
       if (n == 0)
           return 1;
       else
           return n * Faktorial(n - 1);
   }
   ```

   Anda dapat memanggilnya seperti ini:

   ```csharp
   int hasilFaktorial = Faktorial(5);
   Console.WriteLine("Hasil faktorial: " + hasilFaktorial);
   ```

5. **Fungsi dengan Nilai Kembali Lebih dari Satu (Tuple):**
   Fungsi dapat mengembalikan beberapa nilai dalam bentuk tupel.

   ```csharp
   (int, int) Hitung(int angka1, int angka2)
   {
       int hasilTambah = angka1 + angka2;
       int hasilKurang = angka1 - angka2;
       return (hasilTambah, hasilKurang);
   }
   ```

   Anda dapat memanggilnya seperti ini:

   ```csharp
   var hasil = Hitung(10, 5);
   Console.WriteLine("Hasil tambah: " + hasil.Item1);
   Console.WriteLine("Hasil kurang: " + hasil.Item2);
   ```

Itulah beberapa contoh fungsi dalam bahasa pemrograman C#. Fungsi memungkinkan Anda untuk mengorganisir dan merapikan kode Anda, membuatnya lebih mudah dimengerti, dan mengurangi duplikasi kode.
