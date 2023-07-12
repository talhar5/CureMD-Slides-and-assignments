using System;

namespace Project_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string input = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Word Frequency Counter");
                Console.WriteLine("2. Sentence Generator");
                Console.WriteLine("3. Shortest and Longest Word");
                Console.WriteLine("4. Search Word");
                Console.WriteLine("5. Palindrome Detector");
                Console.WriteLine("6. Vowel and Consonant Counter");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        WordFrequencyCounter(input);
                        break;
                    case 2:
                        SentenceGenerator(input);
                        break;
                    case 3:
                        ShortestLongest(input);
                        break;
                    case 4:
                        SearchWord(input);
                        break;
                    case 5:
                        PalindromeDetector(input);
                        break;
                    case 6:
                        VowelConsonants(input);
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
        static void WordFrequencyCounter(string InputUser)
        {
            int WordCount = 1;


            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] == ' ')
                {
                    WordCount++;
                }
            }

            string[] WordArray = new string[WordCount];
            int position = 0;

            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] != ' ')
                {
                    if (WordArray[position] == null)
                    {
                        WordArray[position] = "";
                    }

                    WordArray[position] += InputUser[i];
                }
                else
                {
                    position++;
                }
            }

            int[] frequency = new int[WordCount];
            for (int i = 0; i < WordCount; i++)
            {
                string tempo = WordArray[i];
                if (tempo != null)
                {
                    for (int j = i; j < WordCount; j++)
                    {
                        if (WordArray[j] == tempo)
                        {
                            frequency[i]++;
                            WordArray[j] = null; // Set the repeated word as empty
                        }
                    }

                    Console.WriteLine("The frequency of word '{0}' = {1}", tempo, frequency[i]);
                }
            }
        }
        static void SentenceGenerator(string InputUser)
        {
            Console.WriteLine("enter the number of sentences to be generates");
            int N = Convert.ToInt32(Console.ReadLine());
            int WordCount = 1;


            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] == ' ')
                {
                    WordCount++;
                }
            }

            string[] WordArray = new string[WordCount];
            int position = 0;

            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] != ' ')
                {
                    if (WordArray[position] == null)
                    {
                        WordArray[position] = "";
                    }

                    WordArray[position] += InputUser[i];
                }
                else
                {
                    position++;
                }
            }
            Random rnd = new Random();
            string[] sentence = new string[N];
            for (int i = 0; i < N; i++)
            {
                sentence[i] = "";
                for (int j = 0; j < 5; j++)
                {
                    sentence[i] += WordArray[rnd.Next(WordCount)] + ' ';
                }
                Console.WriteLine(sentence[i]);
            }
        }
        static void ShortestLongest(string InputUser)
        {
            int WordCount = 1;
            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] == ' ')
                {
                    WordCount++;
                }
            }

            string[] WordArray = new string[WordCount];
            int position = 0;

            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] != ' ')
                {
                    if (WordArray[position] == null)
                    {
                        WordArray[position] = "";
                    }

                    WordArray[position] += InputUser[i];
                }
                else
                {
                    position++;
                }
            }
            string longest = "";
            string shortest = "";
            for (int i = 0; i < WordArray.Length; i++)
            {
                for (int j = 0; j < WordArray.Length; j++)
                {
                    if (WordArray[i].Length > WordArray[j].Length)
                    {
                        shortest = WordArray[j];
                    }
                    if (WordArray[i].Length < WordArray[j].Length)
                    {
                        longest = WordArray[j];
                    }
                }

            }
            Console.WriteLine("the shortest word is given by:" + shortest);
            Console.WriteLine("the longest word is given by:" + longest);

        }
        static void SearchWord(string InputUser)

        {
            Console.WriteLine("Write the word to be searched in the text");
            string Search = Console.ReadLine();
            int WordCount = 1;
            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] == ' ')
                {
                    WordCount++;
                }
            }

            string[] WordArray = new string[WordCount];
            int position = 0;

            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] != ' ')
                {
                    if (WordArray[position] == null)
                    {
                        WordArray[position] = "";
                    }

                    WordArray[position] += InputUser[i];
                }
                else
                {
                    position++;
                }
            }
            for (int i = 0; i < WordArray.Length; i++)
            {
                if (Search == WordArray[i])
                {
                    Console.WriteLine(" the input is present at index  " + (i + 1));
                }
            }

        }
        static void PalindromeDetector(string InputUser)
        {
            int WordCount = 1;
            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] == ' ')
                {
                    WordCount++;
                }
            }

            string[] WordArray = new string[WordCount];
            int position = 0;

            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] != ' ')
                {
                    if (WordArray[position] == null)
                    {
                        WordArray[position] = "";
                    }

                    WordArray[position] += InputUser[i];
                }
                else
                {
                    position++;
                }
            }
        }
        static void VowelConsonants(string InputUser)
        {
            int WordCount = 1;
            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] == ' ')
                {
                    WordCount++;
                }
            }

            string[] WordArray = new string[WordCount];
            int position = 0;

            for (int i = 0; i < InputUser.Length; i++)
            {
                if (InputUser[i] != ' ')
                {
                    if (WordArray[position] == null)
                    {
                        WordArray[position] = "";
                    }

                    WordArray[position] += InputUser[i];
                }
                else
                {
                    position++;
                }
            }
            string vowel = "aeiou";
            int vowelcount = 0;
            int consonantcount = 0;
            int spaces = 0;
            for (int i = 0; i < InputUser.Length; i++)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (InputUser[i] == vowel[j])
                    {
                        vowelcount++;
                    }
                }
                if (InputUser[i] == ' ')
                {
                    spaces++;
                }

            }
            consonantcount = InputUser.Length - spaces - vowelcount;
            Console.WriteLine(vowelcount);
            Console.WriteLine(consonantcount);

        }
    }
}