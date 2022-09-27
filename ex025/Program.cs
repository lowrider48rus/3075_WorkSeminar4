// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введи число А: ");

int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введи число B: ");

int B = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine($"Результат возведения числа {A} в степень {B} {Method1(A,B)}");

int Method1(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}