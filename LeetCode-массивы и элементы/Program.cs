using System; //Подключаем пространство имён System, чтобы использовать Console и другие базовые классы
using System.Collections.Generic;

public class Solution //Объявляем класс Solution (имя может быть любым)
{
    //Метод из LeetCode
    public static List<int[]> TwoSumAll(int[] nums, int target) // Метод, который ищет все пары с нужной суммой
    {
        {
            var result = new List<int[]>(); //Создаём список, в котором будем хранить все найденные пары индексов
            for (int i = 0; i < nums.Length - 1; i++) //Внешний цикл: перебираем индекс i от 0 до предпоследнего элемента
            {
                for (int j = i + 1; j < nums.Length; j++) //Внутренний цикл: перебираем индекс j, начинаем с i + 1, чтобы:1) не брать один и тот же элемент два раза, 2) не проверять пары в обратном порядке (i,j) и (j,i)
                {
                    if (nums[i] + nums[j] == target) //Если сумма двух элементов с индексами i и j равна целевому числу
                    {
                        result.Add(new int[] { i, j }); //Добавляем пару индексов как новый массив из двух элементов
                    }
                }
            }
            return result; //Возвращаем список всех найденных пар
        }
    }
        //Дан массив целых чисел nums и целочисленное значение target. Верните индексы двух чисел так, чтобы их сумма равнялась target, но нельзя складывать один и тот же элемент массива, чтобы получить 9!
        //Метод Main
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 8, 2, 7, 4, 5, 4 }; //Создаём и инициализируем массив чисел
            int target = 9;
            var pairs = TwoSumAll(nums, target); //Вызываем метод, который найдёт ВСЕ пары и вернёт список пар индексов
            foreach (var p in pairs) //Перебираем каждую пару индексов в списке
            {
                int i = p[0]; //Первый индекс пары
                int j = p[1]; //Второй индекс пары
                Console.WriteLine($"Пара: индексы [{i}, {j}], значения ({nums[i]}, {nums[j]})");
            }
            Console.ReadLine(); //Ждём нажатия Enter, чтобы консоль сразу не закрылась
        }
    }



//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {

//        for (int i = 0; i < nums.Length - 1; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    return new int[] { i, j };
//                }
//            }
//        }
//        return Array.Empty<int>();
//    }
//}