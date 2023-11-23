try
{
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] massive = new int[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите число: ");
        massive[i] = Convert.ToInt32(Console.ReadLine());
    }

    int nod = -1;
    for (int i = 1; i < massive.Length; i++)
    {
        if (nod == -1)
        {
            nod = GetNod(massive[i - 1], massive[i]);
        }
        else
        {
            nod = GetNod(nod, massive[i]);
        }
    }
    Console.WriteLine($"NOD = {nod}");
    
}
catch (Exception err){
    Console.WriteLine(err.Message);
}

int GetNod(int a, int b)
{
    for (int i = Math.Min(a, b); i > 0 ; i--)
    {
        if (a % i == 0 && b % i == 0)
        {
            return i;
        }
    }

    return -1;
}