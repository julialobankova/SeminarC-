/*Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно 7 и
23.*/

void Krat(int number)
{

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine("Молоде классное число");
else
Console.WriteLine("no");
}

int a = int.Parse(Console.ReadLine());
Krat(a);

