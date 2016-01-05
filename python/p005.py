# find prime factors of a number
def primefactors(x):
  factorlist=[]
  loop=2
  while loop<=x:
    if x%loop==0:
      x/=loop
      factorlist.append(loop)
    else:
      loop+=1
  return factorlist

def getfactordict(x):
  factors = primefactors(x)
  d = {}
  for factor in factors:
    if factor in d:
      d[factor] += 1
    else:
      d[factor] = 1
  return d

def mergedict(d1, d2, count=100):
  result = {}
  for x in range(count):
    x1 = 0
    x2 = 0
    if x in d1:
      x1 = d1[x]
    if x in d2:
      x2 = d2[x]
    if x1 > 0 or x2 > 0:
      result[x] = max(x1, x2)

  return result

def getparts(value):
  result = {}
  for x in range(value):
    factors = getfactordict(x)
    result = mergedict(result, factors)

  return result

def solve(value):
  total = 1
  work = getparts(value)
  for base, exponent in work.items():
    total = total * (base ** exponent)

  return total

print("The answer is %d" % solve(20))