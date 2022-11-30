// * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int Prompt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int SumMaxRows (int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int maxValue = matr[i,j];
            if (maxValue < matr[i+1,j])
            {
                maxValue = matr[i+1,j];
            }
            sum =+ maxValue;
        }
    }
    return sum;
}

int rows = Prompt("Enter the quantity of rows in your matrix: ");
int columns = Prompt("Enter the quantity of columns in your matrix: ");

int[,] matrix = new int [rows, columns];
FillArray(matrix);
PrintArray(matrix);
int sumRows = SumMaxRows(matrix);

Console.WriteLine(sumRows);

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
