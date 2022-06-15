public class Median {
    
    public static double FindMedian(int[] nums1, int[] nums2)
    {
        //define the smaller array as the first parameter 
         if(nums1.length < nums2.length)
         {
             return findMedianSortedArray(nums1,nums2);
         }
         else
         {
             return findMedianSortedArray(nums2,nums1);
         }
    }

    
    // Function to find median of two sorted arrays
    private static double findMedianSortedArray(int[] nums1, int[] nums2)
    {
        int n = nums1.length;
        int m = nums2.length;

        int min_index = 0, max_index = n, i = 0, j = 0, median = 0;


        while (min_index <= max_index)
        {
            i = (min_index + max_index) / 2;
            j = ((n + m + 1) / 2) - i;

            // If i = n, it means that Elements from nums1[] in the second half is an empty set. and if j = 0, it means that Elements from nums2[] in the first
            // half is an empty set. so it is necessary to check that, because we compare elements from these two groups. Searching on right
            if (i < n && j > 0 && nums2[j - 1] > nums1[i])    
                min_index = i + 1;
            
            // If i = 0, it means that Elements from nums1[] in the first half is an empty set and if j = m, it means that Elements from nums2[] in the second
            // half is an empty set. so it is necessary to check that, because we compare elements from these two groups. searching on left
            else if (i > 0 && j < m && nums2[j] < nums1[i - 1])    
                max_index = i - 1;


            // We have found the desired halves.
            else 
            {
                 // This condition happens when we don't have any elements in the first half from nums1[] so we returning the last element in nums2[] from the first half.
                if (i == 0)        
                median = nums2[j - 1]; 
                
                // And this condition happens when we don't have any elements in the first half from nums2[] so we returning the last element in nums1[] from the first half.
                else if (j == 0)        
                    median = nums1[i - 1];        
                else   
                    median = maximum(nums1[i - 1], nums2[j - 1]);        
                break;
            }
        }

         // Calculating the median. If number of elements is odd there is one middle element.
        if ((n + m) % 2 == 1)
            return (double)median;

        // Elements from nums1[] in the second half is an empty set.
        if (i == n)
            return (median + nums2[j]) / 2.0;

        // Elements from nums2[] in the second half is an empty set.
        if (j == m)
            return (median + nums1[i]) / 2.0;

        return (median + minimum(nums1[i], nums2[j])) / 2.0;
    }





    // Function to find max
    private static int maximum(int a, int b)
    {
        return a > b ? a : b;
    }

    // Function to find minimum
    private static int minimum(int a, int b)
    {
        return a < b ? a : b;
    }
}
