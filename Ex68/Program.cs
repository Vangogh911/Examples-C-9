// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

int Ackermann (int m, int n)
{
    if (m == 0) return n += 1;

    if (m > 0 && n == 0)
    {
        n = Ackermann(m - 1, 1);
    }
    else
    {
        if (m > 0 && n > 0)
        {
            n = Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    return n;
}

int result = Ackermann(3, 2);
Console.WriteLine(result);
