Console.WriteLine("Hello, User!");
int[] arr = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAvg(arr));
Console.WriteLine(GetMax(arr));

static double GetAvg(int[] arr)
{
    int s = 0;
    foreach (var x in arr)
    {
        s += x;
    }
    return (double)s / arr.Length;
}

static double GetMax(int[] arr)
{
    int max = 0;
    foreach (var num in arr)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}