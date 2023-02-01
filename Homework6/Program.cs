//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь./new-console-template for more information
/*
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.");
Console.Write("Введите через пробел числа: ");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < myArray.Length; i++){
    if (myArray[i] > 0){
        count++;
    }
}
Console.WriteLine($"Кол-во элементов больше 0: {count}");
*/
//Задача 42: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
Console.WriteLine("Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).");
int[] myArray = GetArray(6);
Console.WriteLine($"{String.Join(" ", myArray)}");
int[] mySortArray = SortArray(myArray);
Console.WriteLine($"{String.Join(" ", mySortArray)}");
//------Metods-------
int[] GetArray(int size){                       // создание массива
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(1, 23);
    }
    return myArray;
}
int[] SortArray(int[] arr){                     // сортировка
    int temp = 0;
    for (int i = 0; i < arr.Length - 1; i++){
        for (int j = i + 1; j < arr.Length; j++){
            if (arr[i] > arr[j]){
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}