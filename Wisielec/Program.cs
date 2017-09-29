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
                for (int i = 0; i <= word.Length; i++)
                {
                    answer = answer + "-";
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd.");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }



            do
            {
                char[] wchar = word.ToCharArray();
                Console.WriteLine(answer);
                Console.WriteLine("Ilość błędów: {0}", mistakes);
                Console.WriteLine("Podaj literę: ");
                char[] chars = Console.ReadLine().ToCharArray();

                if (word.ToLower().Contains(chars[1]))
                {
                    for (int i = 0; i <= word.Length; i++)
                    {
                        if (wchar[i] == chars[1])
                        {
                            
                        }
                        else
                        {
                            mistakes++;
                        }
                    }
                }
            } while (answer.ToLower().Contains("_") == false);
        }
    }
}
