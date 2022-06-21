public class Calculator {
    public static boolean FindSquares(int number) {
        double square = Math.sqrt(number);
        if (square % 1 == 0)
            return true;
        else
            return false;
    }

    public static int CountSquares(int a, int b) {
        int count = 0;
        for (int i = a; i <= b; i++) {
            if (FindSquares(i))
                count++;
        }
        return count;
    }
}
