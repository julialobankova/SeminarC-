/*Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
void number (string A)
{
        Console.WriteLine(A.Length);
} 
number(Convert.ToString(Console.ReadLine()));