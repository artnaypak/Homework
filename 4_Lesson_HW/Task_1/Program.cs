// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Degree (int first, int second)
{
    int number = first;
    int count = 1;
    while (count < second)
    {
        first = first * number;
        count++;
    }
    return first;
}
int numberA = Prompt("Please, enter the first number: ");
int numberB = Prompt("Please, enter the second number: ");

int exponentiation = Degree(numberA, numberB);
Console.WriteLine($"The given number {numberA} raised to {numberB} equals: {exponentiation}");