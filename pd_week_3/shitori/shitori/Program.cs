using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shiritori myShiritori = new shiritori();

            while (!myShiritori.GameOver)
            {
                Console.Write("Enter a word: ");
                string userInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    var result = myShiritori.Play(userInput);
                    if (result != null)
                    {
                        Console.WriteLine($"Current words: {string.Join(", ", result)}");
                    }
                }
            }

            Console.WriteLine(myShiritori.Restart());
        }
    }
}
