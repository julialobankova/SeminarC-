/*Задайте двумерный массив. Найдите элементы, у которых
обе позиции чётные, и замените эти элементы на их квадраты*/



void Print(int[,]arr)
{
    int row_size = arr.GetLength(0);
    int colomn_size = arr.GetLength(1);
    for(int i = 0; i< row_size; i++)
    {
        for(int j = 0; j < colomn_size; j++)
        {
            Console.Write($"{arr[i,j]}  ");
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

int[,] ReplacingSq(int[,]array)
{
    int row = array.GetLength(0);
    int colomn = array.GetLength(1);
    for(int i = 1; i< row; i+=2)
    {
        for(int j = 1; j < colomn; j+=2)
        {
            array[i,j] =Convert.ToInt32(Math.Pow(array[i,j],2));
        }
        
    }
    return array;
}

Console.Write("row");
int row = int.Parse(Console.ReadLine());
Console.Write("colomn");
int colomn = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, colomn,1, 51);
Print(arr_1);
ReplacingSq(arr_1);
Print(arr_1);