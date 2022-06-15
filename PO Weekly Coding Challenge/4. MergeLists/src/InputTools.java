public class InputTools {
    public static int[] TakeList(String list)
    {
        int[] array;
        do{
            String[] splitArray = list.split(" ");
            array = new int[splitArray.length];
    
            for (int i = 0; i < splitArray.length; i++) {
                array[i] = Integer.parseInt(splitArray[i]);
            }
        }while(!ValidateList(array));
      
        return array;
    }



    private static Boolean ValidateList(int[] list)
    {
        if(!Validator.ValidateListElements(list))
        {
            OutputTools.NumbersConstraint();
            return false;
        }

        return true;
    }


    public static int[] MergeLists(int[][] lists)
    {
        if(lists.length < 2)
         return lists[0];

        int[] arr = MergeTwoArrays(lists[0], lists[1]);;
         for(int i = 2; i< lists.length; i++)
         {
            arr = MergeTwoArrays(arr, lists[i]);
         }

         return arr;
    }

    private static int[] MergeTwoArrays(int[]a, int[] b)
    {
        // determines length of firstArray
        int a1 = a.length;
        
        // determines length of secondArray
        int b1 = b.length;
        
        // resultant array size
        int c1 = a1 + b1;
  
        // create the resultant array
        int[] c = new int[c1];

        // using the pre-defined function arraycopy
        System.arraycopy(a, 0, c, 0, a1);
        System.arraycopy(b, 0, c, a1, b1);

        return c;
    }
}
