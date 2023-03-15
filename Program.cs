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
class PosisiKarakterGame
{
    enum State
    {
        Berdiri,
        Tengkurap
    }
    private State state = State.Berdiri;
    public void Berdiri()
    {
        state = State.Berdiri;
        Console.WriteLine("posisi standby");
    }
    public void Tengkurap()
    {
        state = State.Tengkurap;
        Console.WriteLine("posisi istirahat");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PosisiKarakterGame door = new PosisiKarakterGame();

        KodeBuah namaBuah = new KodeBuah();
        Console.WriteLine("Apel " + namaBuah.getKodeBuah("Apel"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Aprikot " + namaBuah.getKodeBuah("Aprikot"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Alpukat " + namaBuah.getKodeBuah("Alpukat"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Pisang " + namaBuah.getKodeBuah("Pisang"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Paprika " + namaBuah.getKodeBuah("Paprika"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Blackberry " + namaBuah.getKodeBuah("Blackberry"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Ceri " + namaBuah.getKodeBuah("Ceri"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Kelapa " + namaBuah.getKodeBuah("Kelapa"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Jagung " + namaBuah.getKodeBuah("Jagung"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Kurma " + namaBuah.getKodeBuah("Kurma"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Durian " + namaBuah.getKodeBuah("Durian"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Anggur " + namaBuah.getKodeBuah("Anggur"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Melon " + namaBuah.getKodeBuah("Melon"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine("Semangka " + namaBuah.getKodeBuah("Semangka"));
        door.Berdiri();
        door.Tengkurap();
        Console.WriteLine(namaBuah.getKodeBuah("Pepaya"));
    }
}