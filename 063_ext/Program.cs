int number = 12;
Recursion(number);
void Recursion(int n)
{
    if (n == 0) return;
    Console.WriteLine(n);
    Recursion(n - 1);
}
