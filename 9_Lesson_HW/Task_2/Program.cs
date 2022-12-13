// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

void ShowSumMinMax(int min, int max, int sum)
{
    sum += min;
    if (max <= min)
    {
        Console.WriteLine(sum);
        return;
    }
    ShowSumMinMax(min + 1, max, sum);
}

int min = 1;
int max = 100;
int sum = 0;
ShowSumMinMax(min, max, sum);