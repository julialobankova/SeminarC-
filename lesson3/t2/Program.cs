/*Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/

void Quarters(int quart)
{
    if (quart > 4 || quart < 1)
        Console.WriteLine(" No");
    else if (quart == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (quart == 2)
        Console.WriteLine("x < 0 y > 0");
    else if (quart == 3)
        Console.WriteLine("x < 0 y < 0");
    else if (quart == 4)
        Console.WriteLine("x > 0 y < 0");

}

Quarters(1);
Quarters(0);
Quarters(5);
Quarters(2);
Quarters(3);
Quarters(-5);