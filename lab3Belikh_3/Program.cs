// Вариант 11
try
{
    Console.Write("Введите x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double S = 1;

    for (int i = 1; i <= n; i++)
    {
        long factorial = 1;
        for (int j = 1; j <= i; j++)
        {
            factorial *= j;
        }

        S += 2 * i + 1 * Math.Pow(x, i * 2) / factorial;
    }

    Console.WriteLine($"S = {S:F2}");
}
catch (Exception err)
{
    Console.WriteLine(err);
}
