/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Enter any integer:");
int anyInteger = int.Parse(Console.ReadLine()!);

int ThirdDigit(int number)
{
    int digit = 0;

    if (number < 1000 && number > 99)
    {
        digit = number % 10;
    }
    if (number > 1000)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        digit = number % 10;
    }
    if (number < 99)
    {
        digit = -1;
    }
    return digit;
}

int thirdDigit = ThirdDigit(anyInteger);
if (thirdDigit == -1)
{
    Console.WriteLine("No third digit");
}
else
{
    Console.WriteLine($"Third digit of the number: {thirdDigit}");
}