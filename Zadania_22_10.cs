using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

    public class Zadania_22_10
    {
    public void zad3_1()
    {
        Console.WriteLine("Podaj rok do sprawdzenia:");
        int rok = int.Parse(Console.ReadLine());

        if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
        {
            Console.WriteLine($"{rok} jest rokiem przestępnym.");
        }
        else
        {
            Console.WriteLine($"{rok} nie jest rokiem przestępnym.");
        }
    }

    public void zad3_2()
    {
        Console.WriteLine("Podaj pierwszą liczbę całkowitą:");
        int liczba1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę całkowitą:");
        int liczba2 = int.Parse(Console.ReadLine());

        if (liczba1 % liczba2 == 0)
        {
            Console.WriteLine($"Liczba {liczba2} jest dzielnikiem liczby {liczba1}.");
        }
        else
        {
            Console.WriteLine($"Liczba {liczba2} nie jest dzielnikiem liczby {liczba1}.");
        }
    }

    public void zad3_3()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        int liczba1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int liczba2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj trzecią liczbę:");
        int liczba3 = int.Parse(Console.ReadLine());

        int najwieksza = liczba1;
        if (liczba2 > najwieksza)
        {
            najwieksza = liczba2;
        }

        if (liczba3 > najwieksza)
        {
            najwieksza = liczba3;
        }

        Console.WriteLine($"Największa liczba to: {najwieksza}");
    }

    public void zad3_4()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        double liczba2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj operację (+, -, * lub /):");
        char operacja = Console.ReadLine()[0];

        double wynik;

        switch (operacja)
        {
            case '+':
                wynik = liczba1 + liczba2;
                break;
            case '-':
                wynik = liczba1 - liczba2;
                break;
            case '*':
                wynik = liczba1 * liczba2;
                break;
            case '/':
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieznana operacja.");
                return;
        }

        Console.WriteLine($"Wynik operacji {liczba1} {operacja} {liczba2} = {wynik}");
    }

    public void zad3_5()
    {
        Console.WriteLine("Podaj współczynnik a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik c:");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste.");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty.");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }

    public void zad3_6()
    {
        Console.WriteLine("Podaj wagę w kg:");
        double masa = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wzrost w metrach:");
        double wzrost = double.Parse(Console.ReadLine());

        double bmi = masa / (wzrost * wzrost);

        if (bmi < 16)
        {
            Console.WriteLine($"BMI = {bmi}: Wygłodzenie");
        }
        else if (bmi < 16.99)
        {
            Console.WriteLine($"BMI = {bmi}: Wychudzenie");
        }
        else if (bmi < 18.49)
        {
            Console.WriteLine($"BMI = {bmi}: Niedowaga");
        }
        else if (bmi < 24.99)
        {
            Console.WriteLine($"BMI = {bmi}: Wartość prawidłowa");
        }
        else if (bmi < 29.99)
        {
            Console.WriteLine($"BMI = {bmi}: Nadwaga");
        }
        else if (bmi < 34.99)
        {
            Console.WriteLine($"BMI = {bmi}: Otyłość I stopnia");
        }
        else if (bmi < 39.99)
        {
            Console.WriteLine($"BMI = {bmi}: Otyłość II stopnia (duża)");
        }
        else
        {
            Console.WriteLine($"BMI = {bmi}: Otyłość III stopnia (chorobliwa)");
        }
    }
    public void zad3_8()
    {
        Console.WriteLine("Podaj średnią ocen:");
        double srednia = double.Parse(Console.ReadLine());

        if (srednia >= 2.0 && srednia <= 3.99)
        {
            Console.WriteLine("Kwota stypendium: 0,00 zł");
        }
        else if (srednia >= 4.0 && srednia <= 4.79)
        {
            Console.WriteLine("Kwota stypendium: 350,00 zł");
        }
        else if (srednia >= 4.8 && srednia <= 5.0)
        {
            Console.WriteLine("Kwota stypendium: 550,00 zł");
        }
        else
        {
            Console.WriteLine("Podana średnia jest poza zakresem.");
        }
    }

    public void zad3_9()
    {
        Console.WriteLine("Wybierz figurę (a, b, c, d):");
        char figura = Console.ReadLine()[0];

        Console.WriteLine("Podaj liczbę wierszy:");
        int wiersze = int.Parse(Console.ReadLine());

        switch (figura)
        {
            case 'a':
                for (int i = 1; i <= wiersze; i++)
                {
                    Console.WriteLine(new System.String('*', i));
                }
                break;
            case 'b':
                for (int i = wiersze; i > 0; i--)
                {
                    Console.WriteLine(new System.String('*', i));
                }
                break;
            case 'c':
                for (int i = 0; i < wiersze; i++)
                {
                    Console.WriteLine(new System.String(' ', wiersze - i - 1) + new System.String('*', i + 1));
                }
                break;
            case 'd':
                for (int i = 1; i <= wiersze; i++)
                {
                    if (i == 1 || i == wiersze)
                    {
                        Console.WriteLine(new System.String('*', wiersze));
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new System.String(' ', wiersze - 2));
                        Console.WriteLine("*");
                    }
                }
                break;
            default:
                Console.WriteLine("Nieznana figura.");
                break;
        }
    }

    public void zad3_10()
    {
        Console.WriteLine("Podaj liczbę");
        int liczba = int.Parse(Console.ReadLine());
        //oblicz silnie z podanej liczby
        int silnia = 1;
        for (int i = 1; i <= liczba; i++)
        {
            silnia *= i;
        }
        Console.WriteLine($"Silnia z {liczba} wynosi {silnia}");
    }

    public void zad3_11()
    {
        int suma = 0;
        int licznik = 0;

        while (suma <= 100)
        {
            licznik++;
            suma += licznik;
        }

        Console.WriteLine($"Aby suma przekroczyła 100, należy dodać do siebie {licznik} kolejnych liczb całkowitych.");
    }
    public void zad3_12()
    {
        int suma = 0;
        int liczba;

        Console.WriteLine("Podaj liczby całkowite (0 kończy wprowadzanie):");

        do
        {
            liczba = int.Parse(Console.ReadLine());
            suma += liczba;
        } while (liczba != 0);

        Console.WriteLine($"Suma wprowadzonych liczb wynosi: {suma}");
    }

    public void zad3_13()
    {
        Console.WriteLine("Podaj liczbę naturalną n:");
        int n = int.Parse(Console.ReadLine());
        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                suma -= i;
            }
            else
            {
                suma += i;
            }
        }

        Console.WriteLine($"Suma szeregu W(n) dla n = {n} wynosi: {suma}");
    }

    public void zad3_14()
    {
        Console.WriteLine("Podaj górną granicę przedziału n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Liczby doskonałe w przedziale <1, {n}>:");
        for (int liczba = 1; liczba <= n; liczba++)
        {
            int sumaPodzielnikow = 0;
            for (int dzielnik = 1; dzielnik <= liczba / 2; dzielnik++)
            {
                if (liczba % dzielnik == 0)
                {
                    sumaPodzielnikow += dzielnik;
                }
            }

            if (sumaPodzielnikow == liczba)
            {
                Console.WriteLine(liczba);
            }
        }
    }

    public void zad3_15()
    {
        int suma = 10;
        int sposoby = 0;

        for (int piec = 0; piec <= suma / 5; piec++)
        {
            for (int dwa = 0; dwa <= suma / 2; dwa++)
            {
                for (int jeden = 0; jeden <= suma; jeden++)
                {
                    if (piec * 5 + dwa * 2 + jeden == suma)
                    {
                        Console.WriteLine($"{piec} x 5zł, {dwa} x 2zł, {jeden} x 1zł");
                        sposoby++;
                    }
                }
            }
        }

        Console.WriteLine($"Można wypłacić 10zł na {sposoby} różnych sposobów.");
    }

}

