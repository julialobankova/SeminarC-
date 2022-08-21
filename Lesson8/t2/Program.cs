/*Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.*/


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

string ExchangeRowColumns(int[,] arr)
{
    int row = arr.GetLength(0);
    int colomn = arr.GetLength(1);

    if (row != colomn)
    {
        return "Error";
    }
    for (int i = 0; i < row; i++)
    {

        for (int j = 0; j < i; j++)
        {
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
        }

    }
    return "Yes";
}


Console.WriteLine("Введите сколько строк будет в вашем массиве");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сколько столбцов будет в вашем массиве");
int colomn = int.Parse(Console.ReadLine());
int[,] arr1 = MassNums(row, colomn , 1, 100);
Print(arr1);
Console.WriteLine(ExchangeRowColumns(arr1));
Print(arr1);
