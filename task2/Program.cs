//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
int sum(int m, int n)
{
if (m==n)
return n;
else return m + sum(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {sum(m,n)}");