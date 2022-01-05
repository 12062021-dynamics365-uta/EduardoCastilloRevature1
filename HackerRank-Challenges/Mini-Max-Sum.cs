//Mini-Max Sum solution https://www.hackerrank.com/challenges/mini-max-sum/submissions/code/246332488

static void miniMaxSum(List<int> arr)
{
    long max = arr[0];
    long min = long.MaxValue;
    long sum = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        for (int j = 0; j < arr.Count; j++)
        {
            if (i != j)
            {
                sum = sum + arr[j];

            }
        }
        if (sum > max)
            max = sum;
        if (sum < min)
            min = sum;
        sum = 0;
    }
    Console.WriteLine(min + " " + max);
}