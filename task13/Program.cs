// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string GetThirdDigit(int thirdDigit)
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

{
    string result;
    thirdDigit = Math.Abs(thirdDigit);
    if (thirdDigit < 100) result = "Третьей цифры нет"; 
    else
    {
        while (thirdDigit >= 1000)
        {
            thirdDigit = thirdDigit / 10;
        }
        thirdDigit = thirdDigit % 10;
        result = Convert.ToString(thirdDigit);
    }
    return result;
}

int GetInpoot(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInpoot("Введите число: ");
Console.WriteLine($"{number} -> {GetThirdDigit(number)} ");