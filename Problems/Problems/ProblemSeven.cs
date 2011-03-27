using System;
using System.Collections.Generic;

namespace Problems.Tests
{
    public class ProblemSeven
    {
        private static List<long> _Primes = new List<long> {2, 3, 5, 7};

        private static void FindPrimesUpToOrdinal(int numberOfPrimes)
        {
            while (_Primes.Count < numberOfPrimes)
            {
                long candidate = _Primes[_Primes.Count - 1] + 1;
                while (true)
                {
                    bool isPrime = true;
                    foreach (long prime in _Primes)
                    {
                        if (candidate % prime == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        _Primes.Add(candidate);
                        break;
                    }
                    candidate++;
                }
            }
        }

        public List<long> GetFirstPrimes(int numberOfPrimes)
        {
            FindPrimesUpToOrdinal(numberOfPrimes);
            return _Primes.GetRange(0, numberOfPrimes);
        }

        public long GetPrime(int numberOfPrimes)
        {
            FindPrimesUpToOrdinal(numberOfPrimes);
            return _Primes[numberOfPrimes - 1];
        }
    }
}