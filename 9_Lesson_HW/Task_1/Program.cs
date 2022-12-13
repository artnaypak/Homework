// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void PrintEvenNumbersMN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.WriteLine(m);
    }
    PrintEvenNumbersMN(m + 1, n);
}

int m = 3;
int n = 16;
PrintEvenNumbersMN(m, n);
