/*
Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0
*/
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
void even(int[] array)
{
    int sum = 0;
     for(int i = 0; i < array.Length; i=i+2)
     {
        sum = sum+array[i];    
     }
     Console.WriteLine(sum);
}
int [] array1 = MassNums(5,0,11);
ArrayPrint(array1);
even(array1);


