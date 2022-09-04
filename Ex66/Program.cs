// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber (int m, int n)
{
    int max = m;
    int min = n;

    if (m < n)
    {
        max = n;
        min = m;
    }

    int sum = max;
    if (max == min) return sum;
    sum += SumNumber(min, max - 1);
    return sum;
}

int summa = SumNumber(1, 15);
Console.WriteLine(summa);
summa = SumNumber(4, 8);
Console.WriteLine(summa);
summa = SumNumber(15, 1);
Console.WriteLine(summa);
summa = SumNumber(8, 4);
Console.WriteLine(summa);
