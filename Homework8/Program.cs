// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
/*Console.WriteLine("Введите количество строк:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int M = Convert.ToInt32(Console.ReadLine());
int[,] myArray = GetArray(N, M, 1, 9);
PrintArray(myArray);
Console.WriteLine();
sortingArray(myArray);
PrintArray(myArray);

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
void sortingArray(int[,] arr){                                        // сортировка строк в массиве
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            for (int k = j + 1; k < arr.GetLength(1); k++){
                if (arr[i, k] > arr[i, j]){
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}
*/
/*
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("Введите количество строк:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int M = Convert.ToInt32(Console.ReadLine());
int[,] myArray = GetArray(N, M, 1, 9);
PrintArray(myArray);
int minRowSum = 0;
int sumRow = sumRowElements(myArray, 0);
for (int i = 1; i < myArray.GetLength(0); i++)
{
  int tempSumRow = sumRowElements(myArray, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minRowSum = i;
  }
}
Console.WriteLine($"Cтрока {minRowSum + 1} с суммой элементов {sumRow} наименьшая");

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
int sumRowElements(int[,] arr, int i)                               // сумма элементов строки
{
  int sum = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sum = sum + arr[i,j];
  }
  return sum;
} 
*/
/*
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine("Введите количество строк первой матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"У второй матрицы {M} строк");
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int K = Convert.ToInt32(Console.ReadLine());
int[,] Martrix1 = GetArray(N, M, 1, 9);
PrintArray(Martrix1);
Console.WriteLine();
int[,] Martrix2 = GetArray(M, K, 1, 9);
PrintArray(Martrix2);
int[,] resMatrix = new int[N, K];

multiplyMatrix(Martrix1, Martrix2, resMatrix);
Console.WriteLine($"Произведение первой и второй матрицы равно:");
PrintArray(resMatrix);


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
void multiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resMatrix){    //умножение матриц
  for (int i = 0; i < resMatrix.GetLength(0); i++){
    for (int j = 0; j < resMatrix.GetLength(1); j++){
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++){
        sum = sum + Martrix1[i,k] * Martrix2[k,j];
      }
      resMatrix[i,j] = sum;
    }
  }
}
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
int n = 4;
int[,] snakeArray = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= snakeArray.GetLength(0) * snakeArray.GetLength(1)){
  snakeArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < snakeArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= snakeArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > snakeArray.GetLength(1) - 1)
    j--;
  else
    i--;
}
PrintArray(snakeArray);

//--------Metod----------
void PrintArray (int[,] arr){
  for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++){
      Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}