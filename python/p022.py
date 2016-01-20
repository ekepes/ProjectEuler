import time
startTime = time.time()

f = open('p022_names.txt', 'r')
data = f.read()

print(data)

print("Run Time = " + str(time.time() - startTime))