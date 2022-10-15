//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Программа выдает все четные числа от 1 до N");
Console.WriteLine("Введите положитеьное число N: ");
//1. Ввод числа
int N = int.Parse(Console.ReadLine()!);
if (N<=0) Console.WriteLine("Введите положительное число");
if (N == 1) Console.WriteLine("четных чисел нет");

//2. Определение четности и выдача результата


int index = 1;
while (index <= N)
{
    if (index % 2 == 0) Console.Write(index + " ");
    index++;
}
