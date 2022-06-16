public class OutputTools {
    public static void AskForNumberOfLists()
    {
        System.out.println("Enter the number of lists");
    }

    public static void AskForList(int num)
    {
        System.out.println("Enter the list number " + num + ". Write the numbers separated by spaces, like '2 3 5 6 8 10'");
    }

    public static void NumberOfListsConstraint()
    {
        System.out.println("The max number of lists is 104");
    }

    public static void NoList()
    {
        System.out.println("No list entered");
    }

    public static void NumbersConstraint()
    {
        System.out.println("Numbers need to be between -104 to 104");
    }

    public static void ListConstraint()
    {
        System.out.println("The max number of elements in the list is 500");
    }

    public static void SumConstraint()
    {
        System.out.println("There can only be a total of 104 elements");
    }

    public static void SayResult(int[] result)
    {
        String text = "";

        for(int i = 0; i< result.length; i++){
            text += result[i] + " ";
        }

        System.out.println(text);
    }

    public static void SayResult(String result)
    {
        System.out.println(result);
    }
}
