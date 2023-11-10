Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] massive = new int[2 * n + 1, 2 * n + 1];

int x = n;
int y = n;

int direction = 0; // direction - нынешние направление (up - 0, left - 1, down - 2, right - 3)

int iterCount = 0;
int maxIterBeforeChangeDirection = 1;
int rowCount = 1;


for (int k = 0; k < massive.Length; k++)
{
    if (iterCount % maxIterBeforeChangeDirection == 0)
    {
        direction = (direction + 1) % 4;

        if (rowCount == 2)
        {
            rowCount = 0;
            maxIterBeforeChangeDirection++;
        }
        rowCount++;
    }
    massive[x, y] = k;
    switch (direction)
    {
        case 0: { y++; } break;
        case 1: { x--; } break;
        case 2: { y--; } break;
        case 3: { x++; } break;
    }
    iterCount++;
}


for (int q = 0; q < massive.GetLength(0); q++)
{
    for (int w = 0; w < massive.GetLength(1); w++)
    {
        Console.Write($"{massive[q, w],-3}");
    }
    Console.WriteLine();
}