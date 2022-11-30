// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите трёхзначное число: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());
if (DayOfWeek == 6 || DayOfWeek == 7)
{
    Console.WriteLine("Да, день выходной");
}
else
{
    if (DayOfWeek < 6 && DayOfWeek > 0)
    {
        Console.WriteLine("Нет, это будний день");
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число!");
    }
}