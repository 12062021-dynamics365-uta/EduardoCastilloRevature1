import java.util.Arrays;
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner in = new Scanner(System.in);

        // Take K, the number of lists
        OutputTools.AskForNumberOfLists();
        int K = Integer.parseInt(in.nextLine());

        while (!Validator.NumberListsCheck(K))            
        {
            OutputTools.NumberOfListsConstraint();
            OutputTools.AskForNumberOfLists();
            K = Integer.parseInt(in.nextLine());
        }

        // Take the lists
        int[][] lists;
        do {

            lists = new int[K][];
            for (int i = 0; i < K; i++) {
                OutputTools.AskForList(i + 1);
                int[] list = InputTools.TakeList(in.nextLine());

                while (!Validator.ValidateListLength(list.length)) {
                    OutputTools.ListConstraint();
                    OutputTools.AskForList(i + 1);
                    list = InputTools.TakeList(in.nextLine());
                }
                lists[i] = list;
            }

        } while (!Validator.ValidateSumOfLength(lists, K));

        // Merge all the linked-lists into one sorted linked-list
        int[] finalList = InputTools.MergeLists(lists);
        Arrays.sort(finalList);
        OutputTools.SayResult(finalList);

    }

}
