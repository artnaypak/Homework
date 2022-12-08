// Задача 2: Напишите программу(без применения цикла), которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


int Prompt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int m, int n)
{
    int[,] table = new int[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 9);
        }
    }
    return table;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement (int[,] array, int a, int b)
{
    for (int i = a; i <= array.GetLength(0); i++)
    {
        for (int j = b; j <= array.GetLength(1); j++)
        {
            Console.WriteLine($"the element is: {array[a,b]} ");
            return;
            
        }
    }
    Console.WriteLine($"The given position is beyond the array");
}

void Execute()
{
int intR = Prompt("Enter the number of a row: ");
int intC = Prompt("Enter the number of a column: ");
int [,] matrix = CreateArray(7, 5);
PrintArray(matrix);
FindElement(matrix, intR - 1, intC - 1);
}
Execute();