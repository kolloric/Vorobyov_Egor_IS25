class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n=== МЕНЮ СОРТИРОВОК ===");
            Console.WriteLine("1. Сортировка пузырьком");
            Console.WriteLine("2. Сортировка вставками");
            Console.WriteLine("3. Сортировка слиянием");
            Console.WriteLine("4. Сортировка выбором");
            Console.WriteLine("5. Быстрая сортировка");
            Console.WriteLine("6. Шейкерная сортировка");
            Console.WriteLine("0. Выход");
            Console.Write("\nВыберите метод сортировки: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            Console.Write("Введите размер массива: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Ошибка: АААААААААА");
                continue;
            }

            int[] array = GenerateRandomArray(size);

            Console.WriteLine("\nИсходный массив:");
            PrintArray(array);

            int[] sortedArray = (int[])array.Clone();

            switch (choice)
            {
                case "1":
                    BubbleSort(sortedArray);
                    Console.WriteLine("\nСортировка пузырьком завершена.");
                    break;
                case "2":
                    InsertionSort(sortedArray);
                    Console.WriteLine("\nСортировка вставками завершена.");
                    break;
                case "3":
                    MergeSort(sortedArray, 0, sortedArray.Length - 1);
                    Console.WriteLine("\nСортировка слиянием завершена.");
                    break;
                case "4":
                    SelectionSort(sortedArray);
                    Console.WriteLine("\nСортировка выбором завершена.");
                    break;
                case "5":
                    QuickSort(sortedArray, 0, sortedArray.Length - 1);
                    Console.WriteLine("\nБыстрая сортировка завершена.");
                    break;
                case "6":
                    ShakerSort(sortedArray);
                    Console.WriteLine("\nШейкерная сортировка завершена.");
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    continue;
            }

            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(sortedArray);
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 100);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }

    // 1. Сортировка пузырьком
    // Алгоритм многократно проходит по массиву, сравнивает соседние элементы
    // и меняет их местами, если они в неправильном порядке.
    // Большие элементы "всплывают" в конец массива как пузырьки.
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Обмен элементов
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // 2. Сортировка вставками
    // Алгоритм строит отсортированную часть массива слева направо.
    // Каждый новый элемент вставляется на правильную позицию в уже отсортированной части.
    static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            // Сдвигаем элементы, которые больше key, на одну позицию вправо
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    // 3. Сортировка слиянием
    // Алгоритм разделяет массив пополам, рекурсивно сортирует каждую половину,
    // затем сливает две отсортированные половины в один отсортированный массив.
    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            
            // Рекурсивно сортируем первую и вторую половины
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            // Сливаем отсортированные половины
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Копируем данные во временные массивы
        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, middle + 1, rightArray, 0, n2);

        // Сливаем временные массивы обратно в основной
        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Копируем оставшиеся элементы
        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    // 4. Сортировка выбором
    // Алгоритм находит минимальный элемент в неотсортированной части массива
    // и меняет его местами с первым элементом неотсортированной части.
    static void SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            // Находим индекс минимального элемента
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Меняем местами найденный минимальный элемент с первым неотсортированным
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    // 5. Быстрая сортировка (QuickSort)
    // Алгоритм выбирает опорный элемент (pivot), разделяет массив на две части:
    // элементы меньше pivot и элементы больше pivot, затем рекурсивно сортирует обе части.
    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            // Рекурсивно сортируем элементы до и после pivot
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // Выбираем последний элемент как pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                // Обмен элементов
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Ставим pivot на правильную позицию
        int temp2 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp2;

        return i + 1;
    }

    // 6. Шейкерная сортировка (Cocktail Shaker Sort)
    // Улучшенная версия сортировки пузырьком. Проходит по массиву в обоих направлениях,
    // что позволяет быстрее перемещать элементы на свои позиции.
    static void ShakerSort(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        bool swapped = true;

        while (swapped)
        {
            swapped = false;

            // Проход слева направо
            for (int i = left; i < right; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
            right--;

            // Проход справа налево
            for (int i = right; i > left; i--)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    swapped = true;
                }
            }
            left++;
        }
    }
}