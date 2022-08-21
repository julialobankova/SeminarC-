 /*Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/
void triangle(int num1, int num2, int num3)
{
    if (num1<num2+num3 && num2<num1+num3 && num3<num2+num1)
    {
        Console.WriteLine("Ура у вас треугольник");
    }
    else
    {
        Console.WriteLine("Увы, треугольника не состряпать");
    }
}
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

triangle(Convert.ToInt32(a),Convert.ToInt32(b),Convert.ToInt32(c));