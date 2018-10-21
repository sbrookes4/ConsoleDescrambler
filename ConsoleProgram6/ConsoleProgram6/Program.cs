using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram6
{
    class Program
    {
        static void Main(string[] args)
        {
            Promptz UserPrompt = new Promptz();
            Descrambler WordLength = new Descrambler();

            UserPrompt.Prompt1();
            determiner();      
        }

        static void determiner()
        {

            Descrambler WordLen= new Descrambler();

            string determiner = Console.ReadLine();
            int determinerX = Int32.Parse(determiner);

            if (determinerX == 3)
            {
                Console.WriteLine("Type in the three letter word and press ENTER to see possible words:\r\n");
                WordLen.threeLetter();

            }

            else if (determinerX == 4)
            {
                Console.WriteLine("Type in the four letter word and press ENTER to see possible words:\r\n");
                WordLen.fourLetter();
            }

            else if (determinerX == 5)
            {
                Console.WriteLine("Type in the five letter word and press ENTER to see possible words:\r\n");
                WordLen.fiveLetter();
            }

            else if (determinerX >= 6 || determinerX <= 2)
            {
                Console.WriteLine("Sorry, the descrambler can only do 3 to 5 letters at this time. Try again.");
                Console.ReadLine();
            }

        }

    }
}
