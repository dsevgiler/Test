namespace Codeium
{
    public class class1
    {
        // Default constructor

        // Method to find the number of divisors of a given number

        public int FindDivisorCount(int n)
        {

            string s = n.ToString();

            int divisorCount = 0; // Counter for the number of divisors
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) // Check if i is a divisor of n
                {
                    divisorCount++; // Increment the divisor count
                    Console.WriteLine("Divisor found: " + i); // Logging statement



                }

            }
            Console.WriteLine("Total divisors: " + divisorCount); // Logging statement
            return divisorCount; // Return the total number of divisors,

        }

        public int asalsayilaribul(int i)
        {



        }




    }

}
