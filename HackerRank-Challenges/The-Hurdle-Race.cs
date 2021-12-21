//The Hurdle Race solution https://www.hackerrank.com/challenges/the-hurdle-race/submissions/code/247946734

static int hurdleRace(int k, List<int> height)
    {
        //height.Sort();
        //int maxHeight = height[height.Count-1];
        
        int maxHeight=0;
        for(int i=0; i<height.Count; i++)
        {
            if(height[i] > maxHeight)
            maxHeight = height[i];
        }
        
        if(k > maxHeight)
        return 0;
        else
        return maxHeight - k;
        
    }