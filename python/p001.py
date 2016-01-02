def isMultiple(value):
  if value % 3 == 0 or value % 5 == 0:
    return True
    
  return False

def solveFor(value):
  total = 0
  for x in range(value):
    if isMultiple(x):
      total = total + x

  return total

print solveFor(1000)