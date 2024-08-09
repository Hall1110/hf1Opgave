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
            Console.WriteLine(RevertWordsOrder("John Doe."));
            Console.WriteLine(RevertWordsOrder("A, B. C"));
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
            int inputStringLength = inputString.Length;
            int lastIndex = inputStringLength - 1;
            int firstLetterIndex, lastLetterIndex;
            string outputString;
            char[] inputCharArray = inputString.ToCharArray();
            bool foundFirstLetter, foundLastLetter = false;


            for (int i = 0; i < inputStringLength; i++)
            {
                if (inputCharArray[i] != '.' && !foundFirstLetter)
                {

                }

            
            }
            return outputString;
        }
    }
}