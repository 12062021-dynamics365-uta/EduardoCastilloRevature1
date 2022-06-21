import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner in = new Scanner(System.in);

        //Take inputs
        OutputTools.AskForStartingValue();
        int a = Integer.parseInt(in.nextLine());
        OutputTools.AskForEndingValue();
        int b = Integer.parseInt(in.nextLine());

        //Show result
        int count = Calculator.CountSquares(a, b);
        OutputTools.TellResult(a, b, count);
    }
}
