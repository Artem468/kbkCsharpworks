Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
double[] massive = new double[count];

for (int j = 0; j < count; j++)
{
    Console.Write("Введите число: ");
    massive[j] = Convert.ToInt32(Console.ReadLine());
}

int i = 1;
double denominator = 0;

bool flag = true;

while (i < massive.Length)
{
    if (massive[i] / massive[i - 1] != denominator && denominator != 0)
    {
        Console.WriteLine("Не является геометрической последовательностью!");
        flag = false;
        break;
    }
    else { denominator = massive[i] / massive[i - 1]; }
    i++;
} 

if (flag) { Console.WriteLine($"Является геометрической последовательнотью с знаменателем {denominator}"); }