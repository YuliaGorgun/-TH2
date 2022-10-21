// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = int.Parse (Console.ReadLine()!);
int GetSecondDigit(int number)
{
    int SecondDigit = number / 10 % 10;
    return SecondDigit;
}
int SecondDigit = GetSecondDigit(number);
Console.WriteLine(SecondDigit);