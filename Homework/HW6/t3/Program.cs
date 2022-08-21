void ArrayPrint(double[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} "); 
        Console.Write("\n");  
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < size; i++)
    {
        arr [i] = new Random().NextDouble();
    }
    return arr;
}


double[] CopyMass(double[] arr)
{
    int size = arr.Length;
    double[] new_arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        new_arr[i] = arr[i];
    }
    return new_arr;
}


double[] arr_1 = MassNums(5);
ArrayPrint(arr_1);
double[] arr_1_new = CopyMass(arr_1);
ArrayPrint(arr_1_new);