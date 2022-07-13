/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/


Console.WriteLine("Введите число и я покажу все четные числа до вашего числа: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
while (i <= a)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
        i ++;
    }
    else 
    {
        i ++;
    }
}

