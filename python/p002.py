def fib(n):
  if n == 0:
    return 0
  elif n == 1:
    return 1
  else:
    return fib(n-1) + fib(n-2)

previous = 0
current = 1
totalEven = 0

while current < 4000000:
  current = previous + current
  previous = current - previous

  if current % 2 == 0:
    totalEven = totalEven + current

print "Final answer: %d" % totalEven
