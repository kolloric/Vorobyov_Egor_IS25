// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ExceptionServices;
class Program
{ // Вот эта строка короче от Program
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
        bebe9();
        bebe10();
        bebe11();
        bebe12();
        bebe13();
        bebe14();
    }

    // Задача 1
    static void bebe1()
    {
        int[] B = new int[15];
        int countPositive = 0;
        int sumOdd = 0;
        Random rnd = new Random();
        for (int i = 0; i < B.Length; i++)
        {
            B[i] = i + 1;
            B[i] = rnd.Next(-50, 50);

        int current = B[i];
            if (current > 0)
            {
                countPositive++;
            }
            if (current % 2 != 0)
            {
                sumOdd += current;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 1");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", B)}]");
        Console.WriteLine("Количество положительных: " + countPositive);
        Console.WriteLine("Сумма нечетных: " + sumOdd);
    }
    // Задача 2
    static void bebe2()
    {
        int[] A = new int[10];
        int sumPositive = 0;
        int countEven = 0;
        Random rnd = new Random();
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = i + 1;
            A[i] = rnd.Next(-50, 50);
            int current = A[i];
            if (current > 0)
            {
                sumPositive += current;
            }
            if (current % 2 == 0)
            {
                countEven++;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 2");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", A)}]");
        Console.WriteLine("Сумма положительных: " + sumPositive);
        Console.WriteLine("Количество четных: " + countEven);
    }

    // Задача 3
    static void bebe3()
    {
        int[] T = new int[15];
        long sum = 0;
        int count = 0;
        double average = 0;
        Random rnd = new Random();
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = i + 1;
            T[i] = rnd.Next(-50, 50);
            int current = T[i];
            if (current >= 5 && current <= 15)
            {
                sum += T[i];
                count++;
            if (count > 0)
            {
                average = (double)sum / count;
            }
            else
                {
                    average = 0; 
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 3");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", T)}]");
        Console.WriteLine("Среднее арифметическое: " + average);
    }
    // Задача 4
    static void bebe4()
    {
        int[] C = new int[10];
        double productEven = 1.0;
        int countEven = 0;
        long sumOdd = 0;
        Random rnd = new Random();
        for (int i = 0; i < C.Length; i++)
        {
            C[i] = i + 1;
            C[i] = rnd.Next(-50, 50);
        }
            for (int i = 0; i < C.Length; i++)
        {
            if (C[i] % 2 == 0)
            {
                productEven *= C[i];
                countEven++;
            }
            else
            {
                sumOdd += C[i];
            }
        }    
        double geometricMean = 0.0;
            if (countEven > 0)
            {
            // 1.0 обязательно, иначе 1/countEven будет целочисленным делением (часто 0)
            geometricMean = Math.Pow(productEven, 1.0 / countEven);
            }
            else
            {
                Console.WriteLine("В массиве нет чётных элементов, среднее геометрическое не определено.");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вариант 4");
            Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", C)}]");
        Console.WriteLine("Среднее геометрическое: " + geometricMean);
            Console.WriteLine("Сумма нечетных чисел: " + sumOdd);
    }
    // Задача 5
    static void bebe5()
    {
        int[] B = new int[16];
        Random rnd = new Random();
        for (int i = 0; i < B.Length; i++)
        {
            B[i] = i + 1;
            B[i] = rnd.Next(-50, 50);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 5");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", B)}]");
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (i % 4 == 0 && B[i] <= a)
            {
                count++;
            }
        }
        
        Console.WriteLine("Количество элементов, кратных 4 и не больше {a}: " + count);
    }
    // Задача 6
    static void bebe6()
    {
        double [] P = new double[5];
        Random rnd = new Random();
        for (int i = 0; i < P.Length; i++)
        {
            P[i] = i + 1;
            P[i] = rnd.Next(-50, 50);
        }
        double sum = 0;
        for (int i = 0; i < P.Length; i++)
        {
            sum += P[i];
        }
        if (sum == 0)
        {
            Console.WriteLine("Сумма элементов равна 0. Деление невозможно.");
            return;
        }
        for (int i = 0; i < P.Length; i++)
        {
            P[i] = P[i] / sum; 
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 6");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", P)}]");
        Console.Write("Ответ: ");
        for (int i = 0; i < P.Length; i++)
        {
            Console.Write(P[i].ToString("F3") + " ");
        }
        Console.WriteLine();
    }
    // Задача 7
    static void bebe7()
    {
        double[] S = new double [20];
        double sum = 0;
        double average = 0;
        Random rnd = new Random();
        for (int i = 0; i < S.Length; i++)
        {
            S[i] = i + 1;
            S[i] = rnd.Next(-50, 50);
        } 
        for (int i = 0; i < S.Length; i++)
        {
            sum += S[i];
        }
            average = (double)sum / S.Length;
        for (int i = 0; i < S.Length; i++)
        {
            S[i] = S[i] - average;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 7");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", S)}]");
        for (int i = 0; i < S.Length; i++)
        {
            Console.Write(S[i].ToString("F1") + " ");
        }
        Console.WriteLine();
    }
    // Задача 8
    static void bebe8()
    {
        int[] D = new int[20];
        int CountPositive = 0;
        int CountNegative = 0;
        Random rnd = new Random();
        for (int i = 0; i < D.Length; i++)
        {
            D[i] = i + 1;
            D[i] = rnd.Next(-50, 50);
            if (D[i] > 0)
            {
                {
                    CountPositive++;
                }
            }
            if (D[i] < 0)
            {
                {
                    CountNegative++;
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 8");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", D)}]");
        Console.WriteLine("Количество положительных: " + CountPositive);
        Console.WriteLine("количество отрицательных: " + CountNegative);
    }
    // Задача 9
    static void bebe9()
    {
        int[] f = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < f.Length; i++)
        {
            f[i] = i + 1;
            f[i] = rnd.Next(1, 101);
        } 
        double avg = f.Average();
        int closestIndex = 0;
        double minDiff = Math.Abs(f[0] - avg);
        for (int i = 1; i < f.Length; i++)
        {
            double diff = Math.Abs(f[i] - avg);
            if (diff < minDiff)
            {
                minDiff = diff;
                closestIndex = i;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 9:");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", f)}]");
        Console.WriteLine("Среднее значение: " + avg);
        Console.WriteLine("Индекс элемента, наиболее близкого к среднему: " + closestIndex);
    }
    // Задача 10
    static void bebe10()
    {
        int[] RAAA = new int[10];
        int sum = 0;
        int countEven = 0;
        int product = 1;
        Random rnd = new Random();
        for (int i = 0; i < RAAA.Length; i++)
        {
            RAAA[i] = i + 1;
            RAAA[i] = rnd.Next(-50, 50);
        }
        for (int i = 0; i < RAAA.Length; i++)
        {
            sum += RAAA[i];
        }
        for (int i = 0; i < RAAA.Length; i++)
        if (sum > 10)
        {
            if (RAAA[i] % 2 == 0)
            {
                    countEven++;
            }
        }
        else
        {
            if (RAAA[i] % 2 != 0)
            {
                    product *= RAAA[i];
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 10:");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", RAAA)}]");
        if (sum > 10)
            {
                Console.WriteLine("Количество четных: " + countEven);
            }
        else
        {
            Console.WriteLine("Произведение нечетных: " + product);
        }
    }
    // Задача 11
    static void bebe11()
    {
        int[] RAAA = new int[10];
        int sum = 0;
        int countNegative = 0;
        int product = 1;
        Random rnd = new Random();
        for (int i = 0; i < RAAA.Length; i++)
        {
            RAAA[i] = i + 1;
            RAAA[i] = rnd.Next(-50, 50);
        }
        for (int i = 0; i < RAAA.Length; i++)
        {
            product *= RAAA[i];
        }
        for (int i = 0; i < RAAA.Length; i++)
            if (product > 100)
            {
                if (RAAA[i] > 0)
                {
                    sum += RAAA[i];                                  // Я не буду переименовывать все RAAA на что-то другое...пусть так будет
                }
            }
            else
            {
                if (RAAA[i] < 0)
                {
                    countNegative++;
                }
            }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 11:");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", RAAA)}]");
        if (product > 100)
        {
            Console.WriteLine("Cумма положительных: " + sum);
        }
        else
        {
            Console.WriteLine("Количество отрицательных: " + countNegative);
        }
    }
    // Задача 12
    static void bebe12()
    {
        int[] RAAA = new int[10];
        int countNegative = 0;
        int product = 1;
        Random rnd = new Random();
        for (int i = 0; i < RAAA.Length; i++)
        {
            RAAA[i] = i + 1;
            RAAA[i] = rnd.Next(-50, 50);
        }
        for (int i = 0; i < RAAA.Length; i++)
        {
            
        }
        for (int i = 0; i < RAAA.Length; i++)
            if (product > 200)
            {
                if (RAAA[i] > 0)
                {
                    product *= RAAA[i];                                              // Тут тоже
                }
            }
            else
            {
                if (RAAA[i] < 0)
                {
                    countNegative++;
                }
            }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 12:");
        Console.ResetColor();
        Console.WriteLine($"Массив: [{string.Join(", ", RAAA)}]");
        if (product > 200)
        {
            Console.WriteLine("Произведение положительных: " + product);
        }
        else
        {
            Console.WriteLine("Количество отрицательных: " + countNegative);
        }
    }
    // Задача 13
    static void bebe13()
    {
        int[,] a = new int[10, 10];
        int n = 8;
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                a[i, j] = i + 1;
                a[i, j] = rnd.Next(-50, 50);
               
            }
        }
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i + j == n)
                {
                    sum += a[i, j];
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 13:");
        Console.ResetColor();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{a[i, j],4}");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Сумма элементов, у которых сумма индексов равна {n}: {sum}");
    }
    // Задача 14
    static void bebe14()
    {
        int[,] a = new int[5, 5];
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                a[i, j] = i + 1;
                a[i, j] = rnd.Next(-50, 50);
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вариант 14:");
        Console.ResetColor();
        Console.WriteLine("Массив: ");
        for (int i =0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{a[i, j],4}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Минимальные элементы в каждой строке:");
        for (int i = 0; i < 5; i++)
        {
            int minInRow = a[i, 0];
            for (int j = 1; j < 5; j++)
            {
                if (a[i, j] < minInRow)
                {
                    minInRow = a[i, j];
                }
            }
            Console.WriteLine($"Строка {i + 1}: {minInRow}");
        }
        Console.WriteLine("Максимальные элементы в каждом столбце:");
        for (int j = 0; j < 5; j++)
        {
            int maxInCol = a[0, j];
            for (int i = 1; i < 5; i++)
            {
                if (a[i, j] > maxInCol)
                {
                    maxInCol = a[i, j];
                }
            }
            Console.WriteLine($"Столбец {j + 1}: {maxInCol}");
        } 
    }
} // Вот эта строка короче от Program