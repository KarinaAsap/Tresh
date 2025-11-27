using System;
using System.Collections.Generic;

public class Solution
{
    // Точка входа в локальной программе
    static void Main(string[] args)
    {
        string s = "}{()[)"; //здесь инициализируется строка
        bool result = IsValid(s); //вызываем наш алгоритм
        Console.WriteLine(result); //выводим true/false
        Console.ReadLine(); //чтобы окно не закрывалось сразу
    }
    // Здесь живёт решение задачи (то, что на LeetCode в классе Solution). В консольном проекте класс может называться Program, а метод Main — обязательно static и вне других методов. Метод IsValid тоже сделан static, чтобы его можно было вызвать из Main без создания объекта.
    public static bool IsValid(string s) //сюда приходит строка из Main
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) //перебираем символы строки s
        {
            if (c == '(' || c == '[' || c == '{') //Проверяем: это одна из ОТКРЫВАЮЩИХ скобок?
            {
                stack.Push(c); //Да → кладём её в стек
            }
            else //Иначе: считаем, что это ЗАКРЫВАЮЩАЯ скобка
            {
                if (stack.Count == 0) //Если стек пуст — закрывать нечего → ошибка
                    return false;
                char open = stack.Pop(); //Достаём последнюю открытую скобку
                bool ok =
                    (open == '(' && c == ')') || //Сравниваем тип открывающей и закрывающей
                    (open == '[' && c == ']') ||
                    (open == '{' && c == '}');
                if (!ok) //Если типы не совпали → строка невалидна
                    return false;
            }
        }
        return stack.Count == 0; //В конце все скобки должны быть закрыты
    }
}
