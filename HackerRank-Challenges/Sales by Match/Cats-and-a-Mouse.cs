//Cats and a Mouse Solution https://www.hackerrank.com/challenges/cats-and-a-mouse/submissions/code/247295750

static string catAndMouse(int x, int y, int z)
{
    // x: Cat A     y: Cat B     z: Mouse

    //Finding the distance of each cat from the mouse
    int distanceCatA = 0;
    int distanceCatB = 0;
    //For CatA
    if (x > z)
        distanceCatA = x - z;
    else
        distanceCatA = z - x;
    //For CatB
    if (y > z)
        distanceCatB = y - z;
    else
        distanceCatB = z - y;


    //Comparing the distances
    if (distanceCatA == distanceCatB)
        return "Mouse C";
    else
    {
        if (distanceCatA < distanceCatB)
            return "Cat A";
        else
            return "Cat B";
    }
}