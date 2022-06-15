public class InputTools {
    
    public static int[] ReadArray(String input)
    {
        String[] splitArray = input.split(" ");
        int[] array = new int[splitArray.length];

        for (int i = 0; i < splitArray.length; i++) {
            array[i] = Integer.parseInt(splitArray[i]);
        }
        return array;
    }
}
