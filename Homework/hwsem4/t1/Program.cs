/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/



int power (int num, int power)
{
    int pow =Convert.ToInt16(Math.Pow(num,power));
    return pow;    
}

int A = Convert.ToInt16(Console.ReadLine());
int B = Convert.ToInt16(Console.ReadLine());
Console.Write($"{A}, {B} -> {power(A, B)}");