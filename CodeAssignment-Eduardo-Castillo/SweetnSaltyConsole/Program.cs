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
                for (int i = 0; i < 20; i++)
                {
                    if(count%5 == 0)
                    {
                        if (count % 3 == 0)
                        {
                            Console.Write("sweet’nSalty ");
                            count++;
                            sweetnSalty++;
                        }
                        else
                        {
                            Console.Write("salty ");
                            count++;
                            salty++;
                        }                           
                    }
                    else if(count%3 == 0)
                    {
                        Console.Write("sweet ");
                        count++;
                        sweet++;
                    }
                    else
                    {
                        Console.Write(count + " ");
                        count++;
                    }                    
                }
                Console.WriteLine();                
            }
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine($" Sweets: {sweet}      Salties: {salty}       Sweet’nSalties: {sweetnSalty}");


        }
    }
}
