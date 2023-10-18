try
{
    Console.Write("Введите x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите n: ");
    double n = Convert.ToDouble(Console.ReadLine());

    double Q = 0;

    for (int k = 1; k <= n; k++)
    {
        double Kfactorial = 1;
        for (int i = 1; i <= k; i++)
        {
            Kfactorial *= i;
        }
        Q += (Math.Pow(-1, k) * Math.Pow((x + 3), 2)) / Kfactorial;
    }

    Console.WriteLine($"Q = {Q:F2}");
}
catch (Exception err)
{
    Console.WriteLine($"Возникла ошибка: {err}");
}