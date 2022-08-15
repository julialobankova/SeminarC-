/*Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/
/*matrix.GetLength(0);- обращение к строкам 
matrix.GetLength(0); - обращение к столбцам*/

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

Console.Write("row");
int row = int.Parse(Console.ReadLine());
Console.Write("colomn");
int colomn = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, colomn,1, 11);
Print(arr_1);