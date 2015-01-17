using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hiddenWords = { 8, 0, 0, 8, 5 };
            for (int index = 0; index < hiddenWords.Length; index++)
            {
                int word = hiddenWords[index];
                Console.WriteLine(word);
                Console.ReadLine();
            }

        }
    }
}
