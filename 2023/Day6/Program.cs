using System.Numerics;

namespace Day6
{
    // ax^2 + bx + c
    //  a is -1
    //  b is the race time in millis
    //  c is the distance to beat times -1
    public static class Program
    {
        static readonly BigInteger a = -1;
        static readonly BigInteger b = 53916768;
        static readonly BigInteger c = -250133010811025;

        // x intercepts give the time (held back) where the boat will win
        //  x = (-b +- sqrt(b * b - 4 a c) ) / 2a

        static BigInteger discriminant = (b * b) - (4 * a * c);
        static BigInteger sqrtOfDiscriminant = Sqrt(discriminant);

        static BigInteger last = ((b * -1) - sqrtOfDiscriminant) / (2 * a);
        static BigInteger first = ((b * -1) + sqrtOfDiscriminant) / (2 * a);

        static BigInteger Sqrt(this BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        private static bool isWithinTrials(BigInteger x)
        {
            // Check if testval is greater than zero in the function x(b - x) + c
            return (x * (b - x) + c) > 0;
        }

        static void Main(string[] args) 
        {
            Console.WriteLine(sqrtOfDiscriminant);
            Console.WriteLine(discriminant);

            Console.WriteLine(string.Format("1 intercept approximation {0}", first));
            Console.WriteLine(string.Format("2 intercept approximation {0}", last));

            Console.WriteLine(string.Format("1 within trials? {0}", isWithinTrials(first)));
            Console.WriteLine(string.Format("2 within trials? {0}", isWithinTrials(last)));

            while(isWithinTrials(first) == false)
            {
                first += 1;
            }

            while (isWithinTrials(last) == true)
            {
                last += 1;
            }

            Console.WriteLine("First trial that succeeds is {0}", first);
            Console.WriteLine("Last trial that succeeds is {0}", last - 1);

            Console.WriteLine(String.Format("Total number of trials that succeed is {0}", last - first));
        }
    }
}