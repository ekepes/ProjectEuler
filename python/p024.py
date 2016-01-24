import util
import time
startTime = time.time()

digits = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
count = 0
desired = 1000000

def blah(soFar, remainingDigits):
  global count, desired
  if len(remainingDigits) == 0:
    count += 1
    if count == desired:
      print(soFar)
  else:
    for digit in remainingDigits:
      rest = remainingDigits[:]
      rest.remove(digit)
      blah(soFar + digit, rest)

blah("", digits)

print(count)

print("Run Time = " + str(time.time() - startTime))