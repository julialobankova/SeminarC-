/*Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

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
void amount(int from, int to, int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>= from && array[i]<=to )
        {
            amount = amount  +1;
        }
    }
    Console.WriteLine(amount);
}
int [] arr_1 = MassNums(123, 0,100);
ArrayPrint(arr_1);
amount(10,99, arr_1);

