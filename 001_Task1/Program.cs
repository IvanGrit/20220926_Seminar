// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Readline()!);
int sum = GetSum(a);
Console.WriteLine($"Сумма {sum}");






int GetSum(int number)
{
    int result = 0;
    while(number>0)
    {
        result = result + number;
        number--;
    }
        return result;
}