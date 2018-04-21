using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using compalg;

namespace algorithms
{
    class RunLengthEncoding  : CompressionAlgorithm
    {
        public void DoEncode(char[] text)
        {
            
            StringBuilder sb = new StringBuilder();
            int noOfOccurences = 1; // Keeps track of number of characters in a row
            for (int i = 0; i < text.Length - 1; i++)
            {
               
                if (text[i] == text[i+1])
                {
                    noOfOccurences++;
                } else
                {
                    sb.Append(text[i]).Append(noOfOccurences); //Appends final encoded characters
                    noOfOccurences = 1; //reset
                }

            }
            Console.WriteLine(sb.ToString());
            Save();
            writeFile(sb.ToString());
        }
    }
}
