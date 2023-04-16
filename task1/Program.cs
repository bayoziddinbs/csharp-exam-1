var n = Convert.ToInt32(Console.ReadLine());
var arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}


int cnt = 0;
for (int i = 1; i < arr.Length; i++)
{

    if (arr[i] != arr[i - 1])
        cnt++;
}

Console.WriteLine($"Number of different numbers: {cnt}");
