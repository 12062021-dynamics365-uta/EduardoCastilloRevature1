using System;

namespace SweetnSaltyConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int sweetnSalty = 0;
            int salty = 0;
            int sweet = 0;
            while (count <=1000)
            {
                //The while loop is for counting to 1000, the for loop is for printing in groups of 20
                for (int i = 0; i < 20; i++)
                {
                    // if/else decide between three cases, divisible by 5, divisible by 3 or by none
                    if (count%5 == 0)
                    {
                        if (count % 3 == 0)//Check if it is also divisible by 3
                        {
                            Console.Write("sweet’nSalty ");
                            sweetnSalty++;
                        }
                        else
                        {
                            Console.Write("salty ");
                            salty++;
                        }                           
                    }
                    else if(count%3 == 0)
                    {
                        Console.Write("sweet ");
                        sweet++;
                    }
                    else
                    {
                        Console.Write(count + " ");
                    }   
                    count++;
                }//End for loop

                Console.WriteLine();                
            }//End while loop

            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine($" Sweets: {sweet}      Salties: {salty}       Sweet’nSalties: {sweetnSalty}");           
        }

      
    }
}
