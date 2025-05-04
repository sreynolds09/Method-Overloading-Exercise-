namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }
        public static string Add(int numOne, int numTwo, bool isMoney)
        {
            var sum = numOne + numTwo;

            if (isMoney && sum > 1)
            {
                return $"{sum} Dollars";
            }
            else if (isMoney && sum == 1)
            {
                return $"{sum} Dollar";
            }
            else
            {
                return sum.ToString();
            }   
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(numOne: 0, numTwo: 1, isMoney: true));
        }
    }
}
