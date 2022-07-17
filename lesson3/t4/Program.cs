/*Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.*/

void kv (int a)
{
    int i = 1;
    while (i <= a)
    {
        Console.WriteLine(Math.Pow(i,2));
        i++;
    }

}
kv(5);
kv(12);

