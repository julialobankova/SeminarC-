﻿/*Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/
void ArrayPrint(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
        Console.Write($"{array2[i]} ");
    Console.Write("\n");
}
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int[] RevMass(int[] arr)
{
    int size = arr.Length-1;
    for(int i = 0; i < size/2+1; i++)
    {
        (arr[i], arr[size-i]) = (arr[size-i], arr[i]);
        
    }
    return arr;
}
int[] arr_1 = MassNums(6, 1, 11);
ArrayPrint(arr_1);
RevMass(arr_1);
ArrayPrint(arr_1);

