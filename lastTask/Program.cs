/*
Написать программу,которая из имеющегося массива строк,формирует массив из строк длина
которых меньше,либо равна 3 символа.
*/
int SearchStringsLessThan3Simbols(string[] start, int n)
{
    int count = 0;

    for (int i = 0; i < start.Length; i++)
    {
        if (start[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}
string[] ReplacingSimbols(string[] start, int n)
{
    string[] finish = new string[SearchStringsLessThan3Simbols(start, n)];

    for (int i = 0, j = 0; i < start.Length; i++)
    {
        if (start[i].Length <= n)
        {
            finish[j] = start[i];
            j++;
        }
    }

    return finish;
}
string[] PrintArray()
{
    Console.Write("Введите строки через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] array = PrintArray();
string[] result = ReplacingSimbols(array, 3);
Console.WriteLine($"Вы задали массив из строк: [{string.Join(", ", array)}]");
Console.WriteLine($"Вот строки длинной до 3х символов из вашего массива: [{string.Join(", ", result)}]");