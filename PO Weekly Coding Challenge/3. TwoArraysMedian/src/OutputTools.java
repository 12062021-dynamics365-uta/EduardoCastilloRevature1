public class OutputTools {
    public static void AskForArrayOne()
    {
        System.out.println("Enter the first array. Write the numbers separated by spaces, like '2 3 5 6 8 10'");
    }

    public static void AskForArrayTwo()
    {
        System.out.println("Enter the second array. Write the numbers separated by spaces, like '2 3 5 6 8 10'");
    }

    public static void SayArrayConstraints(){
        System.out.println("Maximun numbers of elements are 1000, and numbers should be between -106 and 106");
    }

    public static void SayArrayLengthConstraints(){
        System.out.println("No empty array");
    }

    public static void ShowResult(double result){
        System.out.println("The median is " + result);
    }
}
