/*Перевод Системы исчисления:
45 -> 101101
3 -> 11
2 -> 10*/

/*Перевод из 10ой -> 2ую СС*/

int x = int.Parse(Console.ReadLine());
string a = Convert.ToString(x,2);

Console.WriteLine(a);

//Перевод из двочной в любую

void not(int number, int notation)
{
    string s = "";
    while (number > 0)
    {
        int t = number % notation;
        number /= notation;
        s += t.ToString();
    }
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    Console.Write("Ответ: " + new String(arr));
}

Console.Write("Число: ");
int NR = int.Parse(Console.ReadLine());
Console.Write("Система счисления: ");
int NN = int.Parse(Console.ReadLine());
not(NR,NN);


