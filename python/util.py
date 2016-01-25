from functools import reduce

def factors(n):
  return set(reduce(list.__add__,
    ([i, n//i] for i in range(1, int(n**0.5) + 1) if n % i == 0)))

def primeFactors(x):
  factorlist=[]
  loop=2
  while loop<=x:
    if x%loop==0:
      x/=loop
      factorlist.append(loop)
    else:
      loop+=1
  return factorlist

def uniquePrimeFactors(x):
  factorlist = primeFactors(x)
  refinedList = [1]
  for item in factorlist:
    if not item in refinedList:
      refinedList.append(item)
  return refinedList

def fib(n):
  if n == 0:
    return 0
  elif n == 1:
    return 1
  else:
    return fib(n-1) + fib(n-2)