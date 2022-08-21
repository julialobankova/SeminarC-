/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

void ArrayPrint(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
        Console.Write($"{array2[i]} ");
    Console.Write("\n");
}

void h_m_num(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        
        if (numbers[i] > 0)
        {
            sum= sum+1;
                    
        }
    }
    Console.WriteLine(sum);
}
int[] MassNums(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr [i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
Console.WriteLine("Введите количество задуманных чисел: ");
int size_num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите задуманные числа, после каждого числа нажимайте 'Enter'");
int[] arr = MassNums(size_num);
ArrayPrint(arr);
Console.WriteLine("Вы ввели чисел больше нуля:");
h_m_num(arr);




