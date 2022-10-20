// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    System.Console.Write("max = " + a);
    System.Console.Write(", min = " + b);
}
else 
{
    System.Console.Write("max = " + b);
    System.Console.Write(", min = " + a);
}









