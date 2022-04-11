void NumberMultipleThree(int a, int b)
{
    if (a > b) return;
    if (a % 3 == 0) Console.Write($"{a,-5}");
    NumberMultipleThree(a + 1, b);
}

Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

NumberMultipleThree(m, n);