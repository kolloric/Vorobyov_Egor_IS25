using System;

namespace AllTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== МЕНЮ ЗАДАЧ ==========");
                Console.WriteLine(" 1. Класс Phone");
                Console.WriteLine(" 2. Класс Person");
                Console.WriteLine(" 3. Класс Матрица");
                Console.WriteLine(" 4. Класс Reader (библиотека)");
                Console.WriteLine(" 5. Класс Tiles (кафель)");
                Console.WriteLine(" 6. Класс Children");
                Console.WriteLine(" 7. Класс Куб");
                Console.WriteLine(" 8. Класс Счётчик");
                Console.WriteLine(" 9. Класс Время");
                Console.WriteLine("10. Класс Треугольник");
                Console.WriteLine("11. Класс Студент");
                Console.WriteLine("12. Класс Компьютерное железо");
                Console.WriteLine("13. Класс Бегун");
                Console.WriteLine("14. Класс Пирамида");
                Console.WriteLine(" 0. Выход");
                Console.WriteLine("================================");
                Console.Write("Выберите номер задачи: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1": RunTask1(); break;
                    case "2": RunTask2(); break;
                    case "3": RunTask3(); break;
                    case "4": RunTask4(); break;
                    case "5": RunTask5(); break;
                    case "6": RunTask6(); break;
                    case "7": RunTask7(); break;
                    case "8": RunTask8(); break;
                    case "9": RunTask9(); break;
                    case "10": RunTask10(); break;
                    case "11": RunTask11(); break;
                    case "12": RunTask12(); break;
                    case "13": RunTask13(); break;
                    case "14": RunTask14(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный ввод!"); break;
                }

                Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }
        }

        // ВАРИАНТ 1 ААААААААААААААА
        static void RunTask1()
        {
            Console.WriteLine("--- ВАРИАНТ 1: Класс Phone ---\n");

            Phone phone1 = new Phone("+7-900-111-22-33", "iPhone 13", 174.5);
            Phone phone2 = new Phone("+7-900-444-55-66", "Samsung Galaxy S21", 171.0);
            Phone phone3 = new Phone("+7-900-777-88-99", "Xiaomi Mi 11", 196.2);

            Console.WriteLine("Данные телефонов:");
            Console.WriteLine($"  1: {phone1.model}, {phone1.number}, {phone1.weight} г");
            Console.WriteLine($"  2: {phone2.model}, {phone2.number}, {phone2.weight} г");
            Console.WriteLine($"  3: {phone3.model}, {phone3.number}, {phone3.weight} г\n");

            phone1.receiveCall("Иван");
            Console.WriteLine($"  Номер: {phone1.getNumber()}");
            phone2.receiveCall("Мария");
            Console.WriteLine($"  Номер: {phone2.getNumber()}");
            phone3.receiveCall("Алексей");
            Console.WriteLine($"  Номер: {phone3.getNumber()}\n");

            Console.WriteLine("Отправка сообщений:");
            phone1.sendMessage("+7-900-444-55-66", "+7-900-777-88-99");
        }

        // ВАРИАНТ 2 
        static void RunTask2()
        {
            Console.WriteLine("--- ВАРИАНТ 2: Класс Person ---\n");

            Person person1 = new Person();
            person1.fullName = "Иван Иванов";
            person1.age = 25;

            Person person2 = new Person("Пётр Петров", 30);

            Console.WriteLine($"Person 1: {person1.fullName}, {person1.age} лет");
            person1.move();
            person1.talk();

            Console.WriteLine($"\nPerson 2: {person2.fullName}, {person2.age} лет");
            person2.move();
            person2.talk();
        }

        // ВАРИАНТ 3 
        static void RunTask3()
        {
            Console.WriteLine("--- ВАРИАНТ 3: Класс Матрица ---\n");

            double[,] data1 = { { 1, 2 }, { 3, 4 } };
            double[,] data2 = { { 5, 6 }, { 7, 8 } };

            Matrix m1 = new Matrix(data1);
            Matrix m2 = new Matrix(data2);

            Console.WriteLine("Матрица 1:");
            m1.Print();
            Console.WriteLine("Матрица 2:");
            m2.Print();

            Console.WriteLine("Сложение (M1 + M2):");
            Matrix sum = m1.Add(m2);
            sum.Print();

            Console.WriteLine("Умножение M1 на число 3:");
            Matrix scaled = m1.Multiply(3);
            scaled.Print();

            Console.WriteLine("Умножение матриц (M1 * M2):");
            Matrix product = m1.MultiplyMatrix(m2);
            product.Print();
        }

        // ВАРИАНТ 4 
        static void RunTask4()
        {
            Console.WriteLine("--- ВАРИАНТ 4: Класс Reader ---\n");

            Reader[] readers = new Reader[]
            {
                new Reader("Петров В. В.", "1001", "ФИТ", "15.03.2000", "+7-900-111-11-11"),
                new Reader("Сидорова А. И.", "1002", "ФЭУ", "22.07.2001", "+7-900-222-22-22"),
                new Reader("Козлов Д. М.", "1003", "ФИТ", "10.11.1999", "+7-900-333-33-33")
            };

            readers[0].takeBook("Энциклопедия");
            readers[0].takeBook("Война и мир");
            readers[1].takeBook("Мастер и Маргарита");
            readers[2].returnBook("Физика. Том 1");
            readers[0].returnBook("Энциклопедия");
        }

        // ВАРИАНТ 5 
        static void RunTask5()
        {
            Console.WriteLine("--- ВАРИАНТ 5: Класс Tiles ---\n");

            Tiles tile1 = new Tiles();
            tile1.brand = "Kerama Marazzi";
            tile1.size_h = 30;
            tile1.size_w = 60;
            tile1.price = 850.50;

            Tiles tile2 = new Tiles();
            tile2.brand = "Cersanit";
            tile2.size_h = 25;
            tile2.size_w = 40;
            tile2.price = 420.00;

            Console.WriteLine("Кафель 1:");
            tile1.getData();
            Console.WriteLine("\nКафель 2:");
            tile2.getData();
        }

        // ВАРИАНТ 6 
        static void RunTask6()
        {
            Console.WriteLine("--- ВАРИАНТ 6: Класс Children ---\n");

            Children child1 = new Children();
            child1.SetData("Алиса", "Смирнова", 7);

            Children child2 = new Children();
            child2.SetData("Борис", "Кузнецов", 10);

            Console.WriteLine("Ребёнок 1:");
            child1.Display();
            Console.WriteLine("\nРебёнок 2:");
            child2.Display();
        }

        // ВАРИАНТ 7 
        static void RunTask7()
        {
            Console.WriteLine("--- ВАРИАНТ 7: Класс Куб ---\n");

            Cube cube = new Cube(5);

            Console.WriteLine($"Сторона куба: {cube.Side}");
            Console.WriteLine($"Площадь грани: {cube.FaceArea}");
            Console.WriteLine($"Площадь поверхности: {cube.SurfaceArea}");
            Console.WriteLine($"Объём: {cube.Volume}");
        }

        // ВАРИАНТ 8 
        static void RunTask8()
        {
            Console.WriteLine("--- ВАРИАНТ 8: Класс Счётчик ---\n");

            Counter c1 = new Counter();
            Console.WriteLine($"Счётчик по умолчанию: {c1.CurrentValue} (диапазон {c1.MinValue}..{c1.MaxValue})");

            Counter c2 = new Counter(5, 0, 10


);
            Console.WriteLine($"Счётчик (5, 0..10): {c2.CurrentValue}");

            c2.Increment();
            c2.Increment();
            Console.WriteLine($"После 2 увеличений: {c2.CurrentValue}");

            c2.Decrement();
            Console.WriteLine($"После 1 уменьшения: {c2.CurrentValue}");

            // Демонстрация границы
            Counter c3 = new Counter(9, 0, 10);
            c3.Increment(); // 10
            Console.WriteLine($"Довели до максимума: {c3.CurrentValue}");
            c3.Increment(); // Попытка выйти за границу
            Console.WriteLine($"Попытка ещё увеличить: {c3.CurrentValue} (не изменился)");
        }

        // ВАРИАНТ 9 
        static void RunTask9()
        {
            Console.WriteLine("--- ВАРИАНТ 9: Класс Время ---\n");

            Time t1 = new Time(14, 30, 0);
            Console.WriteLine($"Начальное время: {t1}");

            t1.AddHours(3);
            Console.WriteLine($"После +3 часа: {t1}");

            t1.AddMinutes(45);
            Console.WriteLine($"После +45 минут: {t1}");

            t1.AddSeconds(90);
            Console.WriteLine($"После +90 секунд: {t1}");

            // Демонстрация исключения
            Console.WriteLine("\nПопытка установить недопустимое значение:");
            try
            {
                t1.Hour = 25;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }

        //  ВАРИАНТ 10 
        static void RunTask10()
        {
            Console.WriteLine("--- ВАРИАНТ 10: Класс Треугольник ---\n");

            Triangle tri = new Triangle(0, 0, 6, 0, 3, 4);

            Console.WriteLine($"Вершины: A({tri.X1},{tri.Y1}), B({tri.X2},{tri.Y2}), C({tri.X3},{tri.Y3})");
            Console.WriteLine($"Стороны: a={tri.SideA:F2}, b={tri.SideB:F2}, c={tri.SideC:F2}");
            Console.WriteLine($"Периметр: {tri.Perimeter:F2}");
            Console.WriteLine($"Площадь: {tri.Area:F2}");
            Console.WriteLine($"Точка пересечения медиан: ({tri.CentroidX:F2}, {tri.CentroidY:F2})");
        }

        // ВАРИАНТ 11 
        static void RunTask11()
        {
            Console.WriteLine("--- ВАРИАНТ 11: Класс Студент ---\n");

            Student[] students = new Student[]
            {
                new Student("Иванов", "Иван", "Иванович", "ИТ-21", "ФИТ", 2, "+7-900-111-11-11"),
                new Student("Петров", "Пётр", "Петрович", "ИТ-21", "ФИТ", 2, "+7-900-222-22-22"),
                new Student("Сидоров", "Сидор", "Сидорович", "ЭК-31", "ФЭУ", 3, "+7-900-333-33-33"),
                new Student("Козлова", "Анна", "Дмитриевна", "ИТ-21", "ФИТ", 2, "+7-900-444-44-44")
            };

            Console.WriteLine("Все студенты группы ИТ-21 (ФИТ):");
            Student.PrintGroup(students, "ФИТ", "ИТ-21");
        }

        // ВАРИАНТ 12 
        static void RunTask12()
        {
            Console.WriteLine("--- ВАРИАНТ 12: Класс Компьютерное железо ---\n");

            ComputerHardware[] parts = new ComputerHardware[]
            {
                new ComputerHardware("Видеокарта", "NVIDIA", "RTX 4090", 9800, 150000),
                new ComputerHardware("Видеокарта", "NVIDIA", "RTX 4060", 6500, 35000),
                new ComputerHardware("Процессор", "AMD", "Ryzen 9 7950X", 9500, 55000),
                new ComputerHardware("Процессор", "Intel", "Core i5-13400", 6000, 20000),
                new ComputerHardware("ОЗУ", "Kingston", "Fury 32GB", 4000, 8000),
                new ComputerHardware("Блок питания", "Corsair", "RM1000x", 5000, 15000)
            };

            Console.WriteLine("Все компоненты:");
            foreach (var p in parts)
                Console.WriteLine($"  {p.Type} {p.Brand} {p.Model} | Мощность: {p.Power} | Цена: {p.Price} руб.");

            Console.WriteLine("\nСамый мощный компонент:");
            ComputerHardware.PrintMostPowerful(parts);

            Console.WriteLine("\nСамый дешёвый компонент:");
            ComputerHardware.PrintCheapest(parts);
        }

        // ВАРИАНТ 13 
        static void RunTask13()
        {
            Console.WriteLine("--- ВАРИАНТ 13: Класс Бегун ---\n");

            Runner runner1 = new Runner("Алексей", 180, 75, 10000, 140, 600);
            Runner runner2 = new Runner("Мария", 165, 55, 8000, 130, 450);

            Console.WriteLine($"Бегун: {runner1.Name}, рост {runner1.Height} см, шагов {runner1.Steps}");
            Console.WriteLine($"  Пробежал: {runner1.GetDistanceKm():F2} км");
            Console.WriteLine($"  Калорий: {runner1.Calories}");

            Console.WriteLine($"\nБегун: {runner2.Name}, рост {runner2.Height} см, шагов {runner2.Steps}");
            Console.WriteLine($"  Пробежала: {runner2.GetDistanceKm():F2} км");
            Console.WriteLine($"  Калорий: {runner2.Calories}");
        }

        // ВАРИАНТ 14 
        static void RunTask14()
        {
            Console.WriteLine("--- ВАРИАНТ 14: Класс Пирамида ---\n");

            Pyramid pyr = new Pyramid(6, 10);

            Console.WriteLine($"Сторона основания: {pyr.BaseSide}");
            Console.WriteLine($"Высота: {pyr.Height}");
            Console.WriteLine($"Площадь основания: {pyr.BaseArea:F2}");
            Console.WriteLine($"Площадь боковой поверхности: {pyr.LateralArea:F2}");
            Console.WriteLine($"Полная площадь поверхности: {pyr.SurfaceArea:F2}");
            Console.WriteLine($"Объём: {pyr.Volume:F2}");
        }
    }
    // Классы:
    // ВАРИАНТ 1
    class Phone
    {
        public string number;
        public string model;
        public double weight;

        public Phone(string number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public string getNumber()
        {
            return number;
        }

        public void sendMessage(params string[] numbers)
        {
            Console.WriteLine("Отправка сообщения на номера:");
            foreach (string num in numbers)
                Console.WriteLine($"  {num}");
        }
    }

    // ВАРИАНТ 2
    class Person
    {
        public string fullName;
        public int age;

        public Person()
        {
            fullName = "Неизвестный";
            age = 0;
        }

        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }

        public void move()
        {
            Console.WriteLine($"{fullName} двигается");
        }

        public void talk()
        {
            Console.WriteLine($"{fullName} говорит");
        }
    }

    // ВАРИАНТ 3
    class Matrix
    {
        private double[,] data;
        public int Rows { get; }
        public int Cols { get; }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            data = new double[rows, cols];
        }

        public Matrix(double[,] data)
        {
            Rows = data.GetLength(0);
            Cols = data.GetLength(1);
            this.data = (double[,])data.Clone();
        }

        public double this[int i, int j]
        {
            get => data[i, j];
            set => data[i, j] = value;
        }

        public Matrix Add(Matrix other)
        {
            if (Rows != other.Rows || Cols != other.Cols)
                throw new InvalidOperationException("Размеры матриц не совпадают для сложения.");

            Matrix result = new Matrix(Rows, Cols);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    result[i, j] = data[i, j] + other[i, j];
            return result;
        }

        public Matrix Multiply(double scalar)
        {
            Matrix result = new Matrix(Rows, Cols);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    result[i, j] = data[i, j] * scalar;
            return result;
        }

        public Matrix MultiplyMatrix(Matrix other)
        {
            if (Cols != other.Rows)
                throw new InvalidOperationException("Несовместимые размеры для умножения матриц.");

            Matrix result = new Matrix(Rows, other.Cols);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < other.Cols; j++)
                    for (int k = 0; k < Cols; k++)
                        result[i, j] += data[i, k] * other[k, j];
            return result;
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    Console.Write($"{data[i, j],8:F1}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    // ВАРИАНТ 4
    class Reader
    {
        public string fullName;
        public string cardNumber;
        public string faculty;
        public string birthDate;
        public string phone;

        public Reader(string fullName, string cardNumber, string faculty, string birthDate, string phone)
        {
            this.fullName = fullName;
            this.cardNumber = cardNumber;
            this.faculty = faculty;
            this.birthDate = birthDate;
            this.phone = phone;
        }

        public void takeBook(string bookName)
        {
            Console.WriteLine($"{fullName} взял книгу: {bookName}");
        }

        public void returnBook(string bookName)
        {
            Console.WriteLine($"{fullName} вернул книгу: {bookName}");
        }
    }

    // ВАРИАНТ 5
    class Tiles
    {
        public string brand;
        public double size_h;
        public double size_w;
        public double price;

        public void getData()
        {
            Console.WriteLine($"  Бренд: {brand}");
            Console.WriteLine($"  Размер: {size_h} x {size_w} см");
            Console.WriteLine($"  Цена: {price} руб.");
        }
    }

    // ВАРИАНТ 6
    class Children
    {
        private string firstName;
        private string lastName;
        private int age;

        public void SetData(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void InputData()
        {
            Console.Write("Введите имя ребёнка: ");
            firstName = Console.ReadLine();
            Console.Write("Введите фамилию ребёнка: ");
            lastName = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"  Имя: {firstName}");
            Console.WriteLine($"  Фамилия: {lastName}");
            Console.WriteLine($"  Возраст: {age}");
        }
    }

    // ВАРИАНТ 7
    class Cube
    {
        private double side;

        public double Side
        {
            get => side;
            set


            {
                if (value <= 0) throw new ArgumentException("Сторона должна быть > 0");
                side = value;
            }
        }

        public double FaceArea => side * side;
        public double SurfaceArea => 6 * FaceArea;
        public double Volume => side * side * side;

        public Cube(double side)
        {
            Side = side;
        }
    }

    // ВАРИАНТ 8
    class Counter
    {
        private int currentValue;
        public int MinValue { get; }
        public int MaxValue { get; }

        public int CurrentValue => currentValue;

        // Конструктор по умолчанию: 0 в диапазоне 0..100
        public Counter()
        {
            MinValue = 0;
            MaxValue = 100;
            currentValue = 0;
        }

        // Конструктор с параметрами
        public Counter(int startValue, int min, int max)
        {
            if (min > max) throw new ArgumentException("min не может быть больше max");
            MinValue = min;
            MaxValue = max;
            currentValue = Math.Max(min, Math.Min(max, startValue));
        }

        public void Increment()
        {
            if (currentValue < MaxValue)
                currentValue++;
            else
                Console.WriteLine("  [Достигнут максимум, увеличение невозможно]");
        }

        public void Decrement()
        {
            if (currentValue > MinValue)
                currentValue--;
            else
                Console.WriteLine("  [Достигнут минимум, уменьшение невозможно]");
        }
    }

    // ВАРИАНТ 9
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get => hour;
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentOutOfRangeException(nameof(value), "Часы должны быть в диапазоне 0-23");
                hour = value;
            }
        }

        public int Minute
        {
            get => minute;
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentOutOfRangeException(nameof(value), "Минуты должны быть в диапазоне 0-59");
                minute = value;
            }
        }

        public int Second
        {
            get => second;
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentOutOfRangeException(nameof(value), "Секунды должны быть в диапазоне 0-59");
                second = value;
            }
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public void AddHours(int h)
        {
            int total = hour + h;
            hour = ((total % 24) + 24) % 24; // Корректная работа с отрицательными
        }

        public void AddMinutes(int m)
        {
            int totalMinutes = minute + m;
            AddHours(totalMinutes / 60);
            minute = ((totalMinutes % 60) + 60) % 60;
        }

        public void AddSeconds(int s)
        {
            int totalSeconds = second + s;
            AddMinutes(totalSeconds / 60);
            second = ((totalSeconds % 60) + 60) % 60;
        }

        public override string ToString()
        {
            return $"{hour:D2}:{minute:D2}:{second:D2}";
        }
    }

    // ВАРИАНТ 10
    class Triangle
    {
        public double X1 { get; }
        public double Y1 { get; }
        public double X2 { get; }
        public double Y2 { get; }
        public double X3 { get; }
        public double Y3 { get; }

        public double SideA { get; } // BC
        public double SideB { get; } // AC
        public double SideC { get; } // AB

        public


Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1; Y1 = y1;
            X2 = x2; Y2 = y2;
            X3 = x3; Y3 = y3;

            SideA = Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3));
            SideB = Math.Sqrt((X1 - X3) * (X1 - X3) + (Y1 - Y3) * (Y1 - Y3));
            SideC = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
        }

        public double Perimeter => SideA + SideB + SideC;

        public double Area
        {
            get
            {
                double s = Perimeter / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        // Точка пересечения медиан (центроид) — среднее арифметическое координат вершин
        public double CentroidX => (X1 + X2 + X3) / 3.0;
        public double CentroidY => (Y1 + Y2 + Y3) / 3.0;
    }

    // ВАРИАНТ 11
    class Student
    {
        public string LastName;
        public string FirstName;
        public string MiddleName;
        public string GroupNumber;
        public string Faculty;
        public int Course;
        public string Phone;

        public Student(string lastName, string firstName, string middleName,
                       string groupNumber, string faculty, int course, string phone)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            GroupNumber = groupNumber;
            Faculty = faculty;
            Course = course;
            Phone = phone;
        }

        public static void PrintGroup(Student[] students, string faculty, string groupNumber)
        {
            foreach (var s in students)
            {
                if (s.Faculty == faculty && s.GroupNumber == groupNumber)
                {
                    Console.WriteLine($"  {s.LastName} {s.FirstName} {s.MiddleName} | " +
                                      $"{s.Faculty}, {s.GroupNumber} | Курс {s.Course} | {s.Phone}");
                }
            }
        }
    }

    // ВАРИАНТ 12
    class ComputerHardware
    {
        public string Type;
        public string Brand;
        public string Model;
        public int Power;
        public double Price;

        public ComputerHardware(string type, string brand, string model, int power, double price)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Power = power;
            Price = price;
        }

        public static void PrintMostPowerful(ComputerHardware[] parts)
        {
            ComputerHardware best = parts[0];
            foreach (var p in parts)
                if (p.Power > best.Power) best = p;

            Console.WriteLine($"  {best.Type} {best.Brand} {best.Model} | Мощность: {best.Power} | Цена: {best.Price} руб.");
        }

        public static void PrintCheapest(ComputerHardware[] parts)
        {
            ComputerHardware cheapest = parts[0];
            foreach (var p in parts)
                if (p.Price < cheapest.Price) cheapest = p;

            Console.WriteLine($"  {cheapest.Type} {cheapest.Brand} {cheapest.Model} | Мощность: {cheapest.Power} | Цена: {cheapest.Price} руб.");
        }
    }

    // ВАРИАНТ 13
    class Runner
    {
        public string Name;
        public double Height;     // в см
        public double Weight;     // в кг
        public int Steps;
        public int HeartRate;
        public double Calories;

        public Runner(string name, double height, double weight, int steps, int heartRate, double calories)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Steps = steps;
            HeartRate = heartRate;
            Calories = calories;
        }

        // Длина шага ≈ рост × 0.415 (средний коэффициент)
        // Расстояние = шаги × длина_шага
        public double GetDistanceKm()
        {
            double stepLengthCm = Height * 0.415;
            double distanceCm = Steps * stepLengthCm;
            return distanceCm / 100000.0; // переводим см в км
        }
    }

    // ВАРИАНТ 14
    class Pyramid
    {
        private double baseSide;
        private double height;

        public double BaseSide
        {
            get => baseSide;
            set
            {
                if (value <= 0) throw new ArgumentException("Сторона должна быть > 0");
                baseSide = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0) throw new ArgumentException("Высота должна быть > 0");
                height = value;
            }
        }

        // Площадь квадратного основания
        public double BaseArea => baseSide * baseSide;

        // Апофема (высота боковой грани)
        private double Apothem => Math.Sqrt(height * height + (baseSide / 2) * (baseSide / 2));

        // Площадь боковой поверхности (4 треугольника)
        public double LateralArea => 4 * (0.5 * baseSide * Apothem);

        // Полная площадь поверхности
        public double SurfaceArea => BaseArea + LateralArea;

        // Объём пирамиды: V = 1/3 * S_осн * h
        public double Volume => (1.0 / 3.0) * BaseArea * height;

        public Pyramid(double baseSide, double height)
        {
            BaseSide = baseSide;
            Height = height;
        }
    }
}