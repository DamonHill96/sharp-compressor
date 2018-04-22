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
                    //Appends final encoded characters plus comma. Not ideal but needed when decoding
                    sb.Append(text[i]).Append(",").Append(noOfOccurences).Append(",");
                    noOfOccurences = 1; //reset
                }

            }
            Console.WriteLine(sb.ToString());
            Save();
            writeFile(sb.ToString());
        }

        public void DoDecode(string[] text)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            string character = "";
            int timesToWrite = 0;
            for (int i = 0; i < text.Length-1; i+= 2)
            {
                character = text[i];
                timesToWrite = int.Parse(text[i + 1]); //Number of occurences

                //Write expanded out character
                for (int x = 0; x < timesToWrite ; x++)
                {
                    sb.Append(character);
                }
                Console.WriteLine(i);
            }

            Console.WriteLine(sb.ToString());
            Save();
            writeFile(sb.ToString());
        }
    }
}
