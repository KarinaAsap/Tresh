using System;
public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        for (int i = 0; i < haystack.Length; i++) //перебираем все элементы массива
        {
            if (haystack[i] != null && haystack[i].ToString() == "needle")
            {
                return $"found the needle at position {i}";
            }
        }
        // по условию всегда есть одна "needle", но на всякий случай:
        return "needle not found";
    }
}
public class Program
{
    // Точка входа в консольное приложение
    static void Main(string[] args)
    {
        object[] haystack = { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };
        string result = Kata.FindNeedle(haystack);

        Console.WriteLine(result);   // увидишь: found the needle at position 5
        Console.ReadLine();         // чтобы окно не закрылось сразу
    }
}