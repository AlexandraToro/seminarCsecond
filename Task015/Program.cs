// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7 ");
int day = int.Parse(Console.ReadLine());
if (day > 0 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"{day}->да");
    }
    else
    {
        Console.WriteLine($"{day}-> нет");
    }
}
else
{
    Console.WriteLine("Ошибка. Введено некорректное значение. Перезапустите программу.");
}


// Дополнительно - попытка прописать через метод - буду рада обратной связи.

string res = WeekEnd(day);
Console.WriteLine(res);

string WeekEnd(int number)
{
    if (number > 0 && number <= 7)
    {
        return number == 6 || number == 7 ? $"{day}->да" : $"{day}-> нет";
    }
    else 
    {
        return "Ошибка: введено некорректное значение. Перезапустите программу.";
    }
}