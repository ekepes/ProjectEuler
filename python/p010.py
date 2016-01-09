upperBound = 2000000
sieve = [0] * upperBound
value = 3
total = 2
while value < upperBound:
    if sieve[value] == 0:
        total += value
        i = value
        while i < upperBound:
            sieve[i] = 1
            i += value
    value += 2
print (total)