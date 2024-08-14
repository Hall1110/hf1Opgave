namespace Basic
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AddAndMultiply(2, 4, 5));
            Console.WriteLine(CelciusToFahrenheit(50));
            Console.WriteLine(CelciusToFahrenheit(10));
            //Console.WriteLine(CelciusToFahrenheit(-300));
            //ElementaryOperations(3, 8);
            //Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            //Console.WriteLine(IsResultTheSame(9 / 3, 16 - 1));
            //Console.WriteLine(ModuloOperations(8, 5, 2));
            //Console.WriteLine(CubeOf(2));
            //Console.WriteLine(CubeOf(-5.5));
            //SwapTwoNumbers(87, 45);
            //SwapTwoNumbers(-13, 2);
        }
 
        
        
        static int AddAndMultiply(int a, int b, int c)
        {
            return (a + b) * c;
        }



        public static string CelciusToFahrenheit(double celcius)
        {
            double fahrenheit = celcius * 1.8 + 32;
            string message;
            if (fahrenheit < -459)
            {
                message = "Temperature below absolute zero!";
                return message;
            }
            else
            {
                message = "C = " + fahrenheit + "F";
                return message;
            }
        }



        static void ElementaryOperations(int a, int b)
        {
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division;
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Divide by 0 Error");
                division = 0;
            }
            else
            {
                division = a / b;
            }
            int[] operations = [addition, subtraction, multiplication, division];
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine(operations[i]);
            }
        }



        static bool IsResultTheSame(int a, int b)
        {
            return (a == b);
        }



        static int ModuloOperations(int a, int b, int c)
        {
            int result = a % b % c;
            return result;
        }



        static double CubeOf(double a)
        {
            return a * a * a;
        }



        static void SwapTwoNumbers(int a, int b)
        {
            Console.WriteLine("Before: a = " + a + ", b = " + b);
            int c = b;
            b = a;
            a = c;
            Console.WriteLine("After: a = " + a + ", b = " + b);
        }
    }
}