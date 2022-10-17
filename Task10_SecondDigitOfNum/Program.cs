/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Enter three-digit number:");
int threeDigitNumber = int.Parse(Console.ReadLine()!);

int SecondDigitOfNumber(int number)
{
    int digit = number / 10 % 10;
    return digit ;
}

int secondDigit = SecondDigitOfNumber(threeDigitNumber);
Console.WriteLine($"Second digit of the number {threeDigitNumber} is {secondDigit}");