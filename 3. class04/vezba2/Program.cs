using System;
using System.Text.RegularExpressions;

namespace vezba2
{
    class Program
    {
        static void removeSpaces(string[] text, string newText)
        {
            foreach (string item in text)
            {
                if (item != "")
                    newText = item + " ";
                else continue;
                Console.Write(newText);
            }
        }

        
        static void Main(string[] args)
        {
            string myText = " The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            string[] text = myText.Split();
            string newText = "Text:";



            removeSpaces(text, newText);



        }
    }
}
