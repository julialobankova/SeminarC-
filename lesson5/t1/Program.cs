/*Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.*/



void ArrayPrint(int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} "); 
        Console.Write("\n");  
}
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr [i] = new Random().Next(from,to);
    }
    return arr;
}

void SumPosNeg(int [] array)
{
    int SumPos, SumNeg;
    SumPos = SumNeg = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>=0)
        {
            SumPos+=array[i];
        }
        else 
        {
            SumNeg+=array[i];
        }
    }
    Console.WriteLine($"Positiv:{SumPos} Negative: {SumNeg}");

}


int[] array_1 = MassNums(12,-9,10);
ArrayPrint(array_1);
SumPosNeg(array_1);