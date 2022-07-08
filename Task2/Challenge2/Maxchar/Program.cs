using System;

namespace Maxchar
{
    class Program
    {

        const int ASCII = 256;
        private static char getMaxChar(String str)
        {
            int[] count = new int[ASCII];
            int max = -1;
            char maxchar = ' ';

            for (int i = 0; i < str.Length; i++)
            {
                
                count[str[i]]++;
            }

            for (int j = 0; j < str.Length; j++)
            {
                if (max < count[str[j]])
                {
                    max = count[str[j]];
                    maxchar = str[j];
                }
            }

            return maxchar;
        }


        static void Main(string[] args)
        {
            string x;
            string j;
            Console.Write("Please enter strings >> ");
            x = Console.ReadLine();
            j = x.ToLower();
            Console.WriteLine("The max occurring string is {0}", getMaxChar(j));
        }
    }
}
