using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram6
{
    class Promptz
    {

        public void Prompt1()
        {
            Console.WriteLine("Shawna's Simple Descrambler App!\nHow many letters is the word to descramble?\nType number between 3 and 5 and press ENTER.\r\n");     
        }

        public void Prompt2()
        {
            Console.WriteLine("\r\nPossible Unscrambled Word List Below:\r\n");
        }

        public void Prompt3()
        {
            Console.WriteLine("\r\nYou have to use a 3 letter word only. Try again.");
        }

        public void Prompt4()
        {
            Console.WriteLine("\r\nYou have to use a 4 letter word only. Try again.");
        }

        public void Prompt5()
        {
            Console.WriteLine("\r\nYou have to use a 5 letter word only. Try again.");
        }

        public void Prompt6()
        {
            Console.WriteLine("\r\nThanks for using Shawna Brookes' console descrambler program!");
        }

    }
}
