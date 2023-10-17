using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Zadania_07_10_2023
    {
        static void Main(string[] args)
        {
            Zadania_07_10_2023 zadania = new Zadania_07_10_2023();
            //wpisz jakie zadanie chcesz wywołać

            zadania.zadanie2_10();
        }
        public void zadanie2_1()
        {
            Console.WriteLine("Zad 2.1");
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celsjusza");
            C = double.Parse(Console.ReadLine());
            F = 32 + (9d / 5) * C;
            Console.WriteLine(F);
            Console.ReadKey();
        }
        public void zadanie2_2()
        {
            Console.WriteLine("Zad 2.2");
            Console.WriteLine("Program oblicza deltę dla równania kwadratowego");
            Console.WriteLine("Podaj współczynnik a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            Console.WriteLine($"Delta wdla współczynników a:{a}, b:{b}, c:{c} wynosi:{delta} \n");
            Console.ReadKey();
        }

        public void zadanie2_3()
        {
            Console.WriteLine("Zad 2.3");
            Console.WriteLine("Program oblicza BMI");

            double KG, Metry;
            Console.WriteLine("Podaj wagę w kilogramach");
            KG = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach");
            Metry = double.Parse(Console.ReadLine());
            double BMI = KG / (Metry * Metry);
            Console.WriteLine(BMI);
            Console.ReadKey();
        }

        public void zadanie2_456()
        {
            Console.WriteLine("Zadanie 2.4");
            int x = 100;
            Console.WriteLine(++x * 2);
            Console.WriteLine("Odpowiedź a \n wciśnij klawisz aby kontynuować");
            Console.ReadKey();

            Console.WriteLine("Zadanie 2.5");
            int c = 2, v = 3;
            c *= v * 2;
            Console.WriteLine(c);
            Console.WriteLine("Odpowiedź d \n wciśnij klawisz aby kontynuowa");
            Console.ReadKey();

            Console.WriteLine("Zadanie 2.6");
                int o, u = 4;
                o = (u -= 2);
                o = u++;
                o = u--;
            Console.WriteLine(o);
            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć");
            Console.ReadKey();
        }

        public void zadanie2_7()
        {
            Console.WriteLine("Zadanie 2.7");
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć");
            Console.ReadKey();
        }

        public void zadanie2_8()
        {
            Console.WriteLine("Zadanie 2.8");
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"Zmienne przjmują wartośc: x:{x}, y:{y}, z:{z}");
            Console.ReadKey();
        }

        public void zadanie2_9()
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
            Console.ReadKey(true);
        }

        public void zadanie2_10()
        {
            Console.WriteLine("Zad 2.10");
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / (double)powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey(true);
        }

    }
}
