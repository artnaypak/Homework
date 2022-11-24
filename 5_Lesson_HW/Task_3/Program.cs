// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int length, int min, int max)
{
    double[] tempArray = new double[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(min, max) + new Random().NextDouble();
    }
    return tempArray;
}

void PrintArray(double[] intArray)
{
    System.Console.Write($"{intArray[0]:f2}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]:f2}");
    }
}

double MinElement(double[] array)
{
    double minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double MaxElement(double[] array)
{
    double maxElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double NumbersDiference(double max, double min)
{
    double result = max - min;
    return result;
}



double[] array = CreateArray(15, -3, 38);
double minArray = MinElement(array);
double maxArray = MaxElement(array);
double result = NumbersDiference(maxArray, minArray);

System.Console.WriteLine($"The difference beetween the maximum element ({maxArray:f2}) and the minimum element ({minArray:f2}) of the following array is: {result:f2}");
PrintArray(array);


