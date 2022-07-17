/*Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.*/
int MT2 (int number)
{
    return ((number/100)*10+(number%10));
}
int a = new Random().Next(100,999);
Console.WriteLine(a);
Console.WriteLine(MT2(a));


