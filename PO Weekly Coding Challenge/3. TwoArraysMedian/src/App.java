import java.util.Arrays;
import java.util.Scanner;

public class App {
    static Scanner in = new Scanner(System.in);

    public static void main(String[] args) throws Exception {
        
        //Take arrays from user
        int[] nums1 = TakeArrayOne();
        int[] nums2 = TakeArrayTwo(); 
        while(!Validator.LengthMNCheck(nums1.length, nums2.length)){
           OutputTools.SayArrayLengthConstraints();
           nums1 = TakeArrayOne();
           nums2 = TakeArrayTwo();
        }

        //Look for the median
        double result = Median.FindMedian(nums1, nums2);
        OutputTools.ShowResult(result);

    }

    public static int[] TakeArrayOne() {
        OutputTools.AskForArrayOne();
        int[] nums1 = InputTools.ReadArray(in.nextLine());
        Arrays.sort(nums1);
        while (!Validator.LengthCheck(nums1.length) || !Validator.NumbersCheck(nums1)) {
            OutputTools.SayArrayConstraints();
            OutputTools.AskForArrayOne();
            nums1 = InputTools.ReadArray(in.nextLine());
            Arrays.sort(nums1);
        }
        return nums1;
    }

    public static int[] TakeArrayTwo() {
        OutputTools.AskForArrayTwo();
        int[] nums2 = InputTools.ReadArray(in.nextLine());
        Arrays.sort(nums2);
        while (!Validator.LengthCheck(nums2.length) || !Validator.NumbersCheck(nums2)) {
            OutputTools.SayArrayConstraints();
            OutputTools.AskForArrayOne();
            nums2 = InputTools.ReadArray(in.nextLine());
            Arrays.sort(nums2);
        }
        return nums2;
    }
}
