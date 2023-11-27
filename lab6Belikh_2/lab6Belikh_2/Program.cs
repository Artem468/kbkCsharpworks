// Вариант 25 средний уровень
using Library;

try
{
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] massive = new double[n, m];

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= m; j++)
        {
            massive[i - 1, j - 1] = Math.Pow(Math.Pow(Math.Sin(i), 3) - Math.Pow(Math.Cos(j), 3), 3) +
                            3.1 * Math.Log(Math.Abs(i - 7 / j + 4) - 9);
        }
    }

    double result = Library.Matrix.GetMaxSquares(massive);
    Console.WriteLine($"{result:F2}");

}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}
