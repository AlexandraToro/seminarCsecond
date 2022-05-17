// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
    num = num * (-1);
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры в заданном числе нет");
}
else
{
    int i = 10;
    while (num / i >= 10)
    {
        i = i * 10;
    }
    int icor1 = i / 100;
    int icor2 = i / 10;
    int numThird = num / icor1 - (num / icor2) * 10;
    Console.WriteLine($"Третья цифра в заданном числе равна {numThird}");
}
