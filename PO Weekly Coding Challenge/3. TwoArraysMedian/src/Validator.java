import java.util.Arrays;
import java.util.Collections;

public class Validator {
    public static Boolean LengthCheck(int length) {
        if (length >= 0 && length <= 1000)
            return true;
        else
            return false;
    }

    public static Boolean LengthMNCheck(int m, int n) {
        if (m + n >= 1 && m + n <= 2000)
            return true;
        else
            return false;
    }



    
    public static Boolean NumbersCheck(Integer[] array) {
        
        int min = Collections.min(Arrays.asList(array));
        int max = Collections.max(Arrays.asList(array));

        if (min >= -106 && max <= 106)
            return true;
        else
            return false;
    }

    //For already sorted array
    public static Boolean NumbersCheck(int[] array) {
        int min = array[0];
        int max = array[array.length-1];

        if (min >= -106 && max <= 106)
            return true;
        else
            return false;
    }
}
