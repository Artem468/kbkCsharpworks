// Вариант 20 средний уровень

InsulatedWire cylinder = new InsulatedWire();

try
{
    Console.Write("Введите диаметр: ");
    cylinder.Diameter = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длину: ");
    cylinder.Height = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите удельный вес провода (металла): ");
    cylinder.SpecificWeight = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите толщину изоляции: ");
    cylinder.InsulationThickness = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите удельную толщину изоляции: ");
    cylinder.SpecificWeightInsulation = Convert.ToDouble(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine($"Вес провода: {cylinder.getWeightInsulatedWire():F2}");


public class Cylinder
{
    private double diameter;
    private double height;

    public Cylinder(double diameter, double height)
    {
        this.diameter = diameter;
        this.height = height;
    }
    
    public Cylinder()
    {
        this.diameter = 0;
        this.height = 0;
    }
    
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

class InsulatedWire : Cylinder
{
    private double specificWeight;
    private double insulationThickness;
    private double specificWeightInsulation;
    
    public InsulatedWire(double diameter, double height, double specificWeight, 
        double insulationThickness, double specificWeightInsulation) : base(diameter, height)
    {
        this.specificWeight = specificWeight;
        this.insulationThickness = insulationThickness;
        this.specificWeightInsulation = specificWeightInsulation;
    }
    
    public InsulatedWire()
    {
        this.specificWeight = 0;
        this.insulationThickness = 0;
        this.specificWeightInsulation = 0;
    }
    
    public double SpecificWeight
    {
        get { return specificWeight; }
        set
        {
            if (value >= 0) specificWeight = value;
            else specificWeight = 0;
        }
    }
    public double InsulationThickness
    {
        get { return insulationThickness; }
        set
        {
            if (value >= 0) insulationThickness = value;
            else insulationThickness = 0;
        }
    }
    public double SpecificWeightInsulation
    {
        get { return specificWeightInsulation; }
        set
        {
            if (value >= 0) specificWeightInsulation = value;
            else specificWeightInsulation = 0;
        }
    }
    public double getWeightInsulatedWire()
    {
        // Формулы брал с интернета, не знаю на сколько они правильные
        // Vwire это объем металлической части провода
        // Visolation это объем изоляции
        // Вес можно найти произведением объема и удельного веса
        double Vwire = Math.PI * (Math.Pow(base.Diameter - InsulationThickness, 2) / 4) * base.Height;
        double Visolation = ((Math.PI * Math.Pow(base.Diameter, 2) / 4) - Math.PI * ((base.Diameter - 2 * Math.Pow(InsulationThickness, 2)) / 4) * base.Height);
        return Vwire * SpecificWeight + Visolation * SpecificWeightInsulation;
    }
    
}