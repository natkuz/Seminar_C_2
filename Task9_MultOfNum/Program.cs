/* Дополнительная Задача 9
Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

Console.WriteLine("Enter number to check the multiplicity:");
int numToCheckMultiplicity = int.Parse(Console.ReadLine()!);

string CheckMultiplicity(int number)
{
    if (number % 7 == 0 && number % 23 == 0 && number != 0)
    {
        return "Yes, the number is a multiple 7 and 23";
    }
    else
    {
        return "No, the number is not a multiple 7 and 23";
    }
}

string checkMultiplicity = CheckMultiplicity(numToCheckMultiplicity);
Console.WriteLine(checkMultiplicity);