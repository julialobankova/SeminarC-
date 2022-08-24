/*Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке от M до N.*/



void EvenIntNumbers(int min, int max)
{
    max-=max%2;
    if (max<min) return;
    EvenIntNumbers(min,max-2);
    Console.Write($"{max}, ");
}

EvenIntNumbers(1,10);