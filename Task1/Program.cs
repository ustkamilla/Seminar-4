/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Не использовать Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int Pow(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result *= num1;
    }
    return result;
}

int a = InputInt("Введите число А");
int b = InputInt("Введите число В");
Console.WriteLine($"{a}, {b} -> {Pow(a, b)}");
