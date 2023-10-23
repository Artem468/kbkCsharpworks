for (double x = -1; x <= 1; x += 0.25)
{
    double u = x * x - Math.Asin(x * x);
    if (x > Math.PI)
    {
        double output = Math.Pow(u, Math.Abs(Math.Cos(x)));
        Console.WriteLine($"{x, 5} | {output:F2}");
    }
    else if (x <= Math.PI)
    {
        double output = Math.Pow(u, Math.Sin(x));
        Console.WriteLine($"{x, 5} | {output:F2}");
    }
}