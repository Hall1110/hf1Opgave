namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultiplicationTable();
            //Console.WriteLine(BiggestNumber([190, 291, 145, 209, 280, 200]));
            //Console.WriteLine(BiggestNumber([-9, -2, -7, -8, -4]));
            //Console.WriteLine(TwoSevensNextToEachOther([8, 2, 5, 7, 9, 0, 7, 7, 3, 1]));
            //Console.WriteLine(TwoSevensNextToEachOther([9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7]));
            //Console.WriteLine(ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82]));
            //Console.WriteLine(ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4]));
            //Console.WriteLine(string.Join(", ", SieveOfEratosthenes(30)));
            //Console.WriteLine(ExtractString("##abc##def"));
            //Console.WriteLine(ExtractString("12####78"));
            //Console.WriteLine(ExtractString("gar##d#en"));
            //Console.WriteLine(ExtractString("++##--##++"));
            //Console.WriteLine(FullSequenceOfLetters("ds"));
            //Console.WriteLine(FullSequenceOfLetters("or"));
            Console.WriteLine(SumAndAverage(11, 66));
            Console.WriteLine(SumAndAverage(-10, 0));
        }




        static void MultiplicationTable()
        {
            int Table = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Table = i * j;
                    Console.Write(Table + " ");
                }
                Console.WriteLine("");
            }

        }



        static int BiggestNumber(int[] a)
        {
            int largestNumber = a[0];
            int arrayLength = a.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                if (a[i] > largestNumber)
                {
                    largestNumber = a[i];
                }
            }
            return largestNumber;

        }



        static int TwoSevensNextToEachOther(int[] a)
        {
            int counter = 0;
            int arrayLength = a.Length;

            for (int i = 1; i < arrayLength; i++)
            {
                if (a[i] == a[i - 1])
                {
                    counter++;
                }
            }
            return counter;
        }



        static bool ThreeIncreasingAdjacent(int[] a)
        {
            int arrayLength = a.Length;
            for (int i = 2; i < arrayLength; i++)
            {
                int currentNumber = a[i - 2];
                int secondNumber = a[i - 1];
                int thirdNumber = a[i];

                if (currentNumber + 1 == secondNumber && currentNumber + 2 == thirdNumber)
                {
                    return true;
                }
            }
            return false;
        }



        static int[] SieveOfEratosthenes(int a)
        {
            int[] PrimeNumbers = new int[a];
            int index = 0;
            for (int i = 2; i <= a; i++)
            {
                if (IsPrime(i))
                {
                    PrimeNumbers[index] = i;
                    index++;
                }
            }
            int[] NoEmptyIndexesPrimeNumbers = new int[index];
            Array.Copy(PrimeNumbers, NoEmptyIndexesPrimeNumbers, index);
            return NoEmptyIndexesPrimeNumbers;
        }

        static bool IsPrime(int a)
        {
            if (a <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }



        static string ExtractString(string a)
        {
            int length = a.Length;
            bool firstHashFound = false;
            bool secondHashFound = false;
            bool thirdHashFound = false;
            bool fourthHashFound = false;
            int startingPoint = 0;
            int endingPoint = 0;
            string outputString = "";

            for (int i = 0; i < length; i++)
            {
                if (!firstHashFound && a[i] == '#')
                {
                    firstHashFound = true;
                    continue;
                }
                if (!secondHashFound && firstHashFound && a[i] == '#')
                {
                    secondHashFound = true;
                    startingPoint = i + 1;
                    continue;
                }
                if (!thirdHashFound && a[i] == '#')
                {
                    thirdHashFound = true;
                    continue;
                }
                if (!fourthHashFound && thirdHashFound && a[i] == '#')
                {
                    fourthHashFound = true;
                    endingPoint = i - 1;
                    return a.Substring(startingPoint, endingPoint - startingPoint);
                }
            }
            return outputString;
        }



        static string FullSequenceOfLetters(string a)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int alphabetLength = alphabet.Length;
            int startingLetter = a[0];
            int endingLetter = a[1];
            int startingIndex = 0;
            int endingIndex = 0;
            for (int i = 0; i < alphabetLength; i++)
            {
                if (startingLetter == alphabet[i])
                {
                    startingIndex = i;
                }
                if (endingLetter == alphabet[i])
                {
                    endingIndex = i;
                }
            }
            return alphabet.Substring(startingIndex, endingIndex - startingIndex);
        }



        static string SumAndAverage(int a, int b)
        {
            int sum = a;
            int counter = 0;
            int average = 0;
            int range = b;
            for (int i = a; i < range; i++)
            {
                sum += i;
                counter++;
            }

            average = sum / counter;
            return $"Sum: {sum}, average {average}";
        }


        static string DrawTriangle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                }
            }
        }
    }
}
