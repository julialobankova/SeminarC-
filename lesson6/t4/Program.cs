void fibo ( int num)
{
    int a = 0;
    int b =1;
    for(int i = 0; i<num; i++)
    {
        Console.Write($"{a} ");
        (a,b) = (b,a+b);
    }
}

fibo(23);

int Fibo (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibo(n-1) + Fibo(n-2);
}
for(int i = 1; i<10; i++)
{
    Console.Write($"{Fibo(i)} ");
}