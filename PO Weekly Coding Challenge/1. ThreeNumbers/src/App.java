import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner in = new Scanner(System.in);        
        int N;

        do{
            OutputTools.AskForN();
            N = Integer.parseInt(in.nextLine());
        }
        while(InputTools.TakeN(N) == -1);


        int[][] array = new int[N][3];

        for(int i=0; i<N; i++)
        {    
            int[] three;

            do{
                OutputTools.AskForTriples();
                three = InputTools.TakeTriplet(in.nextLine());
            }while(!InputTools.ValidateTriplet(three));

            array[i] = three;
        }


        for(int i=0; i<N; i++)
        {
            int middle = seeker.FindSecondMaximum(array[i]);
            System.out.println(middle);
        }
        
    }
}
