// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt (string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int threeDigit = Prompt("Please, enter three-digit number: ");
if (threeDigit < 100 || threeDigit >= 1000)
{
    Console.WriteLine("Nope, you should enter three-digit number");
}
else
{
    int twoDigit = threeDigit / 10;
    int secondDigit = twoDigit % 10;
    Console.WriteLine($"the second digit is {secondDigit}");
}
