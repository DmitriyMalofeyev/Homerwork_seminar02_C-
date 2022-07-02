// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Введите трехзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int secondnumber = (numberA  / 10) % 10;
Console.WriteLine ("Вторая цифра в нем " + secondnumber);
*/


int method1 (int start, int finish)
{
    int numberA = new Random().Next(start, finish);
    Console.WriteLine ("Выбрано число " + numberA);
    int secondnumber = numberA  / 10 % 10;
    int result = secondnumber;
    return result;
}



int A = method1 (100, 999);
Console.WriteLine ("Вторая цифра в нем " + A);
