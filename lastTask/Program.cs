﻿/*
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