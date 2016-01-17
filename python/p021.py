from functools import reduce
import time
startTime = time.time()

def factors(n):
  result = set(reduce(list.__add__,
    ([i, n//i] for i in range(1, int(n**0.5) + 1) if n % i == 0)))
  result.remove(n)
  return result

def sumOfFactors(n):
  total = 0
  for i in factors(n):
    total += i
  return total


total = 0
for i in range(2, 10000):
  x = sumOfFactors(i)
  if x != i:
    y = sumOfFactors(x)
    if (y == i):
      total += i

print(total)
print("Run Time = " + str(time.time() - startTime))