import math

primes = [2, 3, 5, 7]
result = sum(primes)

upperBound = 100000
candidate = primes[-1]

while candidate < upperBound:
  foundPrime = False
  stopValue = int(math.sqrt(candidate)+1)
  while not foundPrime:
    isPrime = True
    for p in primes:
      if candidate % p == 0:
        isPrime = False
        break
      if p > stopValue:
        break

    if isPrime:
      primes.append(candidate)
      result += candidate
      foundPrime = True
    else:
      candidate += 1

print (result)