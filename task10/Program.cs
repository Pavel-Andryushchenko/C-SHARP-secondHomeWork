// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetSecondDigit(int secondDigit)
{
    secondDigit = Math.Abs(secondDigit);
    secondDigit = (secondDigit / 10) % 10;
    return secondDigit;
}

int GetInpoot(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInpoot("Введите трехзначное число: ");
Console.WriteLine($"{number} -> {GetSecondDigit(number)}");
