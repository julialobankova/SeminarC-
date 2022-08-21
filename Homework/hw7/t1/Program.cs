/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.*/




void Print(double[,] arr)
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

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble()*(100+100)-100,2);
        }
    }
    return arr;
}


double[,] arr_1 = MassNums(3, 4,-100,100);

Print(arr_1);

