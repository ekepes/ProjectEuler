def solve(value):
  sumOfSquares = 0
  squareOfSums = 0
  for x in range(1, value + 1):
    sumOfSquares = sumOfSquares + (x ** 2)
    squareOfSums = squareOfSums + x

  squareOfSums = squareOfSums ** 2
  return squareOfSums - sumOfSquares