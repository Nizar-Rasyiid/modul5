﻿using System.Numerics;


internal class Program
{
    public class Penjumlahan<T>
    {

        public T JumlahTigaAngka<T>(T a, T b, T c) where T : IAdditionOperators<T, T, T>
        {
            return a + b + c;
        }
    }
    public class SimpleDataBase<T>
    {
        private List<T> storedData { get;set; }
        private List<DateTime> inputDates { get; set; }

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T List)
        {
            storedData.Add(List);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi : " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
            }
        }
    }

    static void Main(string[] args)
    {
        Penjumlahan<int> JumlahTigaAngka = new Penjumlahan<int>();
        Console.WriteLine(JumlahTigaAngka.JumlahTigaAngka(13, 02, 22));
        SimpleDataBase<int> Data = new SimpleDataBase<int>();
        Data.AddNewData(13);
        Data.AddNewData(02);
        Data.AddNewData(22);
        Data.PrintAllData();
        Console.ReadLine();
    }
}