// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt (string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("enter a five-digit number: ");
if (number >= 100000 || number < 10000)
{
    System.Console.WriteLine("Are you sure you've enterd a five-digit number?");
}
else
{
    int temp = number;
    int rev = 0;
    while (number > 0)
    {
        int dig = number % 10;
        rev = rev * 10 + dig;
        number = number / 10;
    }
    if(temp == rev)
    {
        System.Console.WriteLine("that's a palindrome");
    }
    else
    {
        System.Console.WriteLine("that's not a palindrome");
    }
}
