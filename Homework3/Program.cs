// Задача 1
Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine()!);
string polindrome = Convert.ToString(num);
if (polindrome.Length == 5)
{
    if (polindrome[0] == polindrome[4] && polindrome[1] == polindrome[3])
    {
        Console.WriteLine($"Число {num} яляется палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не яляется палиндромом");
    }
}
else
{
    Console.WriteLine("Введено неверное число");
}
//Задача 2
Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Введете координаты первой точки: ");
Console.Write("x = ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("y = ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("z = ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введете координаты второй точки: ");
Console.Write("x = ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("y = ");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("z = ");
int zb = int.Parse(Console.ReadLine()!);
double sum = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками: {sum:f2}");
//Задача 3
Console.WriteLine("Задача 3: пишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введете число N: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}