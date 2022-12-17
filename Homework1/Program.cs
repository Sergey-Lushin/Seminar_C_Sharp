//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В:");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {b} больше числа {a}");
}
*/
//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число C:");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"{max} наибольшое число.");
*/
//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0)
{
    Console.WriteLine($"{num} чётное число.");
}
else
{
    Console.WriteLine($"{num} не чётное число.");
}
*/
//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int i = 2;
Console.Write($"Чётные числа от 1 до {num}: ");
while (i <= num)
{
    Console.Write($"{i}; ");
    i = i + 2;
}