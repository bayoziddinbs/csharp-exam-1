int FindMinimum(int a, int b, int c, int d)
{
    int min = a;

    if (b < min) min = b;
    if (c < min) min = c;
    if (d < min) min = d;

    return min;
}


int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());
int c = Convert.ToInt16(Console.ReadLine());
int d = Convert.ToInt16(Console.ReadLine());

int min = FindMinimum(a, b, c, d);

Console.WriteLine("The minimum is: " + min);
