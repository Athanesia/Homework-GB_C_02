//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трёхзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 1000 && digit > 99)
    Console.WriteLine(digit % 100 / 10);
else
    Console.WriteLine("Недопустимое число");