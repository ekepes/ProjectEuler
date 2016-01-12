def CreateSequence(seed):
    sequence = [seed]
    element = seed
    while element != 1:
        if element % 2 == 0:
            element = int(element / 2)
        else:
            element = 3 * element + 1
        sequence.append(element)

    return sequence

# trial = CreateSequence(13)
# print (trial)

def Solve(x):
    maxSequenceLength = 0
    seedThatHasMaxSequenceLength = 0
    for test in range(1, x + 1):
        testSequenceLength = len(CreateSequence(test))
        if testSequenceLength > maxSequenceLength:
            print ("New leader: {} (length={}).".format(test, testSequenceLength))
            maxSequenceLength = testSequenceLength
            seedThatHasMaxSequenceLength = test

    print ("")
    print ("Winner: {} (length={}).".format(seedThatHasMaxSequenceLength, maxSequenceLength))

Solve(999999)