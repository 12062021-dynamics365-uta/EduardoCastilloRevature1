// Day of the Programmer solution  https://www.hackerrank.com/challenges/day-of-the-programmer/submissions/code/247587977

static string dayOfProgrammer(int year)
{
    string date;
    // Julian calendar
    if (year < 1918)
    {
        if (year % 4 == 0) //leap year
            date = "12.09." + year;
        else
            date = "13.09." + year;
    }
    //Gregorian calendar
    else if (year > 1918)
    {
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) //leap year
            date = "12.09." + year;
        else
            date = "13.09." + year;
    }
    else
    {
        date = "26.09.1918";
    }
    return date;
}