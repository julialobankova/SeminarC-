/*3. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деление.*/

void MaxDigit2(int number1, int number2)
{
    if (number2 % number1 == 0)
        Console.WriteLine($"{number2} кратно {number1}");
    else
        Console.WriteLine($"{number2} не кратно {number1} остаток {number2 % number1} ");

}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
MaxDigit2(a,b);
