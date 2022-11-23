    // Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumNumbers (int number)
{
    
    int count = Convert.ToString(number).Length;
    int sum = 0;
    for(int i = 0; i < count; i++)
    {
        int lastNumber = number % 10;
        sum = sum + lastNumber;
        number = number / 10;
    }
    return sum;
}
int numberN = Prompt("Enter the number: ");
int sum = SumNumbers(numberN);
Console.WriteLine($"The sum of the digits of the given number {numberN} equals: {sum}");
