// Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
Console.WriteLine("Введите размер массива: ");

int s = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите левую границу интервала рандома: ");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите правую границу интервала рандома: ");

int b = int.Parse(Console.ReadLine()!);

int[] ar = FillArray(s,a,b);
int[] ar1 = GetArray(s, a, b);
Console.WriteLine("Первый способ: ");
PrintArray(ar);
Console.WriteLine();
Console.WriteLine("Второй способ: ");
PrintArray(ar1);

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}

void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]}, ");
    } 
}

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min,max);
    }
    return result;
}
