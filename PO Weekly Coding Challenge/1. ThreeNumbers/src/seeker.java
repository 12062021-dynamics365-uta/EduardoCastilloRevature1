public class seeker {
    
    public static int FindSecondMaximum(int[] triples){
       
        int max = -1;
        int secondMax = -1;

        for(int i=0; i < triples.length; i++)
        {
            if(triples[i] > max)
            {
                secondMax = max;
                max = triples[i];
            }
            else if(triples[i] > secondMax)
            {
               secondMax = triples[i];
            }
        }
        return secondMax;
    }
}
