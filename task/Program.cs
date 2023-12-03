using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива строк: ");
        int size = int.Parse(Console.ReadLine());

        string[] originalArray = new string[size];

        // Заполнение массива строк
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            originalArray[i] = Console.ReadLine();
        }

        // Формирование нового массива из строк, длина которых <= 3 символам
        string[] newArray = FilterStrings(originalArray);

        // Вывод нового массива
        Console.WriteLine("\nНовый массив из строк, длина которых <= 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }

       // Console.ReadLine();
    }

    static string[] FilterStrings(string[] originalArray)
    {
        int newSize = 0;

        // Определение размера нового массива
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newSize++;
            }
        }

        // Создание нового массива
        string[] newArray = new string[newSize];
        int index = 0;

        // Заполнение нового массива
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[index] = originalArray[i];
                index++;
            }
        }

        return newArray;
    }
}
