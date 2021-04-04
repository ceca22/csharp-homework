using System;
using System.Text.RegularExpressions;

namespace vezba2
{
    class Program
    {
        public void replace(string str1)                         //create function

        {

            string pattern = "\\s+";

            string replacement = " ";                       // replacement pattern

            Regex rx = new Regex(pattern);

            string result = rx.Replace(str1, replacement);  // call to replace space

            Console.WriteLine("Your string String          : {0}", str1);

            Console.WriteLine("Remove extra space String   : {0}", result);



        }

        
        static void Main(string[] args)
        {
            string myText = " The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            


        }
    }
}
