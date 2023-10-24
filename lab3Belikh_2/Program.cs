// 7 вариант Высокий уровень
try
{
    Console.WriteLine("Введите числа");
    double number = Convert.ToDouble(Console.ReadLine());
    double sum = 0;
    while (number != 0)
    {
        if (number < 0)
        {
            sum += number;
        }

        number = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine($"Сумма отрицательных числел: {sum:F2}");
}
catch (Exception err)
{
    Console.WriteLine($"Ошибка: {err}");
}
