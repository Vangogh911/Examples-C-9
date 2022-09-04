// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
 
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

void NatNumber (int min, int max)
{
    if (max == min)
    {
        Console.Write($"{max}, ");
        return;
    }
    if (max > min)
    {
        NatNumber(min, max - 1);
        Console.Write($"{max}, ");
    }
    else
    {
        Console.Write($"{min}, ");
        NatNumber(min - 1, max);
    }
}

NatNumber(1, 5);
Console.WriteLine();
NatNumber(4, 8);
Console.WriteLine();
NatNumber(5, 1);
Console.WriteLine();
NatNumber(8, 4);
