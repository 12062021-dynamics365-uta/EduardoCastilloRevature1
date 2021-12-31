using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */           

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
            int counter = 0;
            for(int i=0; i<x.Count; i++)
            {
                if(x[i]%2 !=0)
                    counter++;
            }
            return counter;
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
            int counter = 0;
            foreach(object item in x)
            {
                if(item.GetType() == typeof(int))
                {
                    if ((int)item % 2 == 0)
                    counter++;
                }

                if (item.GetType() == typeof(long))
                {
                    if ((long)item % 2 == 0)
                        counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
            int count = 0;
            int i = 0;
            while(x.Count > 0)
            {
                if (x[i] == 1234)
                    break;
                if (x[i] % 4 == 0)
                   count++;
                i++;
            }
            return count;
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
            int count = 0;
            for(int i=0; i<x.Length;i++)
            {
                if (x[i] % 3 == 0 && x[i] % 4 == 0)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
            string sentence = "";
            for(int i=0;i<stringListArray.Length;i++)
            {
                List<string> vs = stringListArray[i];
                for (int j=0; j < vs.Count; j++)
                {                    
                    sentence +=  vs[j] + " ";
                }               
            }
            return sentence;
        }
    }
}