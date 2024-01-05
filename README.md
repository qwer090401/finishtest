# Фильтрация строк в массиве по длине

Программа на C#, которая фильтрует массив строк так, чтобы в результирующем массиве остались только те строки, длина которых меньше или равна 3 символам.

## Как использовать

1. Запустите программу.
2. Введите строки через точку с запятой, когда программа запросит ввод.
3. Программа выведет отфильтрованный массив строк на экран.

## Пример

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строки через точку с запятой: ");
        string[] inputStrings = Console.ReadLine().Split();

        string[] resultStrings = FilterShortStrings(inputStrings);

        Console.WriteLine("Результат:");
        foreach (string s in resultStrings)
        {
            Console.WriteLine(s);
        }
    }

    static string[] FilterShortStrings(string[] strings)
    {
        // Максимальная длина строки
        int maxLength = 3;

        int count = 0;

        // Подсчитаем количество строк, удовлетворяющих условию
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= maxLength)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] result = new string[count];

        // Заполняем новый массив подходящими строками
        int index = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= maxLength)
            {
                result[index] = strings[i];
                index++;
            }
        }

        return result;
    }
}
```