using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Console.WriteLine(AddSeparator("ABCD", "^"));
            //Console.WriteLine(AddSeparator("chocolate", "-"));
            //Console.WriteLine(IsPalindrome("eye"));
            //Console.WriteLine(IsPalindrome("Home"));
            //Console.WriteLine(LengthOfString("computer"));
            //Console.WriteLine(LengthOfString("ice cream"));
            //Console.WriteLine(StringInReverseOrder("qwerty"));
            //Console.WriteLine(StringInReverseOrder("oe93 kr"));
            //Console.WriteLine(NumberOfWords("This is sample sentence"));
            //Console.WriteLine(NumberOfWords("OK"));
            //Console.WriteLine(RevertWordsOrder("John Doe."));
            //Console.WriteLine(RevertWordsOrder("A, B. C"));
            //Console.WriteLine(HowManyOccurrences("do it now", "do"));
            //Console.WriteLine(HowManyOccurrences("empty", "d"));
            //Console.WriteLine(SortCharactersDescending("onomatopoeia"));
            //Console.WriteLine(SortCharactersDescending("fohjwf42os"));
            //Console.WriteLine(CompressString("kkkktttrrrrrrrrrr"));
            //Console.WriteLine(CompressString("p555ppp7www"));

        }



        static string AddSeparator(string inputString, string separator)
        {
            char[] charArray = inputString.ToCharArray();

            string[] stringArray = Array.ConvertAll(charArray, c => c.ToString());

            return String.Join(separator, stringArray);
        }


        static bool IsPalindrome(string s)
        {
            string inputString = s.ToLower();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedInputString = new string(charArray);
            int inputStringLenght = inputString.Length;
            bool matchingLetters = false;

            for (int i = 0; i < inputStringLenght; i++)
            {
                if (inputString[i] == reversedInputString[i])
                {
                    matchingLetters = true;
                }
                else
                {
                    matchingLetters = false;
                }
            }
            return matchingLetters;
        }



        static int LengthOfString(string inputString)
        {
            int counter = 0;
            foreach (char c in inputString)
            {
                counter++;
            }
            return counter;
        }



        static string StringInReverseOrder(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            return reversedString;
        }



        static int NumberOfWords(string inputString)
        {
            int inputStringLength = inputString.Length;
            char whiteSpace = ' ';
            char[] inputCharArray = inputString.ToCharArray();
            int counter = 1;
            
            for (int i = 0; i < inputStringLength; i++)
            {
                if (inputCharArray[i] == whiteSpace)
                {
                    counter++;
                }
            }
            return counter;
        }



        static string RevertWordsOrder(string inputString)
        {
            string[] reversedString = inputString.Split(' ');
            Array.Reverse(reversedString);
            return String.Join(" ", reversedString);
            
        }



        static int HowManyOccurrences(string inputString, string inputSearch)
        {
            int counter = inputString.Split(new string[] { inputSearch }, StringSplitOptions.None).Length - 1;
            return counter;

            //return inputString.Split(new string[] { inputSearch }, StringSplitOptions.None).Length - 1;
        }



        static string SortCharactersDescending(string inputString)
        {
            char[] inputCharArray = inputString.ToCharArray();
            Array.Sort(inputCharArray);
            Array.Reverse(inputCharArray);
            return String.Join("", inputCharArray);
        }




        static string CompressString(string inputString)
        {
            int inputStringLength = inputString.Length;
            int counter = 1;
            char[] inputCharArray = inputString.ToCharArray();
            string outputString = "";

            for (int i = 1; i < inputStringLength; i++)
            {
                if (i == inputStringLength - 1)
                {
                    counter++;
                    outputString += inputCharArray[i - 1];
                    outputString += $"{counter}";
                }
                else if (inputCharArray[i] == inputCharArray[i - 1])
                {
                    counter++;
                }
                else
                {
                    outputString += inputCharArray[i - 1];
                    outputString += $"{counter}";
                    counter = 1;
                }
            }

            return outputString;
        }
    }
}
