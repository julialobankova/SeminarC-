/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

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

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for(int i = 0; i < size / 2; i++)
        new_arr[i] = arr[i] * arr[size - i - 1];

    if (new_arr[flex_size - 1] == 0)
        new_arr[flex_size - 1] = arr[flex_size - 1];

    return new_arr;
}

int[] arr_1 = MassNums(5);
Print(arr_1);
int[] new_arr_1 = PairsNum(arr_1);
Print(new_arr_1);
