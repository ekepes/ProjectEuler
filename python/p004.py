def reverse(value):
  return int(str(value)[::-1])

def isPalindrome(value):
  return value == reverse(value)

def largestNumberWithDigits(value):
  result = ""
  for x in range(value):
    result = result + "9"
  return int(result)

def solve(value):
  start = largestNumberWithDigits(value)
  finish = start - largestNumberWithDigits(value - 1)
  result = 0

  for first in range(start, finish, -1):
    for second in range(first, finish, -1):
      trial = first * second
      if isPalindrome(trial) and trial > result:
        result = trial

  return result