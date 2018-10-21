using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram6
{
    class Descrambler
    {

        Promptz UserPrompts = new Promptz();

        public void threeLetter()
        {
            string threeLetterWord = Console.ReadLine();
           
            if(threeLetterWord.Length <= 2 || threeLetterWord.Length >= 4)//checks to see if input word is 3 letters long

            {
                UserPrompts.Prompt3();//tells user need correct number of letters and try again
                Console.ReadLine();
            }
            else
            {
                //makes array out of input and assigns array index to a variable
                char[] array = threeLetterWord.ToCharArray();
                var a = array[0];
                var b = array[1];
                var c = array[2];

                //prints out combination list
                UserPrompts.Prompt2();
                Console.WriteLine(a + "" + b + "" + c);
                Console.WriteLine(a + "" + c + "" + b);
                Console.WriteLine(b + "" + a + "" + c);
                Console.WriteLine(b + "" + c + "" + a);
                Console.WriteLine(c + "" + a + "" + b);
                Console.WriteLine(c + "" + b + "" + c);
                UserPrompts.Prompt6();
                Console.ReadLine();
            }
        }

        public void fourLetter()
        {
            string fourLetterWord = Console.ReadLine();

            if (fourLetterWord.Length <= 3 || fourLetterWord.Length >= 5)//checks to see if input word is 4 letters long

            {
                UserPrompts.Prompt4();//tells user need correct number of letters and try again
                Console.ReadLine();
            }
            else
            {
                //makes array out of input and assigns array index to a variable
                char[] array = fourLetterWord.ToCharArray();
                var a = array[0];
                var b = array[1];
                var c = array[2];
                var d = array[3];

                //prints out combination list
                UserPrompts.Prompt2();
                Console.WriteLine(a + "" + b + "" + c + "" + d);
                Console.WriteLine(a + "" + b + "" + d + "" + c);
                Console.WriteLine(a + "" + c + "" + b + "" + d);
                Console.WriteLine(a + "" + c + "" + d + "" + b);
                Console.WriteLine(a + "" + d + "" + b + "" + c);
                Console.WriteLine(a + "" + d + "" + c + "" + b);

                Console.WriteLine(b + "" + a + "" + c + "" + d);
                Console.WriteLine(b + "" + a + "" + d + "" + c);
                Console.WriteLine(b + "" + c + "" + a + "" + d);
                Console.WriteLine(b + "" + c + "" + d + "" + a);
                Console.WriteLine(b + "" + d + "" + a + "" + c);
                Console.WriteLine(b + "" + d + "" + c + "" + a);

                Console.WriteLine(c + "" + a + "" + b + "" + d);
                Console.WriteLine(c + "" + a + "" + d + "" + b);
                Console.WriteLine(c + "" + b + "" + a + "" + d);
                Console.WriteLine(c + "" + b + "" + d + "" + a);
                Console.WriteLine(c + "" + d + "" + a + "" + b);
                Console.WriteLine(c + "" + d + "" + b + "" + a);

                Console.WriteLine(d + "" + a + "" + b + "" + c);
                Console.WriteLine(d + "" + a + "" + c + "" + b);
                Console.WriteLine(d + "" + b + "" + c + "" + a);
                Console.WriteLine(d + "" + b + "" + a + "" + c);
                Console.WriteLine(d + "" + c + "" + b + "" + a);
                Console.WriteLine(d + "" + c + "" + a + "" + b);


                UserPrompts.Prompt6();
                Console.ReadLine();
            }
        }

        public void fiveLetter()
        {
            string fiveLetterWord = Console.ReadLine();

            if (fiveLetterWord.Length <= 4 || fiveLetterWord.Length >= 6)//checks to see if input word is 5 letters long

            {
                UserPrompts.Prompt5();//tells user need correct number of letters and try again
                Console.ReadLine();
            }
            else
            {
                //makes array out of input and assigns array index to a variable
                char[] array = fiveLetterWord.ToCharArray();
                var a = array[0];
                var b = array[1];
                var c = array[2];
                var d = array[3];
                var e = array[4];

                //prints out combination list
                UserPrompts.Prompt2();
                Console.WriteLine(a + "" + b + "" + c + "" + d + "" + e);
                Console.WriteLine(a + "" + b + "" + c + "" + e + "" + d);
                Console.WriteLine(a + "" + b + "" + d + "" + c + "" + e);
                Console.WriteLine(a + "" + b + "" + d + "" + e + "" + c);
                Console.WriteLine(a + "" + b + "" + e + "" + c + "" + d);
                Console.WriteLine(a + "" + b + "" + e + "" + d + "" + c);
                Console.WriteLine(a + "" + c + "" + b + "" + d + "" + e);
                Console.WriteLine(a + "" + c + "" + b + "" + e + "" + d);
                Console.WriteLine(a + "" + c + "" + d + "" + b + "" + e);
                Console.WriteLine(a + "" + c + "" + d + "" + e + "" + b);
                Console.WriteLine(a + "" + c + "" + e + "" + b + "" + d);
                Console.WriteLine(a + "" + c + "" + e + "" + d + "" + b);
                Console.WriteLine(a + "" + d + "" + b + "" + c + "" + e);
                Console.WriteLine(a + "" + d + "" + b + "" + e + "" + c);
                Console.WriteLine(a + "" + d + "" + c + "" + b + "" + e);
                Console.WriteLine(a + "" + d + "" + c + "" + e + "" + b);
                Console.WriteLine(a + "" + d + "" + e + "" + b + "" + c);
                Console.WriteLine(a + "" + d + "" + e + "" + c + "" + b);
                Console.WriteLine(a + "" + e + "" + b + "" + c + "" + d);
                Console.WriteLine(a + "" + e + "" + b + "" + d + "" + c);
                Console.WriteLine(a + "" + e + "" + c + "" + b + "" + d);
                Console.WriteLine(a + "" + e + "" + c + "" + d + "" + b);
                Console.WriteLine(a + "" + e + "" + d + "" + b + "" + c);
                Console.WriteLine(a + "" + e + "" + d + "" + c + "" + b);

                Console.WriteLine(b + "" + a + "" + c + "" + d + "" + e);
                Console.WriteLine(b + "" + a + "" + c + "" + e + "" + d);
                Console.WriteLine(b + "" + a + "" + d + "" + c + "" + e);
                Console.WriteLine(b + "" + a + "" + d + "" + e + "" + d);
                Console.WriteLine(b + "" + a + "" + e + "" + c + "" + d);
                Console.WriteLine(b + "" + a + "" + e + "" + d + "" + c);
                Console.WriteLine(b + "" + c + "" + a + "" + d + "" + e);
                Console.WriteLine(b + "" + c + "" + a + "" + e + "" + d);
                Console.WriteLine(b + "" + c + "" + d + "" + a + "" + e);
                Console.WriteLine(b + "" + c + "" + d + "" + e + "" + a);
                Console.WriteLine(b + "" + c + "" + e + "" + a + "" + d);
                Console.WriteLine(b + "" + c + "" + e + "" + d + "" + a);
                Console.WriteLine(b + "" + d + "" + a + "" + c + "" + e);
                Console.WriteLine(b + "" + d + "" + a + "" + e + "" + c);
                Console.WriteLine(b + "" + d + "" + c + "" + a + "" + e);
                Console.WriteLine(b + "" + d + "" + c + "" + e + "" + a);
                Console.WriteLine(b + "" + d + "" + e + "" + a + "" + c);
                Console.WriteLine(b + "" + d + "" + e + "" + c + "" + a);
                Console.WriteLine(b + "" + e + "" + a + "" + c + "" + d);
                Console.WriteLine(b + "" + e + "" + a + "" + d + "" + c);
                Console.WriteLine(b + "" + e + "" + c + "" + a + "" + d);
                Console.WriteLine(b + "" + e + "" + c + "" + d + "" + a);
                Console.WriteLine(b + "" + e + "" + d + "" + a + "" + c);
                Console.WriteLine(b + "" + e + "" + d + "" + c + "" + a);

                Console.WriteLine(c + "" + a + "" + b + "" + d + "" + e);
                Console.WriteLine(c + "" + a + "" + b + "" + e + "" + d);
                Console.WriteLine(c + "" + a + "" + d + "" + b + "" + e);
                Console.WriteLine(c + "" + a + "" + d + "" + e + "" + b);
                Console.WriteLine(c + "" + a + "" + e + "" + b + "" + d);
                Console.WriteLine(c + "" + a + "" + e + "" + d + "" + b);
                Console.WriteLine(c + "" + b + "" + a + "" + d + "" + e);
                Console.WriteLine(c + "" + b + "" + a + "" + e + "" + d);
                Console.WriteLine(c + "" + b + "" + d + "" + a + "" + e);
                Console.WriteLine(c + "" + b + "" + d + "" + e + "" + a);
                Console.WriteLine(c + "" + b + "" + e + "" + a + "" + d);
                Console.WriteLine(c + "" + b + "" + e + "" + d + "" + a);
                Console.WriteLine(c + "" + d + "" + a + "" + b + "" + e);
                Console.WriteLine(c + "" + d + "" + a + "" + e + "" + b);
                Console.WriteLine(c + "" + d + "" + b + "" + a + "" + e);
                Console.WriteLine(c + "" + d + "" + b + "" + e + "" + a);
                Console.WriteLine(c + "" + d + "" + e + "" + a + "" + b);
                Console.WriteLine(c + "" + d + "" + e + "" + b + "" + a);
                Console.WriteLine(c + "" + e + "" + a + "" + b + "" + d);
                Console.WriteLine(c + "" + e + "" + a + "" + d + "" + b);
                Console.WriteLine(c + "" + e + "" + b + "" + a + "" + d);
                Console.WriteLine(c + "" + e + "" + b + "" + d + "" + a);
                Console.WriteLine(c + "" + e + "" + d + "" + a + "" + b);
                Console.WriteLine(c + "" + e + "" + d + "" + b + "" + a);

                Console.WriteLine(d + "" + a + "" + b + "" + c + "" + e);
                Console.WriteLine(d + "" + a + "" + b + "" + e + "" + c);
                Console.WriteLine(d + "" + a + "" + c + "" + b + "" + e);
                Console.WriteLine(d + "" + a + "" + c + "" + e + "" + b);
                Console.WriteLine(d + "" + a + "" + e + "" + b + "" + c);
                Console.WriteLine(d + "" + a + "" + e + "" + c + "" + b);
                Console.WriteLine(d + "" + b + "" + a + "" + c + "" + e);
                Console.WriteLine(d + "" + b + "" + a + "" + e + "" + c);
                Console.WriteLine(d + "" + b + "" + c + "" + a + "" + e);
                Console.WriteLine(d + "" + b + "" + c + "" + e + "" + a);
                Console.WriteLine(d + "" + b + "" + e + "" + a + "" + c);
                Console.WriteLine(d + "" + b + "" + e + "" + c + "" + a);
                Console.WriteLine(d + "" + c + "" + a + "" + b + "" + e);
                Console.WriteLine(d + "" + c + "" + a + "" + e + "" + b);
                Console.WriteLine(d + "" + c + "" + b + "" + a + "" + e);
                Console.WriteLine(d + "" + c + "" + b + "" + e + "" + a);
                Console.WriteLine(d + "" + c + "" + e + "" + a + "" + d);
                Console.WriteLine(d + "" + c + "" + e + "" + d + "" + a);
                Console.WriteLine(d + "" + e + "" + a + "" + b + "" + c);
                Console.WriteLine(d + "" + e + "" + a + "" + c + "" + b);
                Console.WriteLine(d + "" + e + "" + b + "" + a + "" + c);
                Console.WriteLine(d + "" + e + "" + b + "" + c + "" + a);
                Console.WriteLine(d + "" + e + "" + c + "" + a + "" + b);
                Console.WriteLine(d + "" + e + "" + c + "" + b + "" + a);

                Console.WriteLine(e + "" + a + "" + b + "" + c + "" + d);
                Console.WriteLine(e + "" + a + "" + b + "" + d + "" + c);
                Console.WriteLine(e + "" + a + "" + c + "" + b + "" + d);
                Console.WriteLine(e + "" + a + "" + c + "" + d + "" + b);
                Console.WriteLine(e + "" + a + "" + d + "" + b + "" + c);
                Console.WriteLine(e + "" + a + "" + d + "" + c + "" + b);
                Console.WriteLine(e + "" + b + "" + a + "" + c + "" + d);
                Console.WriteLine(e + "" + b + "" + a + "" + d + "" + c);
                Console.WriteLine(e + "" + b + "" + c + "" + a + "" + d);
                Console.WriteLine(e + "" + b + "" + c + "" + d + "" + a);
                Console.WriteLine(e + "" + b + "" + d + "" + a + "" + c);
                Console.WriteLine(e + "" + b + "" + d + "" + c + "" + a);
                Console.WriteLine(e + "" + c + "" + a + "" + b + "" + d);
                Console.WriteLine(e + "" + c + "" + a + "" + d + "" + b);
                Console.WriteLine(e + "" + c + "" + b + "" + a + "" + d);
                Console.WriteLine(e + "" + c + "" + b + "" + d + "" + a);
                Console.WriteLine(e + "" + c + "" + d + "" + a + "" + b);
                Console.WriteLine(e + "" + c + "" + d + "" + b + "" + a);
                Console.WriteLine(e + "" + d + "" + a + "" + b + "" + c);
                Console.WriteLine(e + "" + d + "" + a + "" + c + "" + b);
                Console.WriteLine(e + "" + d + "" + b + "" + a + "" + c);
                Console.WriteLine(e + "" + d + "" + b + "" + c + "" + a);
                Console.WriteLine(e + "" + d + "" + c + "" + a + "" + b);
                Console.WriteLine(e + "" + d + "" + c + "" + b + "" + a);

                UserPrompts.Prompt6();
                Console.ReadLine();
            }
        }

    }
}
