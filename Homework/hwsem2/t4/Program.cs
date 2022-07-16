 /*Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/

void WEEK (int a)
{
if (a == 1)
    Console.WriteLine("пн");
else if (a == 2)
    Console.WriteLine("вт");
else if (a == 3)
    Console.WriteLine("ср");
else if (a == 4)
    Console.WriteLine("чт");
else if (a == 5)
    Console.WriteLine("пт");
else if (a == 6)
    Console.WriteLine("сб");
else if (a == 7)
    Console.WriteLine("вс");

else 
    Console.WriteLine("Ошибка ввода");
    

}

Console.WriteLine("Write a weekday number: ");
int a = int.Parse(Console.ReadLine());
WEEK(a);
 if (a >= 1 && a <= 5)
        {
        Console.WriteLine("Будни");
        }
    if (a >5 && a <= 7 )
        {
        Console.WriteLine("Выходной");
        }
    






/*if (a <= 5)
{ 
   Console.WriteLine("Увы это будни");
}
else if (5 >= a <= 7 )
{
    Console.WriteLine("Выходной, Ура");
}
else
{
    Console.WriteLine("Ошибка ввода");
}*/
