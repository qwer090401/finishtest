using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строки через точку с запятой: ");
        string[] inputStrings = Console.ReadLine().Split(";");

        string[] resultStrings = FilterShortStrings(inputStrings);


        Console.WriteLine("Результат:");
        foreach (string s in resultStrings)
        {
            Console.WriteLine(s);
        }
    }

    static string[] FilterShortStrings(string[] strings)
    {
        int maxLength = 3;

        int count = 0;

        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= maxLength)
            {
                count++;
            }
        }

        string[] result = new string[count];

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
