// Задача 1: Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

int PromptInt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());   
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i, 0]:f2}");
        for (int j = 1; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]:f2}");
        }
        System.Console.WriteLine("");
    }
}

double[,] FillArray(int m, int n)
{
    double[,] array = new double [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next (1, 11) + new Random().NextDouble();
        }
    }
    return array;
}

void Execute()
{
    int sizeM = PromptInt("Enter the quantity of rows: ");
    int sizeN = PromptInt("Enter the quantity of columns: ");
    double[,] tempArray = FillArray(sizeM, sizeN);
    PrintArray(tempArray);
}

Execute();