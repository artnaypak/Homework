// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6


int Prompt (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber (int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("The given number doesn't include the third digit");
        return false;
    }
    return true;
}


int anynumber = Prompt("Enter any number you wish: ");
int anynumber1 = anynumber; 
if (ValidateNumber(anynumber))
{
    while (anynumber1 > 1000)
    {
        anynumber1 = anynumber1 / 10;
    }
    int thirdDigit = anynumber1 % 10;
    Console.WriteLine($"The third digit of the given number is: {thirdDigit}");
}
