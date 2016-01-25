import util
import time
startTime = time.time()

a = 1
b = 0
n = 1
while len(str(a)) != 1000:
  a, b = a+b, a
  n = n + 1
print(str(a) + " has 1000 digits, n = ", str(n))

print("Run Time = " + str(time.time() - startTime))