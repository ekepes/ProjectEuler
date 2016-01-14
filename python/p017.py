singles = {
  1:"one",
  2:"two",
  3:"three",
  4:"four",
  5:"five",
  6:"six",
  7:"seven",
  8:"eight",
  9:"nine" }
tens = {
  20:"twenty",
  30:"thirty",
  40:"forty",
  50:"fifty",
  60:"sixty",
  70:"seventy",
  80:"eighty",
  90:"ninety"}
teens = {
  10:"ten",
  11:"eleven",
  12:"twelve",
  13:"thirteen",
  14:"fourteen",
  15:"fifteen",
  16:"sixteen",
  17:"seventeen",
  18:"eighteen",
  19:"nineteen"}

def SplitIntoDigits(number):
  singlesDigit = number % 10
  tensDigit = int((number % 100 - singlesDigit) / 10)
  hundredsDigit = int((number % 1000 - tensDigit - singlesDigit) / 100)
  thousandsDigit = int((number % 10000 - hundredsDigit - tensDigit - singlesDigit) / 1000)

  return (thousandsDigit, hundredsDigit, tensDigit, singlesDigit)

def NumberInWords(digitsTuple):
  words = ""
  if digitsTuple[0] > 0:
    words += singles[digitsTuple[0]] + " thousand "
  if digitsTuple[1] > 0:
    words += singles[digitsTuple[1]] + " hundred "
    if digitsTuple[2] > 0 or digitsTuple[3] > 0:
        words += "and "
  if digitsTuple[2] == 1:
    words += teens[digitsTuple[2] * 10 + digitsTuple[3]]
  else:
    if digitsTuple[2] > 1:
      words += tens[digitsTuple[2] * 10]
      if digitsTuple[3] > 0:
        words += "-"
    if digitsTuple[3] > 0:
      words += singles[digitsTuple[3]]

  return words.replace("  ", " ").strip()

def LetterCount(word):
  return len(word.replace(" ", "").replace("-", ""))

total = 0
for i in range(1, 1001):
  total += LetterCount(NumberInWords(SplitIntoDigits(i)))

print (total)