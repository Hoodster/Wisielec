using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisielec
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "", answer = "";
            int mistakes = 0;
            try
            {
                string[] dictionary = File.ReadAllLines(@"slownik.txt");
                Random rand = new Random();
                word = dictionary[rand.Next(dictionary.Length)];
                for (int i = 0; i < (word.Length - 2); i++)
                {
                    answer = answer + "-";
                }

                answer = word.Substring(0, 1) + answer + word.Substring((word.Length - 1));
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd.");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            do {
                int b = 0, c = 0;
                Console.WriteLine(answer);
                Console.WriteLine("Ilość błędów: {0}", mistakes);
                Console.WriteLine("Podaj literę: ");
                string chars = Console.ReadLine();
                    for (int i = 0; i < word.Length; i++)
                    {

                        if (word[i] == chars[0])
                        {
                         b++;
                            try
                            {
                                answer = answer.Substring(0, i) + chars + answer.Substring(i + 1);
                            }
                            catch (Exception e)
                            {}                                              
                    }
                    ++c;
                    if (c == word.Length && b == 0)
                        mistakes++;
                }
                } while (answer.Contains("-")) ;
            Console.WriteLine(word);
            Console.WriteLine("");
            Console.WriteLine("Udało się!");
                Console.ReadKey();
            }
         }
    }
