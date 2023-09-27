using System;

class FixedStringArray
{
    private string[] Array;

    // Конструктор для создания массива заданной длины
    public FixedStringArray(int length)
    {
        if (length <= 0)
        {
            throw new ArgumentException("Длина массива должна быть положительным числом.");
        }

        Array = new string[length];
    }

    // Индексатор для доступа к элементам массива по индексу
    public string this[int index]
    {
        get
        {
            //проверка если получаемый индекс вышел запределы массива
            //если да то вывод ошибка
            if (index < 0 || index >= Array.Length)
            {
                Console.WriteLine("Индекс находится вне диапазона допустимых значений.");
                return null;
            }
            //нет, вывод действий
            return Array[index];
        }
        set
        {
            if (index < 0 || index >= Array.Length)
            {
                Console.WriteLine("Индекс находится вне диапазона допустимых значений.");
            }
            else
            {
                Array[index] = value;
            }
        }
    }

    // Метод для выполнения операции поэлементного сцепления двух массивов
    public static FixedStringArray Concatenate(FixedStringArray array1, FixedStringArray array2)
    {
        if (array1.Length != array2.Length)
        {
            Console.WriteLine("Длины массивов должны совпадать для выполнения операции сцепления.");
            return null;
        }

        FixedStringArray resultArray = new FixedStringArray(array1.Length);
        for (int i = 0; i < array1.Length; i++)
        {
            resultArray[i] = array1[i] + array2[i];
        }
        return resultArray;
    }

    // Метод для выполнения операции слияния двух массивов с исключением повторяющихся элементов
    public static FixedStringArray Merge(FixedStringArray array1, FixedStringArray array2)
    {
        if (array1.Length != array2.Length)
        {
            Console.WriteLine("Длины массивов должны совпадать для выполнения операции слияния.");
            return null;
        }

        FixedStringArray resultsArray = new FixedStringArray(array1.Length);
        for (int i = 0; i < array1.Length; i++)
        {
            resultsArray[i] = array1[i] != array2[i] ? array1[i] + array2[i] : array1[i];
        }
        return resultsArray;
    }

    // Метод для вывода элемента массива по заданному индексу
    public void PrintElement(int index)
    {
        Console.WriteLine($"Элемент с индексом {index}: {this[index]}");
    }

    // Метод для вывода всего массива
    public void PrintArray()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Console.WriteLine($"{i}: {Array[i]}");
        }
    }

    // Свойство для получения длины массива
    public int Length => Array.Length;
}

class Program
{
    static void Main()
    {
        // Ввод длины 1-го массива
        Console.Write("Введите длину первого массива:");
        int length1 = int.Parse(Console.ReadLine());
        // Создание массива 1
        FixedStringArray array1 = new FixedStringArray(length1);
        // Заполнение массива 1
        Console.WriteLine("Введите элементы для массива 1:");
        for (int i = 0; i < length1; i++)
        {
            Console.Write($"Элемент {i}: ");
            array1[i] = Console.ReadLine();
        }

        // Ввод длины 2-го массива
        Console.Write("Введите длину второго массива:");
        int length2 = int.Parse(Console.ReadLine());
        // Создание массива 2
        FixedStringArray array2 = new FixedStringArray(length2);
        // Заполнение массива 2
        Console.WriteLine("Введите элементы для массива 2:");
        for (int i = 0; i < length2; i++)
        {
            Console.Write($"Элемент {i}: ");
            array2[i] = Console.ReadLine();
        }

        // Выполнение операции поэлементного сцепления и вывод результата
        FixedStringArray concatenatedArray = FixedStringArray.Concatenate(array1, array2);
        //если массивы одинаковой длины
        if (concatenatedArray != null)
        {
            Console.WriteLine("Cлияние массивов:");
            concatenatedArray.PrintArray();
        }

        // Выполнение операции слияния с исключением повторяющихся элементов и вывод результата
        FixedStringArray mergedArray = FixedStringArray.Merge(array1, array2);
        //если массивы одинаковой длины
        if (mergedArray != null)
        {
            Console.WriteLine("Слияние массивов с исключением повторений:");
            mergedArray.PrintArray();
        }

        // Ввод индекса с проверкой на корректность
        Console.Write("Введите индекс элемента для вывода из массива 1:");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= array1.Length)
        {
            Console.WriteLine("Индекс вышел за пределы массива.");
        }
        else
        {
            array1.PrintElement(index);
        }

        Console.ReadLine();
    }
}
