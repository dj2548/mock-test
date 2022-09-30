namespace MOCK_TESR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Same(10, 10));
            Console.WriteLine(Same(10, 5));

            Console.WriteLine(Subtract (17,7));
            Console.WriteLine(Subtract(20, 8));

            Console.WriteLine(Building(10));
            Console.WriteLine(Building(50));
            Console.WriteLine();
        
        }


        public static bool Same(int num1, int num2)
        {

            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Subtract(double num1, double num2)
        {
        double result = num1 - num2;
            return result;

        }
        public static string Building(int floors) 
        {
             if (floors <= 3)
            {
                return "This is a House!";
            }
            else if (floors >= 4 && floors <= 10)
            {
                return "this is an office building!";
            }
            else if (floors >= 11 && floors <= 49)
            {
                return "tihs is a skyscraper!";
            }
            else 
            {
                return "this is a Super skyscraper!";
            }
        }
    }
}