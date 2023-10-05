// Средний уровень № 17

Console.Write("Введите число от 1 до 3: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());


switch (n)
{
    case 1:
    {
        double a = -1.2, b = 0.75, z = Math.Log(Math.Abs(Math.Tan(b * x)));
        if (x <= a)
        {
            double y = a + Math.Sin(b * x) + Math.Cos(x * x);
            Console.WriteLine($"y = {y:F2}");
        }
        else if (a < x && x < Math.Log(b))
        {
            double y = Math.Sqrt(a + b * x) + Math.Sin(z * x); 
            Console.WriteLine($"y = {y:F2}");
        }
        else if (x >= Math.Log(b))
        {
            double y = Math.Log(a + b * x + z);
            Console.WriteLine($"y = {y:F2}");
        }
    } break;
    case 2:
    {
        double a = 0.4, b = 2.4, z = Math.Log(Math.Abs(Math.Tan(b * x)));
        if (x <= a)
        {
            double y = a + Math.Sin(b * x) + Math.Cos(x * x);
            Console.WriteLine($"y = {y:F2}");
        }
        else if (a < x && x < Math.Log(b))
        {
            double y = Math.Sqrt(a + b * x) + Math.Sin(z * x); 
            Console.WriteLine($"y = {y:F2}");
        }
        else if (x >= Math.Log(b))
        {
            double y = Math.Log(a + b * x + z);
            Console.WriteLine($"y = {y:F2}");
        }
    } break;
    case 3:
    {
        double a = 1.1, b = 6.1, z = Math.Log(Math.Abs(Math.Tan(b * x)));
        if (x <= a)
        {
            double y = a + Math.Sin(b * x) + Math.Cos(x * x);
            Console.WriteLine($"y = {y:F2}");
        }
        else if (a < x && x < Math.Log(b))
        {
            double y = Math.Sqrt(a + b * x) + Math.Sin(z * x); 
            Console.WriteLine($"y = {y:F2}");
        }
        else if (x >= Math.Log(b))
        {
            double y = Math.Log(a + b * x + z);
            Console.WriteLine($"y = {y:F2}");
        }
    } break;
    
    default: Console.WriteLine("Неизвестное значение!"); break;
}
