/* Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
*/
int MT1 (int number)
{
    return number % 100 /10; 
}
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(MT1(a));