namespace MethodOverloading
{
    public class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal decNum1, decimal decNum2)
        {
            return decNum1 + decNum2;
        }

        static string Add(int num1, int num2, bool truth)
        {
            var sum = num1 + num2;
            if (truth)
            {
                switch (sum)
                {
                    case 1:
                        return $"{sum} dollar";
                    default:
                        return $"{sum} dollars";
                }
            }

            return sum.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{Add(1, 2)}, {Add(1.0m, 3.0m)}, and {Add(1, 0, !(Math.Sqrt(4) == Math.Sqrt(18)/2))}."); 
        }
    }
}
