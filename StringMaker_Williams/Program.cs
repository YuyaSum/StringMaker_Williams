using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dean Williams
// IT113
// NOTES: I didn't use any stack or queue as a base to accomplish much, its been a while since I actually had to code and i've
// had my focuse more so on the 400 class.
// BEHAVIORS NOT IMPLIMENTED AND WHY: 

namespace StringMaker_Williams
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManager sm = new StringManager();
            char choice = 'x';
            string word = null;
            string modWord = null;

            while (choice != 'Q')
            {
                Console.WriteLine("What would you like to do?\n(M)odify word (N)ew word (Q)uit");
                choice = Console.ReadKey(true).KeyChar;
                Console.Clear();

                switch (char.ToUpper(choice)) {
                    case 'M':
                        {
                            if (word == null) {
                                Console.WriteLine("Try adding a new word first!");
                                break;
                            }

                            Console.WriteLine("What would you like to do?\n(A)SCII / (E)quals " +
                                "/ (R)everse / reverse and (P)reserve case location / s(Y)mmetric / (S)top");
                            choice = Console.ReadKey(true).KeyChar;
                            Console.Clear();

                            switch (char.ToUpper(choice)) {
                                case 'A':
                                    {
                                        modWord = sm.ToString();
                                        sm.ModWord = modWord;
                                        Console.WriteLine(modWord);
                                        Console.WriteLine();
                                        break;
                                    }
                                case 'E':
                                    {
                                        Console.WriteLine("What word are we checking?");
                                        var newWord = Console.ReadLine();
                                        if (sm.Equals(newWord))
                                        {
                                            Console.WriteLine("\"" + newWord + "\" is equal to \"" + word + "\"!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\"" + newWord + "\" is not equal to \"" + word + "\".");
                                        }
                                        Console.WriteLine();
                                        break;
                                    }
                                case 'R':
                                    {
                                        modWord = sm.Reverse(modWord);
                                        sm.ModWord = modWord;
                                        Console.WriteLine(modWord);
                                        Console.WriteLine();
                                        break;
                                    }
                                case 'P':
                                    {
                                        modWord = sm.Reverse(modWord, true);
                                        sm.ModWord = modWord;
                                        Console.WriteLine(modWord);
                                        Console.WriteLine();
                                        break;
                                    }
                                case 'Y':
                                    {
                                        if (sm.Symmetric(modWord))
                                        {
                                            Console.WriteLine("\"" + modWord + "\" is Symmetric!");
                                        }
                                        else {
                                            Console.WriteLine("\"" + modWord + "\" is not Symmetric.");
                                        }
                                        Console.WriteLine();
                                        break;
                                    }
                                case 'S':
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case 'N':
                        {
                            Console.WriteLine("What would you like the word to be?");
                            word = Console.ReadLine();
                            sm.OGWord = word;
                            modWord = word;
                            Console.WriteLine();
                            Console.WriteLine("\"" + word + "\" has been added!");

                            break;
                        }
                    case 'Q':
                        {
                            Console.Clear();
                            Console.WriteLine("Have a good day!");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That isn't a value key.");
                            break;
                        }
                }
            }
        }
    }
}
