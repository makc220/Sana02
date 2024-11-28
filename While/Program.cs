
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть натуральне число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a = {CalculateA(n)}");
Console.WriteLine($"b = {CalculateB(n)}");
Console.WriteLine($"c = {CalculateC(n)}");

static double CalculateA(int n)
{
    double result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += Math.Pow(-1, i) / (2 * i + 1);
    }
    return result;
}

static double CalculateB(int n)
{
    double result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += 1 + 1.0 / (i * i);
    }
    return result;
}

static long CalculateC(int n)
{
    long result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += Factorial(i);
    }
    return result;
}

static long Factorial(int number)
{
    long fact = 1;
    for (int i = 2; i <= number; i++)
    {
        fact *= i;
    }
    return fact;
}