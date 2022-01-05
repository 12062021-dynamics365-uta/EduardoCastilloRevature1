//Grading Students solution https://www.hackerrank.com/challenges/grading/submissions/code/246458489

static List<int> gradingStudents(List<int> grades)
{
    int x = 0;
    for (int i = 0; i < grades.Count; i++)
    {
        int y = 0;
        // If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
        if (grades[i] >= 38)//
        {
            x = 1;
            y = grades[i];
            while (x % 5 != 0)//looking for the next nultiple of 5
            {
                x = y + 1;
                y++;
            }

            if (x - grades[i] < 3)
            {
                grades[i] = x;
            }
        }
    }
    return grades;
}




