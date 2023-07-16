// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string GetWeekDay(int day)
{
    string result;
    if (day == 6 ^ day == 7 ) result = "да";
    else result = "нет";
    return result;
}

int GetInpoot(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int day = GetInpoot("Введите день недели: ");
Console.WriteLine($"{day} -> {GetWeekDay(day)}");