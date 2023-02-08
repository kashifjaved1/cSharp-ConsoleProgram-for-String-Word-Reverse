using System;
using System.Collections;
using System.Linq;
using System.Threading;

namespace StringWordReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "This is C# program for reversing given string's each word";
            int counter = 0;
            ArrayList arylist = new ArrayList();
            //char[] symbols = { ',', '\'', '!', '?', '.' };

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')// || !str[i].Equals(symbols.Any()))
                {
                    counter++;
                }

                if (str[i] == ' ')
                {
                    Reverse(str, i, counter, arylist);
                    counter = 0;
                }

                if (i == str.Length-1)
                {
                    Reverse(str, i+1, counter, arylist);
                }
            }

            foreach (var item in arylist)
            {
                Console.Write(item);
            }

            Console.WriteLine("");
        }

        public static int Reverse(string str, int index, int loopCounter, ArrayList arylist)
        {
            index = index - 1;
            for (int i = 0; i <= loopCounter; i++)
            {
                if(i < loopCounter)
                {
                    arylist.Add(str[index]);
                    index--;
                }
                if (i == loopCounter) arylist.Add(" ");
            }
            return 0;
        }
    }
}
