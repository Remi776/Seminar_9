int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RecursionSum(number));

int RecursionSum(int n)
{
    if (n == 0) return 0;
    return n % 10 + RecursionSum(n / 10);
}
