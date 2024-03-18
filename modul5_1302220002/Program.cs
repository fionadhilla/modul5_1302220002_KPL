using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Penjumlahan<T>
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic nomor1 = angka1;
        dynamic nomor2 = angka2;
        dynamic nomor3 = angka3;
        Console.WriteLine("Hasil penjumlahan: " + (nomor1 + nomor2 + nomor3));
    }
}


public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDatese;

    public SimpleDataBase()
    {
        this.storedData = new List<T>(); 
        this.inputDatese = new List<DateTime>();    
    }

    public void AddNewdata(T data)
    {
        storedData.Add(data);
        inputDatese.Add(DateTime.Now);

    }

    public void PrintAllData()
    {
       for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i} berisi: {storedData.ElementAt(i)}, yang disimpan pada waktu {inputDatese.ElementAt(i)}");
        }

    }
}

class program
{

    static void Main(string[] args)
    {
        Penjumlahan<float> jumlah_1302220002 = new Penjumlahan<float>();
        jumlah_1302220002.JumlahTigaAngka(13, 00, 02);
        SimpleDataBase<string> database = new SimpleDataBase<string>();
        database.AddNewdata("12");
        database.AddNewdata("34");
        database.AddNewdata("56");
        database.PrintAllData();
    }


}
