using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
    public static void Main(string[] args)
    {
        SimpleDataBase<string> database = new SimpleDataBase<string>();
        database.AddNewdata("12");
        database.AddNewdata("34");
        database.AddNewdata("56");
        database.PrintAllData();
    }
}