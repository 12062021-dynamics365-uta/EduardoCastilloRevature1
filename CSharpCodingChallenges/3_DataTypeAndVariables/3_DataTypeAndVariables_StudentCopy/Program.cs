using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            //
            // Insert code here.
            //
            //
            byte aByte = 0;
            sbyte aSbyte = -128;
            int aInt = -2147483648;
            uint aUInt = 0;
            short aShort = -32768;
            ushort aUShort = 0;
            long aLong = -9223372036854775808;
            ulong aULong = 0;
            float aFloat = -3.402823e38F;
            double aDouble = -1.79769313486232e307;
            char aChar = 'a';
            bool aBoolean = false;
            object aObject = aByte;
            string aString = "Hello World";
            decimal aDecimal = -7922810000000000000;


            Console.WriteLine(PrintValues(aByte));
            Console.WriteLine(PrintValues(aSbyte));
            Console.WriteLine(PrintValues(aInt));
            Console.WriteLine(PrintValues(aUInt));
            Console.WriteLine(PrintValues(aShort));
            Console.WriteLine(PrintValues(aUShort));
            Console.WriteLine(PrintValues(aLong));
            Console.WriteLine(PrintValues(aULong));
            Console.WriteLine(PrintValues(aFloat));
            Console.WriteLine(PrintValues(aDouble));
            Console.WriteLine(PrintValues(aChar));
            Console.WriteLine(PrintValues(aBoolean));
            Console.WriteLine(PrintValues(aObject));
            Console.WriteLine(PrintValues(aString));
            Console.WriteLine(PrintValues(aDecimal));

            string firstValue = "I control text";
            string secondValue = "45832";

            int? myInt = StringToInt(secondValue);
            //'?' the operator makes a value type accept null,
            //that means, 'int' can be any integer, 'int?' can be any integer or null
            if(myInt != null)
                Console.WriteLine("First value: " + firstValue + "    " + "Second value: " + myInt);
            else
                Console.WriteLine("First value: " + firstValue + "    " + "Second value: " + "null");

        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            Type type = obj.GetType();
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:    return "Data type => byte";
                case TypeCode.SByte:   return "Data type => sbyte";
                case TypeCode.Int32:   return "Data type => int";
                case TypeCode.UInt32:  return "Data type => uint";
                case TypeCode.Int16:   return "Data type => short";
                case TypeCode.UInt16:  return "Data type => ushort";
                case TypeCode.Int64:   return "Data type => long";
                case TypeCode.UInt64:  return "Data type => ulong";
                case TypeCode.Single:  return "Data type => float";
                case TypeCode.Double:  return "Data type => double";
                case TypeCode.Char:    return "Data type => char";
                case TypeCode.Boolean: return "Data type => bool";
                case TypeCode.Object:  return "Data type => object";
                case TypeCode.String:  return "Data type => string";
                case TypeCode.Decimal: return "Data type => decimal";
                    default: return null;
            }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            if (int.TryParse(numString, out int result))
            {
                return result;
            }
            else
                return null;
        }
    }// end of class
}// End of Namespace
