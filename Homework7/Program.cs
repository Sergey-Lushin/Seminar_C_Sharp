// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Задача 47. Задайте двумерный массив размером m на n, заполненный случайными вещественными числами.");
double[,] myArray = GetArray(4, 4, -10, 10);


//-------Metods--------
double[,] GetArray(int m, int n, int minValue, int maxValue){              // создание двумерного массива
    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(double[,] arr){                                          // вывод на экран массива
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]:F2} ");
        }
        Console.WriteLine();
    }
}
*/
/*
//Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.");
int[,] myArray = GetArray(4, 4, 1, 9);
PrintArray(myArray);
Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine()!);
if (FindNumb(numb, myArray)){
    Console.WriteLine($"Число {numb} есть в массиве.");
}
else{
    Console.WriteLine($"Число {numb} массиве отсутствует.");
}
//-------Metods--------
int[,] GetArray(int m, int n, int minValue, int maxValue){              // создание двумерного массива
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
bool FindNumb(int N, int[,] arr){                                       // поиск числа N в массиве
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            if (arr[i, j] == N){
            return true;
            }
           
        }
    } return false;
}
void PrintArray(int[,] arr){                                          // вывод на экран массива
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце");
Console.WriteLine("Введите количество строк:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int M = Convert.ToInt32(Console.ReadLine());
int[,] myArray = GetArray(N, M, 1, 9);
PrintArray(myArray);
for (int j = 0; j < myArray.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        avarage = (avarage + myArray[i, j]);
    }
    avarage = avarage / N;
    Console.Write($"{avarage:F2}; ");
}
Console.WriteLine();






//-------Metods---------
int[,] GetArray(int m, int n, int minValue, int maxValue){              // создание двумерного массива
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] arr){                                          // вывод на экран массива
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
