//Сокращенный способ:
using System;
using System.Linq;   // нужно для метода Sum
public class Kata
{
    public static int PositiveSum(int[] arr) => arr.Sum(i => i < 1 ? 0 : i);//с помощью LINQ и лямбда‑выражения с тернарным оператором (?)
}                                                                            //=> — сокращённая запись метода (expression-bodied method) - геттер/сеттер с телом-выражением. Вместо фигурных скобок {} и ключевого слова return, используется синтаксический сахар => (стрелка), за которым следует выражение
                                                                             //если i < 1, вернуть 0; иначе вернуть i.
/*public class Program
{
    static void Main(string[] args)
    {
        int[] data = { 1, -4, 7, 12 };
        int result = Kata.PositiveSum(data); //вызываем метод из класса Kata
        Console.WriteLine(result); //выведет: 20
        Console.ReadLine(); //чтобы консоль не закрылась сразу
    }
}*/
//Обычный способ:
//using System;
//public class Kata
//{
//    public static int PositiveSum(int[] arr)
//    {
//        int sum = 0; //накапливаем сумму
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] > 0) //считаем только положительные
//            {
//                sum += arr[i];
//            }
//        }
//        return sum; //если не было положительных, вернётся 0
//    }
//}
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int[] data = { 1, -4, 7, 12 };
//        Console.WriteLine(Kata.PositiveSum(data)); //выведет 20
//        Console.ReadKey();
//    }
//}