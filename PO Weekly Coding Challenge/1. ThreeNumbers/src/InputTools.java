public class InputTools {
    
    public static int TakeN(int N)
    {

         if(N >= 1 && N <= 6)
         {
            return N; 
         }
         else
         {
             return -1;
         }
    }

    
    public static int[] TakeTriplet(String triplet)
    {
        String[] splitArray = triplet.split(" ");
        int[] array = new int[splitArray.length];

        for (int i = 0; i < splitArray.length; i++) {
            array[i] = Integer.parseInt(splitArray[i]);
        }
        return array;
    }


    public static Boolean ValidateTriplet(int[] arr)
    {
        if(arr.length != 3)
        return false;

        for (int i = 0; i < 3; i++)
        {
            if(arr[i] < 0 || arr[i] > 10001)
            {
                return false;
            }
        }
        if(arr[0] == arr[1] || arr[0]==arr[2] || arr[1]==arr[2])
        {
            return false;
        }
        return true;
    }

}
