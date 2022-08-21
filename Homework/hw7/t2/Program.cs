/*Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет*/




void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}


string ReturnValue(int [,] arr, int pos1, int pos2)
{  
    if(pos1>arr.GetLength(0) | pos2>arr.GetLength(1))
        return $"Такого элемента нет";
    else
        return $"{arr[pos1-1,pos2-1]}";
}



Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 11);

Print(arr_1);
Console.WriteLine(ReturnValue(arr_1, 3,4));