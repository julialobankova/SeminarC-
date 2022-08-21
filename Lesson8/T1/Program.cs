/*Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/

void Print(int[,]arr)
{
    int row_size = arr.GetLength(0);
    int colomn_size = arr.GetLength(1);
    for(int i = 0; i< row_size; i++)
    {
        for(int j = 0; j < colomn_size; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int colomn, int from, int to)
{
   int[,] arr = new int[row, colomn];
    for(int i = 0; i< row; i++)
    {
        for(int j = 0; j < colomn; j++)
        {
            arr[i,j]=new Random().Next(from,to);
        }
        
    }
    return arr;
}

int[,] ExchangeRow(int[,]arr)
{
    int helpRow = 0;
    int row = arr.GetLength(0);
    int colomn = arr.GetLength(1);
    for(int j = 0; j < colomn; j++)
        {
            helpRow = arr[0, j];
            arr[0, j] = arr[row-1, j];
            arr[row-1, j] = helpRow;
        }
        Console.WriteLine();
        return arr;
}


Console.WriteLine("Введите сколько строк будет в вашем массиве");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сколько столбцов будет в вашем массиве");
int colomn = int.Parse(Console.ReadLine());
int[,] arr1 = MassNums(row, colomn, 1, 100);
Print(arr1);
ExchangeRow(arr1);
Print(arr1);
