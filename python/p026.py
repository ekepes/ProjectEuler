import util
import time
startTime = time.time()

def findRepeatLength(d):
  remainders = []
  work = 1 % d
  while True:
    if work == 0 or work in remainders:
      return len(remainders)
    remainders.append(work)
    work = (work * 10) % d

longestRepeat = 0
dValue = 0
for d in range(7, 1001):
  repeat = findRepeatLength(d)
  if repeat > longestRepeat:
    longestRepeat = repeat
    dValue = d

print("d=" + str(dValue) + " with repeat length " + str(longestRepeat))

print("Run Time = " + str(time.time() - startTime))