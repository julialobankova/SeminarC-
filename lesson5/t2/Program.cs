/*Напишите программу замены элементов массива:
положительные элементы замените на соответствующие
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void ArrayPrint(int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} "); 
        Console.Write("\n");  
}
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr [i] = new Random().Next(from,to);
    }
    return arr;
}

void  MassReplace(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
   
}
int[] array_1 = MassNums(5,-9,10);
ArrayPrint(array_1);
MassReplace(array_1);
ArrayPrint(array_1);








/*int [] MassReplace(int size, int )
{
	string result = String.Empty;

	int length = text.Length // ДЛИНА СТРОКИ колличсевто символов в строке 
	for (int i = 0; i<length; i++)
	{
		if(text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}


string newText = Replace(text, ' ','|');
Console.WriteLine(newText);*/
	