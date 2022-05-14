// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое целое число");
int num = int.Parse(Console.ReadLine());
if (num / 100 >= 1 || num / 100 <= -1 )
{
    Console.WriteLine($"{num}-> {Math.Abs(num% 1000)/100}");
}
else
{
    Console.WriteLine($"{num}-> третьей цифры нет");
}

// Второй вариант написания:
Console.WriteLine( num / 100 >= 1 || num / 100 <= -1 ? $"{num}-> {Math.Abs(num % 1000)/100}" : $"{num}-> третьей цифры нет");
