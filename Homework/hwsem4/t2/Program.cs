/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int sumnum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}
int A = Convert.ToInt32(Console.ReadLine());
Console.Write($"{A} -> {sumnum(A)}");
