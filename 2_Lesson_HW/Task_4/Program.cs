// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int enter = Prompt("Enter a digit that refers to a day of the week: ");

if ((enter >=1) && (enter <= 5))
{
    System.Console.WriteLine("Sorry, it's weekday, go back to work");
}

if ((enter > 5) && (enter < 7))
{
    Console.WriteLine("Great news, it's weekend, enjoy");
}
else
{
    System.Console.WriteLine($"What day of the week does {enter} suppose to mean?");
}







