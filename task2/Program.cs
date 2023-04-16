var n = Convert.ToInt32(Console.ReadLine());
var arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int min = 0;
int max = 0;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < arr[min])
    {
        min = i;
    }
    if (arr[i] > arr[max])
    {
        max = i;
    }
}


if (min < max)
{
    for (int i = min; i <= max; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
else
{
    for (int i = max; i <= min; i++)
    {
        Console.Write(arr[i] + " ");
    }
}








