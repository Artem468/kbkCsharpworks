// Вариант 8 Средний уровень
try
{
    Console.Write("Введите количество поездов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите начальное время (в формате дд-мм-гггг чч:мм:сс): ");
    DateTime dateStart = DateTime.Parse(Console.ReadLine());
    Console.Write("Введите конечное время (в формате дд-мм-гггг чч:мм:сс): ");
    DateTime dateEnd = DateTime.Parse(Console.ReadLine());


    trainSchedule[] trainsGroup = new trainSchedule[n];
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        trainsGroup[i] = new trainSchedule();
        Console.Write("Введите номер поезда: ");
        trainsGroup[i].trainNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите станцию отправления: ");
        trainsGroup[i].departureStation = Console.ReadLine();
        Console.Write("Введите время отправления (в формате дд-мм-гггг чч:мм:сс): ");
        trainsGroup[i].departureTime = DateTime.Parse(Console.ReadLine());
        Console.Write("Введите станцию прибытия: ");
        trainsGroup[i].arrivalStation = Console.ReadLine();
        Console.Write("Введите время прибытия (в формате дд-мм-гггг чч:мм:сс): ");
        trainsGroup[i].arrivalTime = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();
    }


Console.WriteLine("Поезда с временем в пути");
foreach (trainSchedule item in trainsGroup)
{
    Console.WriteLine($"Номер поезда: {item.trainNumber}");
    Console.WriteLine($"Станция отправления: {item.departureStation}");
    Console.WriteLine($"Станция прибытия: {item.arrivalStation}");
    Console.WriteLine($"Время отправления: {item.departureTime}");
    Console.WriteLine($"Время прибытия: {item.arrivalTime}");
    Console.WriteLine($"Время в пути: {item.arrivalTime - item.departureTime}");
    Console.WriteLine();
}

Console.WriteLine("Поезда выехавшие из Киева в веденном интервале");
foreach (trainSchedule item in trainsGroup)
{
    if (item.departureStation == "Киев" && dateStart < item.departureTime && dateEnd > item.arrivalTime)
    {
        Console.WriteLine($"Номер поезда: {item.trainNumber}");
        Console.WriteLine($"Станция отправления: {item.departureStation}");
        Console.WriteLine($"Станция прибытия: {item.arrivalStation}");
        Console.WriteLine($"Время отправления: {item.departureTime}");
        Console.WriteLine($"Время прибытия: {item.arrivalTime}");
        Console.WriteLine();
    }
}
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

struct trainSchedule {
    public int trainNumber;
    public string departureStation;
    public DateTime departureTime;
    public string arrivalStation;
    public DateTime arrivalTime;
};
