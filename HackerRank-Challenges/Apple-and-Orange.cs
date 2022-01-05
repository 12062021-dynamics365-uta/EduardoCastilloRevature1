//Apple and Orange solution https://www.hackerrank.com/challenges/apple-and-orange/submissions/code/246637974

static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
    int appleNumber = 0;
    int orangeNumber = 0;
    for (int i = 0; i < apples.Count; i++)
    {
        if ((a + apples[i]) >= s && (a + apples[i]) <= t)// if apple fall into the s - t range
        {
            appleNumber++;//number of apple fall on house
        }

    }
    for (int i = 0; i < oranges.Count; i++)
    {
        if ((b + oranges[i]) >= s && (b + oranges[i]) <= t)// if orange fall into the s - t range
        {
            orangeNumber++;//number of orange fall on house
        }
    }
    Console.WriteLine(appleNumber);
    Console.WriteLine(orangeNumber);
}