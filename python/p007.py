primes = [2, 3, 5, 7]

def GetnthPrime(n):
  if n <= 0:
    print ("Sequences cannot have 0 or less elements.")
    return 0

  while len(primes) < n:
    candidate = primes[-1]
    foundPrime = False
    while not foundPrime:
      isPrime = True
      for p in primes:
        if candidate % p == 0:
          isPrime = False
          break

      if isPrime:
        primes.append(candidate)
        foundPrime = True
      else:
        candidate += 1

  return primes[n-1]