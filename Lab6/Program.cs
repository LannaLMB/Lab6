using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome Message
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine();



            // Declare Variables
            string word = "";
            string Continue;



            // Loop if User Chooses to Continue
            while (true)
            {



                // Input
                Console.WriteLine("Please Enter a Word to Translate: ");
                Console.WriteLine();
                word = Console.ReadLine().ToLower();
                Console.WriteLine();



                //String Empty or WhiteSpace
                while (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine("You Must Enter a Word!");
                    return;
                }



                // Process
                if (word.StartsWith("a") || word.StartsWith("e") || word.StartsWith("i") || word.StartsWith("o") || word.StartsWith("u"))
                {
                    StringBuilder sb = new StringBuilder(word);
                    sb.Append("way");
                    Console.WriteLine(sb);
                }
                else
                {
                    word.LastIndexOf(word);
                    Console.WriteLine(word);
                }





                // Method For Input
                // public static string GetWord(string word)
                // {
                // Input
                // Console.WriteLine("Please Enter a Word to Translate: ");
                // Console.WriteLine();
                // word = Console.ReadLine().ToLower();
                // }




                // Continue Loop
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would You Like to Translate Another Word?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    Console.WriteLine("");

                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                    {
                        Console.WriteLine("Bye!");
                        return;
                    }

                    else
                        Console.WriteLine("Please Enter Y or N");
                }
            }
        }
    }
}
