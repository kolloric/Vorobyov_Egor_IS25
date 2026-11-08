using System;
using System.Numerics;
using System.Security.Cryptography;
class Program()
{
    static void Main()
    {
        bebe1();
        bebe2();
        bebe3();
        bebe4();
        bebe5();
        bebe6();
        bebe7();
        bebe8();
    }
    // Задача 1
    static void bebe1()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 1");
        Console.ResetColor();
        int[] Arr;
        (int value, int index) ArrMax(int[] arr)
        {
            if (arr == null || arr.Length == 0) throw new ArgumentException();
            int value = 0; int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > value)
                {
                    value = arr[i];
                    index = i;
                }
            }
            return (value, index);
        }
        int[] bebe = new int[5];
        Random rnd = new Random();
        for (int i = 0; i < bebe.Length; i++)
        {
            bebe[i] = i + 1;
            bebe[i] = rnd.Next(1, 50);
        }
        Console.WriteLine($"Массив: [{string.Join(", ", bebe)}]");
        var (val, idx) = ArrMax(bebe);
        Console.WriteLine($"Максимальный элемент: {val}, его индекс: {idx}");
    }
    // Задача 2
    static void bebe2()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 2");
        Console.ResetColor();
        static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        double a = ReadDouble("Введите сторону a: ");
        double b = ReadDouble("Введите сторону b: ");
        double c = ReadDouble("Введите сторону c: ");
        Console.WriteLine("Периметр: " + Perimeter(a, b, c));
        static double ReadDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Ошибка: это не число. Попробуйте ещё раз.");
                }
            }
        }
    }
    // Задача 3
    static void bebe3()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 3");
        Console.ResetColor();
        static double GetPow(double number, double power)
        {
            if (power < 0)
            {
                throw new ArgumentException("ОТРИЦАТЕЛЬНАЯ СТЕПЕНЬ");
            }
            double result = 1;
            for (double i = 0; i < number; i++)
            {
                result *= power;
            }
            return result;
        }

        double number = 0, power = 0;
        while (true)
        {
            Console.WriteLine("Введите число а: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
                break;
            Console.WriteLine("Введено не число");
        }
        while (true)
        {
            Console.Write("Введите степень: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out power))
                break;
            Console.WriteLine("Введено не число");
        }
        try
        {
            Console.WriteLine($"{number} в степени {power} = {GetPow(number, power)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
    // Задача 4
    static void bebe4()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 4");
        Console.ResetColor();
        static double distance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        double x1, y1, x2, y2;
        while (true)
        {
            Console.WriteLine("Введи х1: ");
            if (double.TryParse(Console.ReadLine(), out x1))
                break;
            Console.WriteLine("Введено не число");
        }
        while (true)
        {
            Console.WriteLine("Введи y1: ");
            if (double.TryParse(Console.ReadLine(), out y1))
                break;
            Console.WriteLine("Введено не число");
        }
        while (true)
        {
            Console.WriteLine("Введи х2: ");
            if (double.TryParse(Console.ReadLine(), out x2))
                break;
            Console.WriteLine("Введено не число");
        }
        while (true)
        {
            Console.WriteLine("Введи y2: ");
            if (double.TryParse(Console.ReadLine(), out y2))
                break;
            Console.WriteLine("Введено не число");
        }
        double result = distance(x1, y1, x2, y2);
        Console.WriteLine($"ДЕРЖИ {result}");
    }
    // Задача 5
    static void bebe5()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 5");
        Console.ResetColor();
        double[] Arr = new double[10];
        static void MinMax (ref double a, ref double b)
        {
            if (a < b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
        }
        double x = 5, y = 10;
        MinMax (ref x, ref y);
        Console.WriteLine($"ВО: x = {x}, y = {y}");
    }
    // Задача 6
    static void bebe6()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 6");
        Console.ResetColor();
        static void ChangeDigits(ref int J) // Я В ШОКЕ, ФИГА ПРЫКОЛЬНО
        {
            int a = J / 10;
            int b = J % 10;
            J = b * 10 + a;
        }
        int num = 36;
        ChangeDigits(ref num);
        Console.WriteLine($"Держи яйтсо: {num}");
    }
    // Задача 7
    static void bebe7()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 7");
        Console.ResetColor();
        static int f(int a, int b)
        {
            int a1 = a / 10, a2 = b % 10;
            int b1 = b / 10, b2 = b % 10;
            int s1 = (a1 + b1) % 10;
            int s2 = (a2 + b2) % 10;
            return s1 * 10 + s2;
        }
        int x = 23; int y = 12;
        f(x, y);
        Console.WriteLine($"Делалось ночью...{f(x, y)}");
    }
    // Задача 8
    static void bebe8()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 8");
        Console.ResetColor();
        static int[] ArrMul(int[] mas1, int[] mas2)
        {
            int L = mas1.Length;
            int[] mCool = new int[L];
            for (int i = 0; i < L; i++)
            {
                mCool[i] = mas1[i] * mas2[i];
            }
            return mCool;
        }
        int[] A = {5, 2 ,1};
        int[] B = {4, 1, 6};
        int[] C = ArrMul(A, B);
        Console.WriteLine($"бубух [{string.Join(", ", C)}]");
    }
}
