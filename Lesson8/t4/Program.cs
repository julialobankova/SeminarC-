/*Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.*/

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int colomn_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < colomn_size; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int colomn, int from, int to)
{
    int[,] arr = new int[row, colomn];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }

    }
    return arr;
}

int[] MinElement(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int colomn_size = arr.GetLength(1);
    int min = arr[0, 0];
    int[] index = new int[2];
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < colomn_size; j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

void DelRowColumns(int[,] arr, int[] arr1)
{
    int row_size = arr.GetLength(0);
    int colomn_size = arr.GetLength(1);
    int[] index = new int[2];
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < colomn_size; j++)
        {
            if (index[0] == i || index[1] == j)
            {
                continue;
            }
            else
            {
                Console.Write($" {arr[i, j]} ");
            }
            
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите сколько строк будет в вашем массиве");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сколько столбцов будет в вашем массиве");
int colomn = int.Parse(Console.ReadLine());
int[,] arr1 = MassNums(row, colomn , 1, 100);
Print(arr1);
int[] arr2 = MinElement(arr1);
DelRowColumns(arr1, arr2) ;


