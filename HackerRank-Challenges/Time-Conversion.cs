//Time Conversion solution https://www.hackerrank.com/challenges/one-month-preparation-kit-time-conversion/submissions/code/247509792

static string timeConversion(string s)
{
    int y = Convert.ToInt32(s.Remove(2));
    //If is AM just remove the 'AM' expresion
    if (s.Contains('A'))
    {
        if (y == 12)// case 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock
        {
            s = s.Remove(0, 2);
            string result = "00" + s;
            s = result.Remove(8);
        }
        else
            s = s.Remove(8);
    }
    else //case PM, remove the 'PM' expresion and add 12
    {
        if (y != 12)
        {
            s = s.Remove(0, 2);
            y = y + 12;
            s = Convert.ToString(y) + s;
        }
        s = s.Remove(8);
    }
    return s;
}
