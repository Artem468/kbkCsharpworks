// Вариант 20 средний уровень

Cylinder cylinder = new Cylinder();

Console.Write("Введите диаметр: ");
cylinder.Diameter = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите высоту: ");
cylinder.Height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Диаметр: {cylinder.Diameter}");
Console.WriteLine($"Высота: {cylinder.Height}");
Console.WriteLine($"Объём: {cylinder.getVolume()}");

public class Cylinder
{
    private double diameter;
    private double height;
    
    public double Diameter
    {
        get { return diameter; }
        set
        {
            if (value >= 0) diameter = value;
            else diameter = 0;
        }
    }
    
    public double Height
    {
        get { return height; }
        set
        {
            if (value >= 0) height = value;
            else height = 0;
        }
    }

    public double getVolume()
    {
        return Math.PI * Math.Pow(diameter / 2, 2) * height;
    }
    
}