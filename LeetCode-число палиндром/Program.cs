using System;
class Program
{
    static void Main()
    {
        // Тестируем разные числа
        int[] testNumbers = { 121, -121, 10, 1221, 12321, 1001, 7 };//массив чисел для проверки на палиндром
        foreach (int x in testNumbers)//прогоняем в цикле для перебора элементов в коллекции
        {
            bool result = IsPalindrome(x);//вызов функции, проверка x на палиндром
            Console.WriteLine($"x = {x} → {result}");
        }
        Console.ReadKey(); // ждём нажатия клавиши
    }
    static bool IsPalindrome(int x)//объявление ФУНКЦИИ
    {
        if (x < 0 || (x > 0 && x % 10 == 0))//если х отрицательное или больше нуля, но заканчивается 0, то false
            return false;
        int reversedHalf = 0;//«правая» часть числа х, которую мы собираем с конца, но в перевёрнутом виде
        while (reversedHalf < x)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }
        return x == reversedHalf || x == reversedHalf / 10;//При нечётной длине (12321) правую половину получается на одну цифру длиннее, поэтому делим  на 10
    }
}
