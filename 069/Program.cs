int n = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RecursionPow(n, p));

int RecursionPow(int number, int power)
{
    if (power == 1) return number;
    return number * RecursionPow(number, --power);
}