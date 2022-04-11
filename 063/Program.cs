int startNumber = 1;
int lastNumber = 15;

// Рекурсия заменяет цикл
// for (int i = 0; i < 16; i++)
// {
//     RecursivePrint(startNumber + i, lastNumber);
// }

RecursivePrint(startNumber, lastNumber);

void RecursivePrint(int m, int n)
{
    if (n + 1 == m)
    {
        Console.Write("End");
        return;
    }
    Console.Write(m + " ");
    RecursivePrint(m + 1, n);
}
