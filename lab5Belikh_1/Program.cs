// Высокий уровень сложности. Задача № 9
Console.Write("Введите текст: ");
char[] massive = Console.ReadLine().ToCharArray();


// Узнаем количество слов
int wordsCount = 0;

for (int i = 0; i < massive.Length; i++)
{
    if (char.IsWhiteSpace(massive[i]) || i == 0)
    {
        wordsCount++;
    }
}

//  Узнаем индексы начала слов 
int [] startIndexWords = new int[wordsCount];

int indexNow = 0;
for (int j = 0; j < massive.Length; j++)
{
    if (char.IsWhiteSpace(massive[j]))
    {
        startIndexWords[indexNow] = j + 1;
        indexNow++;
    }
    else if (j == 0)
    {
        startIndexWords[indexNow] = j;
        indexNow++;
    }
}

// Меняем местами четные и не четные индескы
for (int k = 0; k < startIndexWords.Length; k++)
{
    if (k % 2 == 1) { (startIndexWords[k], startIndexWords[k - 1]) = (startIndexWords[k - 1], startIndexWords[k]); }
}

// Вывод на экран
foreach (int item in startIndexWords)
{
    // Console.WriteLine(massive[item]);
    int index = item;
    while (!char.IsWhiteSpace(massive[index]))
    {
        Console.Write($"{massive[index]}");
        index++;
        if (index == massive.Length) {break; }
    };
    Console.Write(" ");
}
