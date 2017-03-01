using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppPriemgetallen
{
    class PrimeNumberGenerator
    {
        public static List<int> GeneratePrimeNumbers(int n)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);

            int nextPrime = 3;

            while (primeNumbers.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;

                for (int i = 0; (int)primeNumbers[i] <= sqrt; i++)
                {
                    if (nextPrime % primeNumbers[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(nextPrime);
                }

                nextPrime += 2;
            }
  
            return primeNumbers;
        }
    }
}