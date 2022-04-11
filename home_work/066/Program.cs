int NumberSum(int a, int b)
{
    if (a > b) return 0;
    return a + NumberSum(a + 1, b);
}

Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum = " + NumberSum(m, n));