// Принимает число N и выдает произведение чисел от 1 до N

using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int fib = Fib(a);
Console.WriteLine($"Произведение чисел от 1 до {a} равно {fib}");




int Fib(int number)
{
    int result = 1;
    int i = 1;
    while(i<=number)
    {
        result *= i;
        i++;
    }
    return result;
}





