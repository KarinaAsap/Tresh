using System;
class Program
{
    static void Main()
    {
        string[] test1 = { "flower", "flow", "flight" }; //тестовый массив строк для примера 1
        string[] test2 = { "dog", "racecar", "car" }; //тестовый массив строк для примера 2

        Console.WriteLine(LongestCommonPrefix(test1)); //Вызываем функцию и выводим результат "fl"
        Console.WriteLine(LongestCommonPrefix(test2)); // ""
        Console.ReadKey(); //Ждём нажатия клавиши, чтобы окно не закрылось сразу после вывода
    }
    static string LongestCommonPrefix(string[] strs) //Объявляем функцию LongestCommonPrefix — принимает массив строк и возвращает строку
    {
        if (strs.Length == 0) return ""; //Если массив пустой (нет строк для сравнения) — сразу возвращаем пустую строку
        string prefix = strs[0]; //Берём первую строку массива как начальный "кандидат" на префикс - нулевой элемент массива strs - flower
        for (int i = 1; i < strs.Length; i++) //Начинаем цикл со второй строки (i=1), сравниваем с первой
        {
            while (!strs[i].StartsWith(prefix)) //Пока текущая строка НЕ начинается с нашего префикса (flower) — укорачиваем его → flowe
                                                //StartsWith( ) - метод: "начинается ли эта строка с..."
            {
                prefix = prefix.Substring(0, prefix.Length - 1); //Обрезаем последний символ префикса (длина - 1) → flowe
                                                                 //Substring( ) - метод: "дай мне часть строки" с позиции 0, длина строки (6) - 1
                                                                 //Length — свойство строки, показывает количество символов
                if (string.IsNullOrEmpty(prefix)) return ""; //Если префикс стал пустым — общий префикс не найден, возвращаем "" IsNullOrEmpty( ) - метод: "пустая строка или null?"
            }
        }
        return prefix; //Если все строки прошли проверку — возвращаем найденный префикс
    }
}
