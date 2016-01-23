import time
startTime = time.time()

def scoreName(name):
  total = 0
  for c in name:
    total += ord(c) - 64
  return total

f = open('p022_names.txt', 'r')
data = f.read().replace("\"","")
names = data.split(",")
names.sort()

count = 1
total = 0
for name in names:
  total += scoreName(name) * count
  count += 1

print(total)

print("Run Time = " + str(time.time() - startTime))