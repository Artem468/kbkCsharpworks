// 20 вариант

Meeting meet = new Meeting();
try
{
    Console.Write("Введите название события: ");
    meet.Name = Console.ReadLine();
    Console.Write("Введите количество ораторов: ");
    meet.NumberSpeakers = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите количество участников: ");
    meet.NumberParticipants = Convert.ToDouble(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine($"Событие: {meet.Name} | Q = {meet.Q():F2}");


ChildMeeting childMeet = new ChildMeeting();
try
{
    Console.Write("Введите название события: ");
    childMeet.Name = Console.ReadLine();
    Console.Write("Введите количество ораторов: ");
    childMeet.NumberSpeakers = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите количество участников: ");
    childMeet.NumberParticipants = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число групп ораторов которые высказывали одинаковые мысли: ");
    childMeet.P = Convert.ToDouble(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine($"Событие: {childMeet.Name} | Q = {childMeet.Q():F2}");

public class Meeting
{
    public string? Name { get; set; }
    public double NumberSpeakers { get; set; }
    public double NumberParticipants { get; set; }

    public Meeting(string? name, double numberSpeakers, double numberParticipants)
    {
        Name = name;
        NumberSpeakers = numberSpeakers;
        NumberParticipants = numberParticipants;
    }

    public Meeting()
    {
        Name = "";
        NumberSpeakers = 0;
        NumberParticipants = 0;
    }

    public double Q()
    {
        return NumberSpeakers / NumberParticipants;
    }
}

public class ChildMeeting : Meeting
{
    public double P { get; set; }

    public ChildMeeting(string? name, double numberSpeakers, double numberParticipants, double p)
        : base(name, numberSpeakers, numberParticipants)
    {
        P = p;
    }

    public ChildMeeting()
    {
        P = 0;
    }


    public new double Q()
    {
        return base.Q() + P / NumberParticipants;
    }
}
