/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.*/

void Print(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int colomnSize = arr.GetLength(1);
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colomnSize; j++)
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



    void RowWithMinSumElement(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    int[] sumRow= new int[rowSize];
    int minRow=0;
    
    for(int i=0; i<rowSize; i++)
    {
        for(int j=0; j<columnSize; j++)
        {
            sumRow[i]+=arr[i,j];
        }
        
        if (sumRow[i]<sumRow[minRow])
        {
            minRow=i;
        }
            
    }
    Console.WriteLine();
    Console.WriteLine($" Номер строки с наименьшей суммой элементов: {minRow+1} строка");
}

    int[,] arr1 = MassNums(4, 4, 1, 10);
    Print(arr1);
    RowWithMinSumElement(arr1);

