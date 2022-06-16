public class Validator {
    public static Boolean NumberListsCheck(int num) {
        if (num >= 0 && num <= 104)
            return true;
        else
            return false;
    }

    public static Boolean ValidateListLength(int length) {
        if (length <= 500)
            return true;
        else
            return false;
    }

    public static Boolean ValidateListElements(int[] list) {

        for (int i = 0; i < list.length; i++) {
            if (list[i] < -104 || list[i] > 104)
                return false;
        }
        return true;
    }

    public static Boolean ValidateSumOfLength(int[][] lists, int K) {
        
        int total = SumOfLength(lists, K);

        if (total > 104)
            return false;
        else
            return true;
    }

    public static int SumOfLength(int[][] lists, int K)
    {
        int total = 0;
        for (int i = 0; i < K; i++) {
            if(lists[i] != null)
            total += lists[i].length;
        }
        return total;
    }
}
