/*Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

void kv (int a)
{
    int i = 1;
    while (i <= a)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }

}
kv(3);
kv(5);

