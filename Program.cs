﻿//написать программу, которая из имеющегося массива строк сформирует массив строк, длина которых не привышает 3
Console.WriteLine("Введите элементы массива строк: ");
string[] st = new string[5];
for (int i =0; i<5; i++)
{
    st[i] = Console.ReadLine();
}
string[] st1 = new string[5];
int j = 0;
for (int i=0; i<5; i++)
{
    if (st[i].Length  <= 3)
    {
        st1[j] = st[i];
        j++;
    }
}
for (int i=0; i<st1.Length; i++)
{
    Console.WriteLine(st1[i]);
}
