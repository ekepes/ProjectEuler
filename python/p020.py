def factorial(x):
  if x == 1:
    return 1
  return x * factorial(x-1)

digits = str(factorial(100))
total = 0
for d in digits:
  total += int(d)

print(total)