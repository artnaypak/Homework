// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int random = new Random().Next(99, 1000);

int twoDigit = random / 10;
int secondDigit = twoDigit % 10;
int firstDigit = random / 100;
int thirdDigit = random % 10;

Console.Write(firstDigit);
Console.Write(thirdDigit);

