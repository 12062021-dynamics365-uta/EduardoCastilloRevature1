// Angry Professor solution https://www.hackerrank.com/challenges/angry-professor/submissions/code/248138931

static string angryProfessor(int k, List<int> a)
{
    int count = 0;

    //Count all student that arrive in time
    for (int i = 0; i < a.Count(); i++)
    {
        if (a[i] <= 0)
            count++;
    }


    if (count >= k)
        return "NO";
    else
        return "YES";
}