import util
import time
startTime = time.time()

digits = ["0", "1", "2"]
permutations = []
for digit1 in digits:
  remaining1 = digits[:]
  remaining1.remove(digit1)
  for digit2 in remaining1:
    remaining2 = remaining1[:]
    remaining2.remove(digit2)
    for digit3 in remaining2:
      print(digit1 + digit2 + digit3)


print("Run Time = " + str(time.time() - startTime))