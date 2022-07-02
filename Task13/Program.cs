// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void thirdnumber(int x)
{
    int div = 1;
    while (x / div >= 10)
    {
        div *= 10;
    }
    if (div < 100)
    {
        Console.WriteLine ("Выбрано слишком короткое число");
    }
    else
    {
        int digit = (x / (div/100)) % 10;
        Console.WriteLine("Третья цифра {0}", digit);
    }
}


Console.WriteLine("Введите целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
thirdnumber(numberA);




