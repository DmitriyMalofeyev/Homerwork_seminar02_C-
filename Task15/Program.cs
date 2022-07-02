// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (num-1 == 6 ^ num-1 == 5)
{
    Console.WriteLine(weekDays[num-1] + " это выходной");
}
else
{
    Console.WriteLine (weekDays[num-1] + " это не выходной");
}
