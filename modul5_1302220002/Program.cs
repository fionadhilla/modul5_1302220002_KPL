
using System;

public class Penjumlahan<T>
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic nomor1 = angka1;
        dynamic nomor2 = angka2;
        dynamic nomor3 = angka3;
       Console.WriteLine("Hasil penjumlahan: " + (nomor1+ nomor2+ nomor3));

    }
}

class program
{
    static void Main(string[] args)
    {
        Penjumlahan<float> jumlah_1302220002 = new Penjumlahan<float>();
        jumlah_1302220002.JumlahTigaAngka(13, 00, 02);
    }


}
