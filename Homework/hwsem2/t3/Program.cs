/*Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет.*/

void MT3(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (number > 999)
            number = number / 10;
        Console.WriteLine(number % 10);
    }
}
MT3(12325545);