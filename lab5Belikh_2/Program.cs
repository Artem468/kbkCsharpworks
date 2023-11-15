// Высокий уровень сложности. Задача № 9

Console.Write("Введите строку: ");
string input = Console.ReadLine();
int count = 0;
foreach (string word in input.Split(' '))
{
    bool flag = true;
    foreach (char letter in word)
    {
        if ((!(letter >= 'а' && letter <= 'я') || letter == 'ё'))
        {
            flag = false;
        }
    }
    
    if (flag)
    {
        Console.WriteLine(word);
        count++;
    }
    flag = true;
}

Console.WriteLine($"Количество слов состоящих только из строчных русскоих букв: {count}");


// Более симпотичное решение с использованием регулярных выражений

// using System.Text.RegularExpressions;
//
// Console.Write("Введите строку: ");
// string input = Console.ReadLine();
//
// Regex regex = new Regex(@"\b[а-я]+\b");
//
// int count = regex.Matches(input).Count;
// Console.WriteLine($"Количество слов состоящих только из строчных русскоих букв: {count}");
