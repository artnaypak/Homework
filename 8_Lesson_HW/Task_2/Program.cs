// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Prompt(string message)
{
    Console.Write(message);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int SumOfElemetnsInRow(int[,] array, int i)
{
    int rowSum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    return rowSum;
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

void ShowTheResult(int[,] array)
{
    int ElementsMinSum = 0;
    int sumOfElements = SumOfElemetnsInRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = SumOfElemetnsInRow(array, i);
        if (sumOfElements > tempSum)
        {
            sumOfElements = tempSum;
            ElementsMinSum = i;
        }
    }
    Console.Write($"The sum of elements in the row №{ElementsMinSum + 1} is the lowest ({sumOfElements})");
}

void Execute()
{
    int rowsQuantity = Prompt("Type the quantity of rows: ");
    int columnsQuantity = Prompt("Type the quantity of columns: ");
    int[,] matrix = CreateArray(rowsQuantity, columnsQuantity);
    PrintArray(matrix);
    ShowTheResult(matrix);
}

Execute();