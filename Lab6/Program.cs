/*  Author:  Lanna Brasure
 *  Last Updated:  4/17/17
 *  Program:  Lab6 - Pig Latin Translator
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


            // Program Continue Loop
            while (true)
            {

                // Declare Variables and Call Methods
                string input = GetInput();
                input = IsWord(input);
                string[] sentence = SplitWords(input); 
                PrintTranslation(sentence);
                string Continue;


                // Yes or No - Continue Loop
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would You Like to Translate Another Word or Sentence?  (y/n)");
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
                Console.WriteLine("Please Enter a Word or Sentence to Translate: ");
                Console.WriteLine();
                string input = Console.ReadLine().ToLower();

                // Checks to See if Input is Empty or Has WhiteSpace
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


        // Method to Make Sure Input is a String
        public static string IsWord(string input)
        {
            while (!Regex.IsMatch(input, @"^[A-Za-z\s]+$"))
            {
                Console.WriteLine("This is an integer, please enter a word:  ");
                input = Console.ReadLine();
            }
            return input;
        }


    }
}
