using System;

namespace SO_Exercises26._27._28_4._21._2021
{
    class Program
    {
        //EXERCISE 26: Prompt the user to enter text. Count and output how many vowels were in the string.

        static void Main(string[] args)
        {
            bool keepLoop = true;

            while (keepLoop == true)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                
                int vowels = ReturnVowelsInString(name.ToLower());
                Console.WriteLine($"Number of vowels in your name: {vowels}");

                int consos = ReturnConsonantsInString(name.ToLower());
                Console.WriteLine($"Number of consonants in your name: {consos}");

                string noVowels = RemoveVowels(name.ToLower());
                Console.WriteLine($"Name without vowels: {noVowels}");

                Console.WriteLine("Do you want to continue? Y or N");
                string userContinue = Console.ReadLine();

                if (userContinue == "y")
                {
                    continue;
                }
                break;
            } 

            

        }

        public static int ReturnVowelsInString(string userInput)
        {
             // i = index --- so starting at index 0 (first character), if the index is less than the length of the word, check if these vowels are present
            //at that specific index. If they are, tally them up. 
            int vowel = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u')
                {
                    vowel++;
                    //adding 1 to the variable vowel as i moves through each index and finds a vowel. 
                    
                }

            }
            return vowel;
        }

        // EXERCISE 27: Prompt the user to enter text. Count and output how many consonants were in the string.

        public static int ReturnConsonantsInString(string userInput)
        {
            int conso = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] != 'a' && userInput[i] != 'e' && userInput[i] != 'i' && userInput[i] != 'o' && userInput[i] != 'u')
                {
                    conso++;
                                        
                }
            }
            return conso;
        }

        //Exercise 28: Prompt the user to enter text. Remove vowels & output the text.

        public static string RemoveVowels(string word)
        {
            string wordWithoutVowels = word.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
            return wordWithoutVowels;
        }

        //string vowels = aeiou;
        //aeiou[0], aeiou[1]

    }
}
