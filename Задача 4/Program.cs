//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.WriteLine("Программа показывающая максимальное число из 3х предложенных");
Console.WriteLine("Введите число а ");
//1. Ввод чисел
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число с ");
int C = int.Parse(Console.ReadLine()!);

//2. Поиск максимального числа
int Max = A;
if(B > Max) Max = B;
if(C > Max) Max = C;

//3. Вывод результата на консоль
Console.WriteLine("Максимальное число: " + Max);