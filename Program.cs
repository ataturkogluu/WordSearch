namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" };

            Console.Write("Enter a word to search: ");
            string searchTerm = Console.ReadLine();

            Console.WriteLine("Matching words:");
            foreach (string word in words)
            {
                if (WordContains(word, searchTerm))
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadLine();
        }

        static bool WordContains(string word, string searchTerm)
        {
            int searchTermLength = searchTerm.Length;

            for (int i = 0; i <= word.Length - searchTermLength; i++)
            {
                bool match = true;

                for (int j = 0; j < searchTermLength; j++)
                {
                    if (char.ToLower(word[i + j]) != char.ToLower(searchTerm[j]))
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
