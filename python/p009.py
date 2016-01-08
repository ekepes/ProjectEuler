import math
#3,4,5

def Solve(sumOfSides = 12):
  for a in range(1, sumOfSides):
    for b in range(1, sumOfSides):
      c = math.sqrt((a ** 2) + (b ** 2))
      if a + b + c == sumOfSides:
        c = int(c)
        print ("a, b, c, result:", a, b, c, a*b*c)
        return a*b*c

print (Solve(1000))