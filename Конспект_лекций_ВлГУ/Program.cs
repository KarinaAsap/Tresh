////1) Напишем программу для вычисления длины окружности по заданному пользователем радиусу:
//const double PI = 3.14159;
//Console.Write("Введите радиус: ");
//double r = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Длина окружности: {2.0 * PI * r}");


////2) Напишем программу для вычисления значения функции
//Console.Write("Введите x: ");
//double x = Convert.ToDouble(Console.ReadLine());
//double y = (Math.Pow(2.0, x) + Math.Exp(2.0 * x)) / (x * x * Math.Log(x));
//Console.WriteLine($"y = {y}");


////3) Напишем программу для отыскания вещественных корней квадратного уравнения :
//Console.Write("Введите a: ");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите b: ");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите c: ");
//double c = Convert.ToDouble(Console.ReadLine());
//double D = b * b - 4.0 * a * c;
//if (D > 0)
//{
//    double sD = Math.Sqrt(D);
//    double x1 = (-b + sD) / (2.0 * a);
//    double x2 = (-b - sD) / (2.0 * a);
//    Console.WriteLine($"Корни: {x1}, {x2}");
//}
//else if (D == 0)
//{
//    double x = -b / (2.0 * a);
//    Console.WriteLine($"Корень: {x}");
//}
//else
//    Console.WriteLine("Вещественных корней нет.");
////Тернарный оператор ?: работает так же, как и в C++. Например, знак числа a можно найти так:
//int sgn = (a >= 0) ? 1 : -1;
//Console.WriteLine(sgn);


////4) Напишем программу, которая по заданному пользователем номеру дня недели выводит название этого дня недели:
//Console.Write("Введите номер дня недели: ");
//int day = Convert.ToInt32(Console.ReadLine());
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Понедельник");
//        break;
//    case 2:
//        Console.WriteLine("Вторник");
//        break;
//    case 3:
//        Console.WriteLine("Среда");
//        break;
//    case 4:
//        Console.WriteLine("Четверг");
//        break;
//    case 5:
//        Console.WriteLine("Пятница");
//        break;
//    case 6:
//        Console.WriteLine("Суббота");
//        break;
//    case 7:
//        Console.WriteLine("Воскресенье");
//        break;
//    default:
//        Console.WriteLine("Нет такого дня");
//        break;
//}


////5) Напишем программу, выводящую факториалы всех чисел от 1 до заданного пользователем:
//Console.Write("Введите число: ");
//uint stop = Convert.ToUInt32(Console.ReadLine());
//for (uint cur = 1; cur <= stop; cur++)
//{
//    ulong product = 1;
//    for (uint i = 2; i <= cur; i++)
//        product *= i;
//    Console.WriteLine($"{cur}! = {product}");
//}


////6) Напишем программу для нахождения корня уравнения xcosx+3=0, лежащего на отрезке [0;PI], с заданной пользователем точностью с помощью метода половинного деления:
//double a = 0.0, b = Math.PI, c = (a + b) / 2.0;
//Console.Write("Введите точность: ");
//double eps = Convert.ToDouble(Console.ReadLine());
//while (b - a >= 2.0 * eps)
//{
//    double fa = a * Math.Cos(a) + 3.0;
//    double fc = c * Math.Cos(c) + 3.0;
//    if (fc == 0.0)
//        break;
//    if (((fa > 0.0) && (fc < 0.0)) ||
//    ((fa < 0.0) && (fc > 0.0)))
//        b = c;
//    else
//        a = c;
//    c = (a + b) / 2.0;
//}
//Console.WriteLine($"Корень: {c}");


////7) Напишем игру «Угадай число»: генерируется псевдо-случайное число в заданных пределах, известных пользователю, а пользователь должен его угадать. Если пользователь угадывает число, игра закончена. Если пользователь не угадывает число, программа сообщает, больше или меньше введенное пользователем число загаданного числа, и повторяет процесс, пока число не будет угадано.
//int userNum;
//Random rnd = new Random();
//int randNum = rnd.Next(1, 100);
//Console.WriteLine("Загадано число от 1 до 100.");
//do
//{
//    Console.Write("Ваше число: ");
//    userNum = Convert.ToInt32(Console.ReadLine());
//    if (userNum == randNum)
//        Console.WriteLine("Угадали!");
//    else if (userNum < randNum)
//        Console.WriteLine("Ваше число меньше");
//    else
//        Console.WriteLine("Ваше число больше");
//}
//while (userNum != randNum);


////8) В качестве примера выведем введенную пользователем строку посимвольно:
//Console.WriteLine("Введите строку:");
//string? str = Console.ReadLine();
//foreach (char c in str)
//    Console.WriteLine(c);


////9) Напишем программу, которая выделяет количество памяти, потребное для хранения целочисленного массива заданного пользователем размера, заполняет массив с клавиатуры, сортирует его пузырьком и выводит:
//Console.Write("Введите количество элементов: ");
//int n = Convert.ToInt32(Console.ReadLine());
//// Выделение памяти
//int[] arr = new int[n];
//// Ввод
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write("Введите элемент №{i}: ");ы
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//// Пузырьковая сортировка
//for (int i = arr.Length - 1; i >= 0; i--)
//    for (int j = 0; j < i; j++)
//        if (arr[j] > arr[j + 1])
//        {
//            int buf = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = buf;
//        }
//// Вывод
//foreach (int i in arr)
//    Console.Write($"{i} ");
//Console.WriteLine();


////10) Например, создадим треугольный массив, заполненный последовательными натуральными числами:
//// Выделение памяти
//int[][] arr = new int[3][];
//for (int i = 0; i < arr.Length; i++)
//    arr[i] = new int[i + 1];
//// Заполнение
//int k = 1;
//for (int i = 0; i < arr.Length; i++)
//    for (int j = 0; j < arr[i].Length; j++)
//        arr[i][j] = k++;
//// Вывод
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//        Console.Write($"{arr[i][j]}\t");
//    Console.WriteLine();
//}


////11) Удобный способ работы с набором не обязательно однотипных значений предоставляют кортежи. Кортеж из двух значений можно объявить так:
//using System.Collections.Generic;
//(string, int) one = ("один", 1);
//(string, int) two = (first: "два", second: 2);
////Можно обращаться к полям кортежа, указав имя кортежа, точку и слово Item с номером поля (поля нумеруются, начиная с 1):
//Console.WriteLine(one.Item1); // Выведется: один
//Console.WriteLine(one.Item2); // Выведется: 1
//Console.WriteLine(two.Item1); // Выведется: два
//Console.WriteLine(two.Item2); // Выведется: 2
////Можно сделать декомпозицию кортежа:
////Console.WriteLine(first);
////Console.WriteLine(second);
////Также кортеж можно использовать для обмена значений переменных
//int a = 1, b = 2;
//(a, b) = (b, a);
//Console.WriteLine($"{a} {b}"); // Выведется: 2 1


//12) Переменной типа string можно присвоить значение следующими несколькими способами:
using System.Text;

string str1 = "Hello, world";
string str2 = new String('!', 3); // "!!!"
char[] chars1 = { ' ', 'H', 'o', 'w', ' ' };
char[] chars2 = { 'h', 'a', 'r', 'e', 's' };
string str3 = new String(chars1); // " How "
string str4 = new string(chars2, 1, 3); // "are"
//Также можно включить в строку значения переменных, что мы делали при выводе:
int i = 1;
string str5 = $"Один: {i}";
Console.WriteLine(str5);
//Еще можно делать многострочные строки с помощью тройных кавычек:
string mysite = """
<head>
<title>Мой сайт</title>
</head>
<body>
<p>Это мой сайт!</p>
</body>
""";
Console.WriteLine(mysite);
//Можно обратиться к символу строки с помощью его индекса (но только для чтения):
Console.WriteLine(str1[0]); // Вывод символа 'H'
//Количество символов в строке хранится в свойстве Length:
Console.WriteLine(str1.Length); // 12 символов в "Hello, world"
//Строки можно сравнивать операторами == и !=. В том же примере:
if (str1 != str2)
    Console.WriteLine("str1 != str2");
//Оператор + используется для конкатенации строк. В том же примере:
string str6 = str1 + str2 + str3 + str4 + ' ' + "you?";
Console.WriteLine(str6);
//Для работы с динамически изменяемыми строками в C# имеется класс StringBuilder:
StringBuilder имя = new StringBuilder();
//или так:
StringBuilder имя = new StringBuilder("текст");