using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AlgorthimQuestionsn 
{
    public class Algorithm
    {

        public static void GetVowelPositions()
        {

            string text = "Hello WORLD";
            List<int> results = GetVowelPositions(text);
            string finalResult = "";
            for (int i = 0; i < results.Count; i++)
            {
                finalResult += results[i] + ", ";
            }
            Console.WriteLine($"Vowels: {finalResult}");


        }
        public static List<int> GetVowelPositions(string s)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            List<int> vowelsPositions = [];
            for (int i = 0; i < s.Length; i++)
            {
                foreach (char vowel in vowels)
                {
                    if (s[i] == vowel)
                    {
                        vowelsPositions.Add(i);
                    }
                }
            }
            return vowelsPositions;

        }
        public static string ShiftLetters(string inputString)
        {
            char[] newChars = new char[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];

                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    newChars[i] = (currentChar == 'z') ? 'a' : (char)(currentChar + 1);
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    newChars[i] = (currentChar == 'Z') ? 'A' : (char)(currentChar + 1);
                }
                else
                {
                    newChars[i] = currentChar;

                }
            }
            return new string(newChars);
        }
        public static string TransformCase(string inputString)
        {
            char[] stringInput = new char[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                char availableChar = inputString[i];
                if (availableChar >= 'a' && availableChar <= 'z')
                {
                    stringInput[i] = (char)(availableChar - ('a' - 'A'));

                }
                else if (availableChar >= 'A' && availableChar <= 'Z')
                {
                    stringInput[i] = (char)(availableChar + ('z' - 'Z'));
                }
                else
                {
                    stringInput[i] = availableChar;
                }
            }
            return new string(stringInput);



        }
        public static string ReplaceCharater(string inputString, char c1, char c2)
        {
            List<char> inputList = new List<char>();
            foreach (char c in inputString)
            {
                if (c == c1)
                {
                    inputList.Add(c2);
                }
                else
                {
                    inputList.Add(c);
                }
            }
            return new string(inputList.ToArray());
        }
       public static string SwapPairs(string s)
        {
          char[] swapped = new char[s.Length];
          for(int i = 0; i < s.Length -1; i += 2)
          {
            swapped[i] = s[i + 1];
            swapped[i |+ 1] = s[i];
          }
          if(s.Length % 2 != 0)
          {
            swapped[s.Length - 1] = s[s.Length - 1];

          }
          return new string(swapped);
        }
    }
}



