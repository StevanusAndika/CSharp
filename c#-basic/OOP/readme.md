Object-Oriented Programming (OOP) adalah paradigma pemrograman yang berfokus pada objek sebagai unit dasar pemrograman. Di C#, OOP sangat penting, dan Anda dapat menggunakan konsep OOP seperti kelas, objek, warisan, enkapsulasi, dan polimorfisme. Berikut ini beberapa contoh OOP dalam C#:

1. **Kelas dan Objek**:
   ```csharp
   // Mendefinisikan kelas
   class Mobil
   {
       // Atribut
       public string Merek { get; set; }
       public string Model { get; set; }

       // Metode
       public void Start()
       {
           Console.WriteLine("Mobil dinyalakan.");
       }
   }

   // Menggunakan objek
   Mobil mobil1 = new Mobil();
   mobil1.Merek = "Toyota";
   mobil1.Model = "Camry";
   mobil1.Start();
   ```

2. **Warisan (Inheritance)**:
   ```csharp
   // Kelas dasar
   class Kendaraan
   {
       public string Jenis { get; set; }
       public void Bergerak()
       {
           Console.WriteLine("Kendaraan bergerak.");
       }
   }

   // Kelas turunan
   class Mobil : Kendaraan
   {
       public string Merek { get; set; }
   }

   Mobil mobil1 = new Mobil();
   mobil1.Jenis = "Sedan";
   mobil1.Merek = "Toyota";
   mobil1.Bergerak();
   ```

3. **Enkapsulasi**:
   ```csharp
   class Manusia
   {
       private string nama;
       public string Nama
       {
           get { return nama; }
           set { nama = value; }
       }

       public void Sapa()
       {
           Console.WriteLine($"Halo, nama saya {Nama}.");
       }
   }

   Manusia orang = new Manusia();
   orang.Nama = "John";
   orang.Sapa();
   ```

4. **Polimorfisme**:
   ```csharp
   class Hewan
   {
       public virtual void Suara()
       {
           Console.WriteLine("Hewan membuat suara.");
       }
   }

   class Kucing : Hewan
   {
       public override void Suara()
       {
           Console.WriteLine("Meow!");
       }
   }

   Hewan hewan = new Kucing();
   hewan.Suara(); // Output: Meow!
   ```

Ini adalah beberapa contoh dasar dari konsep OOP dalam C#. Anda dapat menggabungkan konsep-konsep ini untuk membangun aplikasi yang lebih kompleks dan terstruktur.
