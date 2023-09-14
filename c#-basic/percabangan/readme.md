Dalam bahasa pemrograman C#, Anda dapat menggunakan beberapa jenis percabangan untuk mengontrol alur program Anda. Berikut beberapa contoh percabangan dalam C#:

1. **Percabangan If-Else:**
Percabangan if-else digunakan untuk melakukan perbandingan dan mengambil keputusan berdasarkan kondisi yang diberikan.

```csharp
int nilai = 75;

if (nilai >= 70)
{
    Console.WriteLine("Anda lulus.");
}
else
{
    Console.WriteLine("Anda tidak lulus.");
}
```

2. **Percabangan Switch:**
Percabangan switch digunakan ketika Anda ingin memeriksa nilai dari sebuah ekspresi dan menjalankan kode berdasarkan nilai itu.

```csharp
int pilihan = 2;

switch (pilihan)
{
    case 1:
        Console.WriteLine("Anda memilih opsi 1.");
        break;
    case 2:
        Console.WriteLine("Anda memilih opsi 2.");
        break;
    default:
        Console.WriteLine("Pilihan tidak valid.");
        break;
}
```

3. **Percabangan Ternary:**
Percabangan ternary adalah singkatnya dari if-else yang digunakan untuk mengembalikan nilai berdasarkan kondisi.

```csharp
int angka = 10;
string hasil = (angka > 5) ? "Lebih besar dari 5" : "Kurang dari atau sama dengan 5";
Console.WriteLine(hasil);
```

4. **Percabangan Bersarang:**
Anda juga dapat menggunakan percabangan bersarang, yaitu satu percabangan di dalam percabangan lainnya.

```csharp
int x = 10;
int y = 5;

if (x > 5)
{
    if (y > 2)
    {
        Console.WriteLine("Kondisi terpenuhi.");
    }
    else
    {
        Console.WriteLine("Kondisi kedua tidak terpenuhi.");
    }
}
else
{
    Console.WriteLine("Kondisi pertama tidak terpenuhi.");
}
```

5. **Percabangan dengan Logika Boolean:**
Percabangan juga dapat digunakan dengan operator logika boolean, seperti AND (&&) atau OR (||), untuk menggabungkan beberapa kondisi.

```csharp
int usia = 25;
bool memilikiSIM = true;

if (usia >= 18 && memilikiSIM)
{
    Console.WriteLine("Anda dapat mengemudi.");
}
else
{
    Console.WriteLine("Anda tidak dapat mengemudi.");
}
```

Itulah beberapa contoh dasar percabangan dalam bahasa pemrograman C#. Anda dapat menggunakan percabangan ini untuk mengendalikan alur program Anda berdasarkan kondisi-kondisi yang berbeda.
