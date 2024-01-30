using System;

public class Zadania_07_10
{
    public void zad2_1()
    {
        Console.WriteLine("Zad 2.1");
        Console.WriteLine("Ten program przeliczy temperaturę w stopniach Celsiusza na stopnie Fahrenheita.");
        Console.Write("Podaj temperaturę w stopniach Celsiusza: ");
        double tempInCelsius = double.Parse(Console.ReadLine());
        
        double tempInFarenheit = 32 + (9.0 / 5) * tempInCelsius;
        
        Console.WriteLine($"Temperatura w stopniach Fahrenheita wynosi: {tempInFarenheit} °F \n");
    }

    public void zad2_2()
    {
        Console.WriteLine("Zad 2.2");
        Console.WriteLine("Ten program obliczy deltę dla równania kwadratowego");
        Console.Write("Podaj wartośc współczynnika a:");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("Podaj wartośc współczynnika b:");
        double b = double.Parse(Console.ReadLine());
        
        Console.Write("Podaj wartośc współczynnika c:");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Delta dla współczynników a:{a} b:{b} c:{c} wynosi:{delta} \n");
    }

    public void zad2_3()
    {
        Console.WriteLine("Zad 2.3");
        Console.WriteLine("Ten program obliczy wskaźnik masy ciała BMI");
        Console.Write("Podaj wagę w kg:");
        double waga = double.Parse(Console.ReadLine());
        Console.Write("Podaj wzrost w metrach:");
        double wzrost = double.Parse(Console.ReadLine());
        double BMI = waga / (wzrost * wzrost);
        Console.WriteLine($"Twoje BMI to {BMI} \n");
    }

    public void zad2_4()
    {
        Console.WriteLine("Zad 2.4");
        int x = 100;
        Console.WriteLine(++x * 2);
        Console.WriteLine("\n");
    }

    public void zad2_5()
    {
        Console.WriteLine("Zad 2.5");
        int x = 2, y = 3;
        x *= y * 2;
        Console.WriteLine(x);
        Console.WriteLine("\n");
    }

    public void zad2_6()
    {
        Console.WriteLine("Zad 2.6");
        int x, y = 4;
        x = (y -= 2);
        x = y++;
        x = y--;
        Console.WriteLine(x);
        Console.WriteLine("\n");
    }
    public void zad2_7()
    {
        Console.WriteLine("Zad 2.7");
        int x, y = 5;
        x = ++y * 2;
        x = y++;
        x = y--;
        Console.WriteLine(++y);
        Console.WriteLine("\n");
    }
    
    public void zad2_8()
    {
        Console.WriteLine("Zad 2.8");
        bool x;
        int y = 1, z = 1;
        x = (y == 1 && z++ == 1);
        Console.WriteLine($"x={x} y={y} z={z}");
        Console.WriteLine("\n");
    }

    public void zad2_9()
    {
        Console.WriteLine("Zad 2.9");
        int ax = 1, ay = 4, az = 2;
        bool awynik = (ax++ > 1 && ay++ == 4 && az-- > 0);
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", awynik, ax, ay, az);
        
        int bx = 1, by = 4, bz = 2;
        bool bwynik = (bx++ > 1 & by++ == 4 && bz-- > 0);
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", bwynik, bx, by, bz);
        
        int cx = 1, cy = 4, cz = 2;
        bool cwynik = (cx++ > 1 & cy++ == 4 & cz-- > 0);
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", cwynik, cx, cy, cz);
        
        int dx = 1, dy = 3, dz = 4;
        bool dwynik = (dx == 1 || dy++ > 2 || ++dz > 0);
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", dwynik, dx, dy, dz);
        
        int ex = 1, ey = 3, ez = 4;
        bool ewynik = (ex == 1 | ey++ > 2 || ++ez > 0);
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", ewynik, ex, ey, ez);
        
        int fx = 1, fy = 3, fz = 4;
        bool fwynik = (fx == 1 | fy++ > 2 | ++fz > 0);
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", fwynik, fx, fy, fz);

        Console.WriteLine("\n");


    }

    public void zad2_10()
    {
        Console.WriteLine("Zad 2.10");
        int powierzchnia = 100, osoby = 10;
        double gestoscZaludnienia = (double)osoby/(double)powierzchnia;
        Console.WriteLine(gestoscZaludnienia);
    }
}