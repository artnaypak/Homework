// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
System.Console.Write(message);
return int.Parse(Console.ReadLine());
}
int x1 = Prompt("enter the coordinate X of a point A: ");
int y1 = Prompt("enter the coordinate Y of a point A: ");
int w1 = Prompt("enter the coordinate W of a point A: ");

int x2 = Prompt("enter the coordinate X of a point B: ");
int y2 = Prompt("enter the coordinate Y of a point B: ");
int w2 = Prompt("enter the coordinate W of a point B: ");

int x = x1 - x2;
int y = y1 - y2;
int w = w1 - w2;
double distance = Math.Sqrt(x * x + y * y + w * w);
System.Console.WriteLine($"{distance:f2}");