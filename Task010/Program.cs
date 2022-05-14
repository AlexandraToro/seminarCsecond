// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int res = num / 10 % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Ошибка: введено некорректное значение.");
}



// Дополнительно - для тренировки попытка прописать через метод - буду рада обратной связи.
if (num > 99 && num < 1000)
{
    int secNumber = FindSecNumb(num);
    Console.WriteLine(secNumber);
}
else
{
    Console.WriteLine("Ошибка: введено некорректное значение.");
}

int FindSecNumb(int number)
{
    return number / 10 % 10;
}