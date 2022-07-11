/*Задача 2: Напишите программу,
 которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.*/


Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    int max = a;
    int min = b;
    Console.WriteLine($"{max} больше  {min}");
}
else 
{
    int max = b;
    int min = a;
    Console.WriteLine($"{min} меньше {max}");
}
