import math

def LatticePath(down, right):
  return int(math.factorial(down + right) / (math.factorial(down)**2))

print(LatticePath(20,20))