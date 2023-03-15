// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodeBuah
{
    Dictionary<string, string> Kode_buah = new Dictionary<string, string>()
    {
        { "Apel", "A00" },
        { "Aprikot", "B00" },
        { "Alpukat", "C00" },
        { "Pisang", "D00" },
        { "Paprika", "E00" },
        { "Blackberry", "F00" },
        { "Ceri", "H00" },
        { "Kelapa", "I00" },
        { "Jagung", "J00" },
        { "Kurma", "K00" },
        { "Durian", "L00" },
        { "Anggur", "M00" },
        { "Melon", "N00" },
        { "Semangka", "O00" }
    };

    public string getKodeBuah(string namaBuah)
    {
        string kode;
        if (Kode_buah.TryGetValue(namaBuah, out kode))
        {
            return kode;
        }
        else
        {
            return "Nama buah tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeBuah namaBuah = new KodeBuah();
        Console.WriteLine("Apel " + namaBuah.getKodeBuah("Apel"));
        Console.WriteLine("Aprikot " + namaBuah.getKodeBuah("Aprikot"));
        Console.WriteLine("Alpukat " + namaBuah.getKodeBuah("Alpukat"));
        Console.WriteLine("Pisang " + namaBuah.getKodeBuah("Pisang"));
        Console.WriteLine("Paprika " + namaBuah.getKodeBuah("Paprika"));
        Console.WriteLine("Blackberry " + namaBuah.getKodeBuah("Blackberry"));
        Console.WriteLine("Ceri " + namaBuah.getKodeBuah("Ceri"));
        Console.WriteLine("Kelapa " + namaBuah.getKodeBuah("Kelapa"));
        Console.WriteLine("Jagung " + namaBuah.getKodeBuah("Jagung"));
        Console.WriteLine("Kurma " + namaBuah.getKodeBuah("Kurma"));
        Console.WriteLine("Durian " + namaBuah.getKodeBuah("Durian"));
        Console.WriteLine("Anggur " + namaBuah.getKodeBuah("Anggur"));
        Console.WriteLine("Melon " + namaBuah.getKodeBuah("Melon"));
        Console.WriteLine("Semangka " + namaBuah.getKodeBuah("Semangka"));
        Console.WriteLine(namaBuah.getKodeBuah("Pepaya"));
    }
}