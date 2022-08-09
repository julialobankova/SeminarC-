/*Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3, 7, 22, 2, 78] -> 76*/
void ArrayPrint(double[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} "); 
        Console.Write("\n");  
}
double[] MassNums(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < size; i++)
    {
        arr [i] = new Random().NextDouble();
    }
    return arr;
}
double MaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    


     for(int i = 0; i < array.Length; i++)
     {
        if(array[i]< min)
        {
            min = array[i];
        }
        if(array[i]>max)
        {
            max = array[i];
        } 
     }
     double diff = max - min;
     return diff;
}
double [] array1 = MassNums(5);
ArrayPrint(array1);
Console.WriteLine(MaxMin(array1));

