// Задача №1
Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);
if (num > 99 && num < 1000)
{
    Console.WriteLine($"Вторая цифра числа {num} это: {num / 10 % 10}");
}
else
{
    Console.WriteLine("Введите трехзначное число!!!");
}
// Задача №2
Console.WriteLine("Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите число до 100000");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (num1 >= 100 && num1 < 1000)
{
     Console.WriteLine($"Третья цифра числа {num1} это: {num1 % 10}");
}
if (num1 >= 1000 && num1 < 10000)
{
    Console.WriteLine($"Третья цифра числа {num1} это: {num1 / 10 % 10}");
}
if (num1 >= 10000 && num1 < 100000)
{
    Console.WriteLine($"Третья цифра числа {num1} это: {num1 / 100 % 10}");
}
if (num1 >= 100000)
{
    Console.WriteLine("Введите число до 100000!!!");
}
// Задача №3
Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("Введите номер дня недели:");
int num2 = int.Parse(Console.ReadLine()!);
if (num2 > 0 && num2 < 8)
{
    if (num2 > 5 )
    {
        Console.WriteLine("Это выходной");
    }
    if (num2 <= 5)
    {
        Console.WriteLine("Это рабочий день");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет");
}