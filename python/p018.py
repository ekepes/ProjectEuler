pyramid = ["3",
  "7 4",
  "2 4 6",
  "8 5 9 3"]

class Node(object):
  def __init__(self, weight, row, column, maxRows):
    self.weight = weight
    if row + 1 < maxRows:
      self.left = getKey(row+1, column)
      self.right = getKey(row+1, column+1)
    else:
      self.left = None
      self.right = None
    self.row = row
    self.column = column
  def getWeigth(self):
    return self.weight
  def getLeft(self):
    return self.left
  def getRight(self):
    return self.right
  def isTerminal(self):
    return self.left == None
  def __str__(self):
     return str(self.weight) + ":" + str(self.left) + "," + str(self.right)

def getKey(row, column):
  return row * 1000 + column

def parseLine(row, line, maxRows):
  lineNodes = {}
  column = 0
  for item in line.split():
    lineNodes[getKey(row, column)] = Node(item, row, column, maxRows)
    column += 1
  return lineNodes

def parsePyramid(pyramid):
  nodes = {}
  row = 0
  maxRows = len(pyramid)
  for line in pyramid:
    nodes.update(parseLine(row, line, maxRows))
    row += 1
  return nodes

nodes = parsePyramid(pyramid)
for n in nodes:
  print(n, nodes[n], nodes[n].isTerminal())