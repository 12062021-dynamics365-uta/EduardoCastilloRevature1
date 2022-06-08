import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner in = new Scanner(System.in);   
        int T;

        //Take T, the number of test cases
        do{
          OutputTools.AskForNumberOfCases();
          T = Integer.parseInt(in.nextLine());

        }while(!Validator.ValidateT(T));


        //Take the alphanumeric strings
        String[] strings = new String[T];
        for(int i=0; i< T; i++)
        {
            String input;
            
            do{
                OutputTools.AskForString();
                input = in.nextLine();
            }while(!Validator.ValidateString(input));

            strings[i] = input;
        }



        //Show the sum of each string
        for(int i=0; i<T; i++)
        {
            int sum = Calculator.StringSum(strings[i]);
            System.out.println("Text " + (i+1) + " sum: " + sum);
        }
    }
}
