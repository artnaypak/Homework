// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
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


int[,] MultiplyingResult(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultArray.GetLength(1); k++)
            {
                sum += firstArray[i,k] * secondArray[k,j];
            }
            resultArray[i,j] = sum;
        }
    }
    return resultArray;
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
    int firstMatrixRows = Prompt("Enter the quantity of rows of the first matrix: ");
    int firstMatrixColsSecondMatrixRows = Prompt("Enter the quantity of the first matrix's columns" +
    " and the second matrix's rows: ");
    int secondMatrixCols = Prompt("Enter the quantity of columns of the second matrix: ");

    int[,] firstMatrix = CreateArray(firstMatrixRows, firstMatrixColsSecondMatrixRows);
    int[,] secondMatrix = CreateArray(firstMatrixColsSecondMatrixRows, secondMatrixCols);
    int[,] resultArray = MultiplyingResult(firstMatrix, secondMatrix);
    PrintArray(firstMatrix);
    PrintArray(secondMatrix);
    PrintArray(resultArray);
}
Execute();