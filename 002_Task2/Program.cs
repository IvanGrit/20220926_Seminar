// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int nc = NumberCount(a);
Console.WriteLine($"Количество цифр в числе {a} равно {nc}");



int NumberCount(int number)
{
    int result = 0;
    if(number == 0) 
    {
        result = 1;
        return result;
    }
    while(number>0)
    {
        number /= 10;
        result++;
    }
    return result;
}
