// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverage (int[,] array)
{
    int j = 0; 
    while (j < array.GetLength(1))
    {
        double sum = 0; 
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        average = sum / array.GetLength(0);
        Console.WriteLine($"Arithmetic mean of the column #{j+1} is {average}");
        j++;
    }
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

void Execute()
{
    int rowsQuantity = Prompt("Enter the number of rows: ");
    int columnsQuantity = Prompt("Enter the number of columns: ");
    int[,] matrix = CreateArray(rowsQuantity, columnsQuantity);
    PrintArray(matrix);

    FindAverage(matrix);
}

Execute();
