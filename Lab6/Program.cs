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
            while (true)
            {
                string input = GetInput();
                string[] sentence = SplitWords(input);
                PrintTranslation(sentence);
                string Continue;


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


        //Input Method
        public static string GetInput()
        {

            // Loop if User Chooses to Continue
            while (true)
            {

                // Input
                Console.WriteLine("Please Enter a Word to Translate: ");
                Console.WriteLine();
                string input = Console.ReadLine().ToLower();

                if ((string.IsNullOrEmpty(input)) || (string.IsNullOrWhiteSpace(input)))
                {
                    Console.WriteLine("You Must Enter a Word!");
                }

                else

                    return input;
            }
        }


        // Method For Splitting/Breaking Down Sentence Into Words
        public static string[] SplitWords(string input)
        {

            string[] Words = input.Split(' ');
            return Words;
        }


        // Method For Printing The Translation
        public static void PrintTranslation(string[] input)
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].IndexOfAny(vowels) == 0)
                {
                    Console.Write(input[i] + "way ");
                }

                else
                {
                    string starting = input[i].Substring(0, input[i].IndexOfAny(vowels));
                    string ending = input[i].Substring(input[i].IndexOfAny(vowels));
                    Console.WriteLine(ending + starting + "ay ");
                }
            }

                Console.WriteLine();
            }
        }
    }
