// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)


int Prompt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] GenerateArray (int length, int min, int max)
{
    int [] tempArray = new int [length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    } 
    return tempArray;
} 

int lengthArray = Prompt("Enter the length of an array: ");
int minArray = Prompt("Enter the minimum element of an array: ");
int maxArray = Prompt("Enter the maximum element of an array: ");
int [] array = GenerateArray(lengthArray, minArray, maxArray);

void PrintArray (int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 0; i < intArray.Length; i++)
    {   
        Console.Write($", {intArray[i]}");
    }
}

Console.Write("According to the numbers you've entered the array is: ");
PrintArray(array);




