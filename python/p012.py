from functools import reduce

def triangle():
  i = 1
  t = 1
  while True:
    yield t
    i += 1
    t += i

def factors(n):
  return set(reduce(list.__add__,
    ([i, n//i] for i in range(1, int(n**0.5) + 1) if n % i == 0)))

g = triangle()
factorCount = 0
while True:
  value = next(g)
  factorCount = len(factors(value))
  if factorCount > 500:
    print(value)
    break