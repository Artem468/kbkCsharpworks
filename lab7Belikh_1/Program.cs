try
{
    Console.Write("Введите количество машин: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Car[] carsGroup = new Car[n];

    for (int i = 0; i < n; i++)
    {
        carsGroup[i] = new Car();
        Console.Write("Введите марку производителя: ");
        carsGroup[i].Brand = Console.ReadLine();
        Console.Write("Введите производителя: ");
        carsGroup[i].Maker = Console.ReadLine();
        Console.Write("Введите тип: ");
        carsGroup[i].Type = Console.ReadLine();
        Console.Write("Введите год выпуска: ");
        carsGroup[i].ReleaseYear = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите дату регистрации (в формате дд.мм.гггг): ");
        carsGroup[i].RegisterDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    Console.WriteLine("Машины выпущенные до 2005 и зарегистрированные в этом году");
    foreach (Car item in carsGroup)
    {
        if (item.ReleaseYear < 2005 && item.RegisterDate.Year == DateTime.Now.Year)
        {
            Console.WriteLine();
            Console.WriteLine($"Марка производителя: {item.Brand}");
            Console.WriteLine($"Производитель: {item.Maker}");
            Console.WriteLine($"Тип: {item.Type}");
            Console.WriteLine($"Год выпуска: {item.ReleaseYear}");
            Console.WriteLine($"Дата регистрации: {item.RegisterDate}");
        }
    }

}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

struct Car
{
    public string Brand;
    public string Maker;
    public string Type;
    public int ReleaseYear;
    public DateTime RegisterDate;
};