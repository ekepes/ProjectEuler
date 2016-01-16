pyramid = ["03",
  "07 04",
  "02 04 06",
  "08 05 09 03"]

class Node(object):
  def __init__(self, weight, row, column, nodes):
    self.weight = int(weight)
    if row > 0:
      if column < row:
        self.right = getKey(row-1, column)
      else:
        self.right = None
      if column > 0:
        self.left = getKey(row-1, column-1)
      else:
        self.left = None
    else:
      self.left = None
      self.right = None
    self.cumWeight = self.weight + max(resolveNode(nodes, self.left), resolveNode(nodes, self.right))
  def getCumWeight(self):
    return self.cumWeight
  def __str__(self):
     return str(self.weight) + ":" + str(self.left) + "," + str(self.right) + "=" + str(self.cumWeight)

def getKey(row, column):
  return row * 1000 + column

def resolveNode(nodes, key):
  if key == None:
    return 0
  else:
    return int(nodes[key].getCumWeight())

def parseLine(row, line, nodes):
  lineNodes = {}
  column = 0
  for item in line.split():
    lineNodes[getKey(row, column)] = Node(item, row, column, nodes)
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
    if nodes[n].getCumWeight() > largest:
      largest = nodes[n].getCumWeight()
  return largest

print(findMax(parsePyramid(pyramid)))