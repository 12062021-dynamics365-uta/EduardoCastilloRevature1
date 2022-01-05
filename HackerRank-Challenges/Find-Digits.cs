// Find Digits solution https://www.hackerrank.com/challenges/find-digits/submissions/code/250063330

static int findDigits(int n)
    {
        //making an int digits array from n
        string strN = n.ToString();
        int[] intArr =  new int[strN.Length];
        for(int i=0; i < strN.Length; i++)
        {
            intArr[i] = int.Parse(strN[i].ToString());
        }
        
        //Finding the number of divisors of n in the array
        int count = 0;
        for(int i=0; i < intArr.Length; i++)
        {            
            if(intArr[i] !=0 && n%intArr[i] ==0)
            count++;
        }
         
        //return number of divisors
        return count;
    }