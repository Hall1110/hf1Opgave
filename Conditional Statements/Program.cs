namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AbsoluteValue(6832));
            //Console.WriteLine(AbsoluteValue(-392));
            //Console.WriteLine(DivisibleBy(15, 30));
            //Console.WriteLine(DivisibleBy(2, 90));
            //Console.WriteLine(DivisibleBy(7, 12));
            //Console.WriteLine(IsUppercase("xyz"));
            //Console.WriteLine(IsUppercase("DOG"));
            //Console.WriteLine(IsUppercase("l9#"));
            //Console.WriteLine(IfGreaterThanThird([2, 7, 12]));
            //Console.WriteLine(IfGreaterThanThird([-5, -8, 50]));
            //Console.WriteLine(IsNumberEven(721));
            //Console.WriteLine(IsNumberEven(1248));
            //Console.WriteLine(IfSortedAscending([3, 7, 10]));
            //Console.WriteLine(IfSortedAscending([74, 62, 99]));
            //Console.WriteLine(PositiveNegativeOrZero(5.24));
            //Console.WriteLine(PositiveNegativeOrZero(0.0));
            //Console.WriteLine(PositiveNegativeOrZero(-994.53));
            //Console.WriteLine(IfLeapYear(2016));
            //Console.WriteLine(IfLeapYear(2018));
            //Console.WriteLine(IfLeapYear(2000));
        }



        static int AbsoluteValue(int a)
        {
            if (a < 0)
            {
                return a * -1;
            }
            else
            {
                return a;
            }
        }
    


        static decimal DivisibleBy(decimal a, decimal b)
        {
            if (a % 2 == 0 && b % 2 == 0)
            {
                return a * b;
            }
            else if (a % 3 == 0 && b % 3 == 0)
            {
                return a * b;
            }
            else
            {
                return a + b;
            }
        }



        static bool IsUppercase(string a)
        {
            
            foreach (char b in a)
            {
                if (!Char.IsUpper(b))
                {
                    return false;
                }

            }
                return true;
        }



        static bool IfGreaterThanThird(int[] a)
        {
            int multiplication = a[0] * a[1];
            int addition = a[0] + a[1];
            if (multiplication > a[2] || addition > a[2])
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        static bool IsNumberEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        static bool IfSortedAscending(int[] a)
        {
            int arrayLength = a.Length;
            for (int i = 1; i < arrayLength; i++)
            {
                if (a[i] < a[i - 1])
                {
                    return false;
                }
            }
                 return true;
        }



        static string PositiveNegativeOrZero(double a)
        {
            if (a < 0)
            {
                return "Negative";
            }
            else if (a == 0)
            {
                return "Zero";
            }
            else
            {
                return "Positive";
            }
        }



        static bool IfLeapYear(int a)
        {
            
            if (a % 4 == 0)
            {
                if (a % 4 == 0 && a % 100 == 0)
                {
                    if(a % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}