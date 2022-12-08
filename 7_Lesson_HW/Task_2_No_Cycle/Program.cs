// Задача 2: Напишите программу(без применения цикла), которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int Prompt(string message)
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

void LetsFindElement(int[,] array, int numberOfARow, int numberOfAColumn)
{
    if (numberOfARow <= array.GetLength(0))
    {
        if (numberOfAColumn <= array.GetLength(1))
        {
            Console.WriteLine($"The element you're looking is: {array[numberOfARow - 1, numberOfAColumn - 1]}");
        }
        else
        {
            Console.WriteLine($"The given position is beyond the array");
        }
    }
}

void Execute()
{
    int rowsQuantity = Prompt("Enter the number of rows: ");
    int columnsQuantity = Prompt("Enter the number of columns: ");
    int[,] matrix = CreateArray(rowsQuantity, columnsQuantity);
    PrintArray(matrix);

    int rowNumber = Prompt("Enter a row the element belongs: ");
    int columnNumber = Prompt("Enter a column the element belongs: ");
    LetsFindElement(matrix, rowNumber, columnNumber);
}
Execute();