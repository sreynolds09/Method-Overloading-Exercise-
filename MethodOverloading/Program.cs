using System.Net.Sockets;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(numOne: 2, numTwo: 1, isMoney: true));
            
            var x = 2;
            var y = 55;
			
            var answer = Add(x, y);
			
            var a = 3.40m;
            var b = 45.9m;
			
            var decimalAnswer = Add(a,b);
			
            var thirdAnswer = Add(0, 0, true);
			
            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
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
   
        
    }
}
