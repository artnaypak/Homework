// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2
// x = (b2 - b1)/(k1 - k2)
// x = (b2-b1) / (k2-k1)  ___ y = k1 * ((b2-b1) / (k1-k2)) + b1  /  y = k1 * x + b1

double Prompt (string message)
{
    Console.WriteLine(message);
    return double.Parse(Console.ReadLine());
}

void CrossLines ()
{
    double b1 = Prompt("Enter the value b1 for the first direct line: ");
    double k1 = Prompt("Enter the value k1 for the first direct line: ");

    double b2 = Prompt("Enter the value b2 for the second direct line: ");
    double k2 = Prompt("Enter the value k2 for the second direct line: ");
    
    double x = (b2 - b1) / (k2 - k1);
    double y = (k1 * x + b1);
    if (k1 == k2)
    {
        Console.WriteLine("Lines are parallel");
    }
    else
    {
        Console.WriteLine($"The point of intersection: x = {x}, y = {y}");
    }
}

CrossLines();