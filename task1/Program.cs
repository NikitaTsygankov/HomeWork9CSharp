﻿//Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1. 
//Выполнить с помощью рекурсии.


void PrintNum(int m, int n)
{
    
if (n>=m)
{
    PrintNum(m+1, n);
    Console.Write(m+ " ");
}
}
PrintNum(1, 13);
