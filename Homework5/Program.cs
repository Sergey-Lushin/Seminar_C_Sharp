//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
/*
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int [] myArray = GetArray(size, 100, 999);
Console.WriteLine($"[{String.Join(", ", myArray)}]");
int count = 0;
for (int i = 0; i < myArray.Length; i++){
    if (myArray[i] % 2 == 0){
        count++;
    }
}
Console.WriteLine($"В массиве {count} четных чисел");
//------Metod------
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
*/
/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.");
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int [] myArray = GetArray(size, -2, 2);
Console.WriteLine($"[{String.Join(", ", myArray)}]");
int sum = 0;
for (int i = 1; i < myArray.Length; i+=2){
    sum = sum + myArray[i];
}
Console.WriteLine($"Сумма нечётных элементов в массиве = {sum}");
//------Metod------
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
Console.WriteLine("Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int [] myArray = GetArray(size, 1, 10);
Console.WriteLine($"[{String.Join(", ", myArray)}]");
int size1 = myArray.Length / 2 + 1;
int[] newArray = new int[size1];
for (int i = 0; i < myArray.Length / 2; i++){
    newArray[i] = myArray[i] * myArray[myArray.Length - i - 1];
}
if (myArray.Length % 2 == 1){
    newArray[size1 - 1] = myArray[myArray.Length / 2];
    
}
Console.WriteLine($"[{String.Join(", ", newArray)}]");


//------Metod------
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}