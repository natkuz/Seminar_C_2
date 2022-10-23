/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Enter day of the week number:");
int dayOfWeek = int.Parse(Console.ReadLine()!);

string DayOff(int number)
{
    if (number > 5 && number < 8)
    {
        return "Yes, this day is a holiday";
    }
    else if (number > 0 && number < 6)
    {
        return "No, this day is not a holiday";
    }
    else
    {
        return "Number is not a day of the week";
    } 
}

string day = DayOff(dayOfWeek);
Console.WriteLine(day);