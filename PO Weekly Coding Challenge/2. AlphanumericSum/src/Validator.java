public class Validator {
   
    public static Boolean ValidateT(int T)
    {
        if(T >= 1 && T <= 1000)
        return true;
        else
        return false;
    }

    public static Boolean ValidateString(String S)
    {
        if( S.length() >= 1 && S.length() <= 1000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
