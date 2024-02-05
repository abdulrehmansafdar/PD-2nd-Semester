using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace shitori
{
    internal class shiritori
    {
        public List<string> Words;
        public bool GameOver;

        public shiritori()
        {
            Words = new List<string>();
            GameOver = false;
        }

        public List<string> Play(string word)
        {
            if (!GameOver)
            {
                if (Words.Count == 0 || Char.ToLower(word[0]) == Char.ToLower(Words[Words.Count - 1][Words[Words.Count - 1].Length - 1]) && !Words.Contains(word.ToLower()))
                {
                    Words.Add(word.ToLower());
                    return Words;
                }
                else
                {
                    GameOver = true;
                    Console.WriteLine("Game over");
                    Console.ReadKey();
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Game over");
                Console.ReadKey();
                return null;
            }
        }

        public string Restart()
        {
            Words.Clear();
            GameOver = false;
            return "Game restarted";
        }
    }
}
