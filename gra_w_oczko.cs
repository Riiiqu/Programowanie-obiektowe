using System;
using System.Collections.Generic;

public enum Kolor
{
    Kier,
    Karo,
    Pik,
    Trefl
}

public enum Wartosc
{
    Dwojka = 2,
    Trojka = 3,
    Czworka = 4,
    Piatka = 5,
    Szostka = 6,
    Siodemka = 7,
    Osemka = 8,
    Dziewiatka = 9,
    Dziesiatka = 10,
    Walet = 2,
    Dama = 3,
    Krol = 4,
    As = 11  // W grze w oczko As może mieć wartość 1 lub 11, tutaj przyjmujemy 11
}

public class Karta
{
    public Kolor Kolor { get; private set; }
    public Wartosc Wartosc { get; private set; }

    public Karta(Kolor kolor, Wartosc wartosc)
    {
        Kolor = kolor;
        Wartosc = wartosc;
    }

    public override string ToString()
    {
        return $"{Wartosc} {Kolor}";
    }
}

public class Talia
{
    private Stack<Karta> karty = new Stack<Karta>();

    public Talia()
    {
        foreach (Kolor kolor in Enum.GetValues(typeof(Kolor)))
        {
            foreach (Wartosc wartosc in Enum.GetValues(typeof(Wartosc)))
            {
                karty.Push(new Karta(kolor, wartosc));
            }
        }

        // Talię należy jeszcze potasować
        var rng = new Random();
        var mieszaneKarty = new List<Karta>(karty);
        for (int i = mieszaneKarty.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            var temp = mieszaneKarty[i];
            mieszaneKarty[i] = mieszaneKarty[j];
            mieszaneKarty[j] = temp;
        }

        karty = new Stack<Karta>(mieszaneKarty);
    }

    public Karta DobierzKarte()
    {
        if (karty.Count > 0)
            return karty.Pop();
        throw new InvalidOperationException("Brak kart w talii.");
    }
}

public class Gracz
{
    public List<Karta> Reka { get; private set; }

    public Gracz()
    {
        Reka = new List<Karta>();
    }

    public void WezKarte(Karta karta)
    {
        Reka.Add(karta);
    }

    public int ObliczPunkty()
    {
        int suma = 0;
        foreach (var karta in Reka)
        {
            suma += (int)karta.Wartosc;
        }
        return suma;
    }
}

public class Gra
{
    private Talia talia;
    private Gracz gracz;

    public Gra()
    {
        talia = new Talia();
        gracz = new Gracz();
    }

    public void Rozpocznij()
    {
        while (gracz.ObliczPunkty() < 21)
        {
            gracz.WezKarte(talia.DobierzKarte());
            Console.WriteLine("Dobrana karta: " + gracz.Reka[^1]);
            Console.WriteLine("Suma punktów: " + gracz.ObliczPunkty());
        }

        if (gracz.ObliczPunkty() == 21)
        {
            Console.WriteLine("Gratulacje, 21 punktów!");
        }
        else
        {
            Console.WriteLine("Przegrana, więcej niż 21 punktów.");
        }
    }
}

// Uruchomienie gry
class Program
{
    static void Main()
    {
        var gra = new Gra();
        gra.Rozpocznij();
    }
}
