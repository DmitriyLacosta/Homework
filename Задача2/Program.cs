//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Программа показывающая максимальное число");
Console.WriteLine("Введите число а ");
//1. Ввод числа
int A = int.Parse(Console.ReadLine()!);
//2.  Ввод числа
Console.WriteLine("Введите число b ");
int B = int.Parse(Console.ReadLine()!);

//2. Поиск максимального числа
int Max = 0;
if(B < A)
{
    Max = A;
}
else
{
    Max = B;
}

//3. Вывод результата на консоль
Console.WriteLine("Максимальное число: " + Max);