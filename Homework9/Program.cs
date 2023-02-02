/*
// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.WriteLine("Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(N, 1));
// ------Метод------------------------
string PrintNumbers(int start, int end){
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}
*/
/*
//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(sumNumbers(M, N));
// ------Метод------------------------
int sumNumbers(int M, int N){
    if (M == N) return M;
    return (M + sumNumbers(M + 1, N));
}
*/
//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (M < 0 || N < 0){
    Console.Write("Введены неверные числа.");  
}
else{
        Console.WriteLine(Ackermann(M, N));
    }
//------метод-------
int Ackermann(int m, int n){
			if(m == 0){
				return n + 1;
			}
			if(m > 0 && n == 0){
				return Ackermann(m - 1, 1);
			}
			return Ackermann(m - 1, Ackermann(m, n - 1));
		}