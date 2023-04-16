public class Calculator
{
    public long Factorial(long n)
    {
        long result = 1;
        for (long i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public double Multiple(double a, double b)
    {
        return a * b;
    }

    public double Division(int a, int b)
    {

        return (double)a / (double)b;
    }
}


