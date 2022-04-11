int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Recursion(m, n);
void Recursion(int m, int n)
{
    if (n == m - 1) return;
    Console.Write($"{n} ");
    Recursion(m, n - 1);
}
