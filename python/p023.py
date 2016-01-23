import time
import util
startTime = time.time()

'''
Find all abundant numbers
Create and mark all number which can be created as the sum of two abundant numbers
Sum up all non-marked numbers
'''

def factorSum(x):
  return (sum(util.factors(x)) - x)

def isAbundant(x):
  return factorSum(x) > x

def debug(x):
  print(x, util.factors(x), factorSum(x), isAbundant(x))

print("Finding abundantNumbers")
limit = 28124
abundantNumbers = []
for i in range(1, limit):
  if isAbundant(i):
    abundantNumbers.append(i)
print("Run Time (so far)= " + str(time.time() - startTime))

print("Building up list of the possible")
possible = []
for i in range(limit):
  possible.append(i)
print("Run Time (so far)= " + str(time.time() - startTime))

print("Filtering out the impossible")
for a in range(len(abundantNumbers)):
  for b in range(a, len(abundantNumbers)):
    x = abundantNumbers[a] + abundantNumbers[b]
    if x < limit:
      #print("Removing: ", x)
      possible[x] = 0
print("Run Time (so far)= " + str(time.time() - startTime))

print("Calculating total")
total = sum(possible)

print(total)

print("Run Time = " + str(time.time() - startTime))

#print(abundantNumbers)
#print(possible)