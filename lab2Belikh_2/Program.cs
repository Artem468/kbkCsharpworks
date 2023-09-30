// Высокий уровень 21

Console.Write("Введите число от 1 до 31: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 31)
{
    int nextNewmoon = (27 + 28) % 31;

    Console.WriteLine(day <= 27 ? "27 августа" : $"{nextNewmoon} сентября");
}
else
{
    Console.WriteLine("Число не входит в допустимый диапозон");
}