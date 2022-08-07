/*Напишите программу, которая задаёт массив из
8 элементов случайными числами и выводит их на экран.
Оформите заполнение массива и вывод в виде функции
(пригодится в следующих задачах)*/

int[] RanArray(int num)
{
    int[] array1 = new int[num];
    for(int i=0; i < num; i++)
        array1[i]=new Random().Next(0,100);
    return array1;
}

void ArrayPrint(int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} ");
}
ArrayPrint(RanArray(8));





