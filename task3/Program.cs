int n = Convert.ToInt32(Console.ReadLine());


int sum = 0;

for (int i = 0; i <= n; i++)
{
    sum += Convert.ToInt32(Math.Pow(2, i));
}

Console.WriteLine(sum);


