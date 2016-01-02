from math import sqrt, ceil

n = 600851475143
i = 2

# eliminate perfect squares since they throw off the other algorithm
r = sqrt(n)
while r == ceil(r):
  n = int(r)
  r = sqrt(n)

# divide by possible factors
# this could be more efficient if we had the prime numbers, but that
# is more work than it is worth
while i * i < n:
  while n%i == 0:
    n = n / i
  i = i + 1

if (i * i == n):
  n = i

print (n)