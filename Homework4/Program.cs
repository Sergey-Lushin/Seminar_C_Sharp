// See https://aka.ms/new-console-template for more information
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("Введи число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} равно {degree(A, B)}");
// ------------Метод---------------
int degree(int A, int B){
    int sum = 1;
    for(int i = 1; i <= B; i++){
        sum = sum * A;
    }
    return sum;
}
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);
string M = num.ToString();
Console.WriteLine($"Сумма цифр в числе {num} равна {sumnumb(M)}");
Console.WriteLine($"Сумма цифр в числе {num} равна {sumnumb2(num)}");
//--------Metods-------
//строковый метод
int sumnumb(string num){
    int sum = 0;
    for(int i = 0; i < num.Length; i++){   
        sum = sum + Int32.Parse(num[i].ToString());
    }
    return sum;
}    
//арифметический метод
int sumnumb2(int num){
    int sum = 0;
    int i = 0;
    while (num > 0){
        i = num % 10;
        num = num / 10;
        sum = sum + i;
    }
    return sum;
}
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)");
int[] myArray = GetArray(8);
Console.WriteLine($"{String.Join(" ", myArray)}");
//------Metod-------
int[] GetArray(int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(1, 23);
    }
    return myArray;
}
