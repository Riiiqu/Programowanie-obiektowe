using System;
using System.Collections.Generic;
using System.Linq;

public class Osoba
{
    private string imie;
    private int wiek;

    public Osoba(string imie, int wiek)
    {
        this.imie = imie;
        this.wiek = wiek;
    }

    public string PobierzImie()
    {
        return imie;
    }

    public int PobierzWiek()
    {
        return wiek;
    }
}

public class Program
{
    public static void Main()
    {
        // a. Utworzenie kolekcji
        var listaInt = new List<int> { 1, 2, 3 };
        var kolejkaString = new Queue<string>();
        kolejkaString.Enqueue("element1");
        kolejkaString.Enqueue("element2");
        var stosOsob = new Stack<Osoba>();
        stosOsob.Push(new Osoba("Jan", 30));
        stosOsob.Push(new Osoba("Anna", 25));

        // b. Dodanie elementów do kolekcji
        listaInt.Add(4); // Dodanie do listy
        kolejkaString.Enqueue("element3"); // Dodanie do kolejki
        stosOsob.Push(new Osoba("Krzysztof", 40)); // Dodanie do stosu

        // c. Usunięcie elementu z listy, jeśli jest mniej niż 5 elementów
        if (listaInt.Count < 5)
        {
            listaInt.Remove(listaInt.Last()); // Usunięcie ostatniego elementu
        }

        // d. Wyświetlenie elementów kolekcji
        Console.WriteLine("Lista int:");
        foreach (int liczba in listaInt)
        {
            Console.WriteLine(liczba);
        }

        Console.WriteLine("\nKolejka string:");
        foreach (string element in kolejkaString)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("\nStos osob:");
        foreach (Osoba osoba in stosOsob)
        {
            Console.WriteLine($"Imię: {osoba.PobierzImie()}, Wiek: {osoba.PobierzWiek()}");
        }

        // e. Próba wydobycia pierwszego, trzeciego i ostatniego elementu z listy
        Console.WriteLine("\nPróba wydobycia elementów z listy:");
        Console.WriteLine(listaInt.FirstOrDefault()); // Pierwszy element
        Console.WriteLine(listaInt.ElementAtOrDefault(2)); // Trzeci element, jeśli istnieje
        Console.WriteLine(listaInt.LastOrDefault()); // Ostatni element

        // f. Odwrócenie kolejności elementów w liście
        listaInt.Reverse();
        Console.WriteLine("\nLista int po odwróceniu:");
        listaInt.ForEach(item => Console.WriteLine(item));

        // g. Dla kolejki i stosu nie ma prostej metody odwrócenia kolejności elementów.
        // Zamiast tego można by wykorzystać pomocniczą listę lub stos/kolejkę.
    }
}
