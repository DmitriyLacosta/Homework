﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


Console.WriteLine("Программа проверки четного числа");
Console.WriteLine("Введите число: ");
//1. Ввод числа
int A = int.Parse(Console.ReadLine()!);

//2. Определение четности и выдача результата
if(A%2==1)
{
    Console.WriteLine("Нет, число нечетное");
}
else
{
    Console.WriteLine("Да, число четное");
}