/*Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2*/

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
     for(int i = 0; i < array.Length; i++)
     {
        if(array[i] % 2 == 0)
        {
            sum = sum+1;   
        }
        
     }
     Console.WriteLine(sum);
}
int [] array1 = MassNums(5,100,1000);
ArrayPrint(array1);
even(array1);