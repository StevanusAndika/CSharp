Dalam bahasa pemrograman C#, Anda dapat menggunakan beberapa jenis perulangan untuk mengulangi eksekusi kode tertentu. Berikut beberapa contoh perulangan dalam C#:

1. **Perulangan `for`:**
   Perulangan `for` digunakan ketika Anda sudah mengetahui berapa kali kode akan diulang.

   ```csharp
   for (int i = 0; i < 5; i++)
   {
       Console.WriteLine("Iterasi ke-" + i);
   }
   ```

2. **Perulangan `while`:**
   Perulangan `while` digunakan ketika Anda ingin mengulangi eksekusi kode selama kondisi tertentu benar.

   ```csharp
   int angka = 0;
   while (angka < 5)
   {
       Console.WriteLine("Angka: " + angka);
       angka++;
   }
   ```

3. **Perulangan `do-while`:**
   Perulangan `do-while` hampir sama dengan `while`, namun perulangan ini akan menjalankan blok kode setidaknya satu kali sebelum memeriksa kondisi.

   ```csharp
   int angka = 0;
   do
   {
       Console.WriteLine("Angka: " + angka);
       angka++;
   } while (angka < 5);
   ```

4. **Perulangan `foreach`:**
   Perulangan `foreach` digunakan untuk mengulangi elemen-elemen dalam koleksi seperti array atau daftar.

   ```csharp
   int[] angka = { 1, 2, 3, 4, 5 };
   foreach (int item in angka)
   {
       Console.WriteLine("Angka: " + item);
   }
   ```

5. **Perulangan `break` dan `continue`:**
   Anda dapat menggunakan pernyataan `break` untuk menghentikan perulangan dan `continue` untuk melanjutkan ke iterasi berikutnya.

   ```csharp
   for (int i = 0; i < 10; i++)
   {
       if (i == 3)
           continue; // Melanjutkan ke iterasi berikutnya jika i adalah 3
       if (i == 7)
           break; // Menghentikan perulangan jika i adalah 7
       Console.WriteLine("Angka: " + i);
   }
   ```

Ini adalah beberapa contoh dasar perulangan dalam bahasa pemrograman C#. Anda dapat memilih jenis perulangan yang sesuai dengan kebutuhan Anda dalam pengembangan aplikasi.
