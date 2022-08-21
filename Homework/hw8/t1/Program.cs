/*Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы
 каждой строки двумерного массива.*/


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

void SortRowDescending(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for(int i=0; i<row_size;i++)
    {
        for(int j=0; j<column_size-1; j++)
        {
            for(int k=0; k<column_size-j-1; k++)
            {
                if(arr[i,k]<arr[i,k+1])
                (arr[i,k],arr[i,k+1])=(arr[i,k+1],arr[i,k]);
            }
        }
    } 
}

Console.WriteLine("Введите сколько строк будет в вашем массиве");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сколько столбцов будет в вашем массиве");
int colomn = int.Parse(Console.ReadLine());
int[,] arr1 = MassNums(row, colomn, 1, 100);
Print(arr1);
SortRowDescending(arr1);
Print(arr1);
