/*Задайте двумерный массив размера m на n, каждый
элемент в массиве находится по формуле: Aₙₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

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

int[,] MassNums(int row, int colomn)
{
   int[,] arr = new int[row, colomn];
    for(int i = 0; i< row; i++)
    {
        for(int j = 0; j < colomn; j++)
        {
            arr[i,j]=i+j;
        }
        
    }
    return arr;
}

Console.Write("row");
int row = int.Parse(Console.ReadLine());
Console.Write("colomn");
int colomn = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, colomn);
Print(arr_1);