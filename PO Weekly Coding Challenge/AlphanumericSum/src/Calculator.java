

public class Calculator {
    

    public static int StringSum(String text)
    {
        int count = 0;
        
         for(int i=0; i< text.length(); i++)
         {

            if(IsNumber(text.charAt(i)))
            {
               count += Integer.parseInt(String.valueOf(text.charAt(i)));
            }
         } 
         return count;
    }


    static Boolean IsNumber(char x)
    {
        if( x=='0' || x=='1' || x=='2'|| x=='3' || x=='4' || x=='5'|| x=='6' || x== '7' || x=='8'|| x=='9')
        return true;
        else
        return false;
    }
}
