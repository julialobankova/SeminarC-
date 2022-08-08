/*Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
20 мин*/

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
void check( int num, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        {
            Console.WriteLine("да");
            break;
        }
        else
        {
            Console.WriteLine("нет");
            break;
        }
    }
}
int [] arr_1 = MassNums(5,-100,101);
ArrayPrint(arr_1);
check(5,arr_1);
