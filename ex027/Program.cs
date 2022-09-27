// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Convert.ToInt32(A[i].ToString())!!!

Console.WriteLine("Введи число А: ");
string A = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Сумма цифр числа {A} равна {Method2(A)}");

int Method2(string number)
{
    int j = number.Length;
    int sum = 0;
    for (int i = 0; i < j; i++)
    {
        sum = sum + Convert.ToInt32(number[i].ToString());
    }
    return sum;
}
