/*Напишите программу, которая принимает
 на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/

void Pali(int number)
{
    if (number > 100000 || number < 10000 )
    {
        Console.WriteLine("Error");
    }
    
    else if (number / 10000 == number % 10 && number % 10000 / 1000 == number % 100 / 10)
    {
        Console.WriteLine("Число палиндром");
    }

    else
    {
        Console.WriteLine("Число не палиндром");       
    }
}

Pali(24542);
Pali(255);
Pali(3699874);
Pali (56987);






