// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt (string message)
{
    Console.Write (message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Enter the element under the index {i}: ");
        tempArray[i] = int.Parse(Console.ReadLine());
    }
    return tempArray;
}


int PositiveElements (int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            count++;
        }
    }
    return count;
}


void ShowElements(int[] intArray)
{
    for (int i = 1; i < intArray.Length; i++)
    {
        if (intArray [i] > 0)
        {
            System.Console.Write($", {intArray[i]}");
        }
    }
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]} ");
    }
}

int length = Prompt("Enter the length of an array: ");
int[] userArray = CreateArray(length);

Console.Write($"The entered array is: ");
PrintArray(userArray);
Console.WriteLine();
Console.Write($"There're {PositiveElements(userArray)} positive elements in the entered array and they're: ");
ShowElements(userArray);