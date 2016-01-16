import time
startTime = time.time()

#pyramid = ["03",
#  "07 04",
#  "02 04 06",
#  "08 05 09 03"]
pyramid = ["75",
  "95 64",
  "17 47 82",
  "18 35 87 10",
  "20 04 82 47 65",
  "19 01 23 75 03 34",
  "88 02 77 73 07 63 67",
  "99 65 04 28 06 16 70 92",
  "41 41 26 56 83 40 80 70 33",
  "41 48 72 33 47 32 37 16 94 29",
  "53 71 44 65 25 43 91 52 97 51 14",
  "70 11 33 28 77 73 17 78 39 68 17 57",
  "91 71 52 38 17 14 91 43 58 50 27 29 48",
  "63 66 04 68 89 53 67 30 73 16 69 87 40 31",
  "04 62 98 27 23 09 70 98 73 93 38 53 60 04 23"]

def calculateCummulativeWeight(weight, row, column, nodes):
  left = 0
  right = 0
  if row > 0:
    if column < row:
      right = int(nodes[getKey(row-1, column)])
    if column > 0:
      left = int(nodes[getKey(row-1, column-1)])
  return int(weight) + max(left, right)

def getKey(row, column):
  return row * 1000 + column

def parseLine(row, line, nodes):
  lineNodes = {}
  column = 0
  for item in line.split():
    lineNodes[getKey(row, column)] = calculateCummulativeWeight(item, row, column, nodes)
    column += 1
  return lineNodes

def parsePyramid(pyramid):
  nodes = {}
  row = 0
  for line in pyramid:
    nodes.update(parseLine(row, line, nodes))
    row += 1
  return nodes

def findMax(nodes):
  largest = 0
  for n in nodes:
    if nodes[n] > largest:
      largest = nodes[n]
  return largest

print(findMax(parsePyramid(pyramid)))
print("Run Time = " + str(time.time() - startTime))