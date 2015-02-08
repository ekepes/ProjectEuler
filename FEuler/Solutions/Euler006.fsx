let SumOfSquares max =
    Seq.reduce (fun acc i -> acc + i * i) {1..max}

let SquareOfSums max =
    pown (Seq.reduce (fun acc i -> acc + i) {1..max}) 2

let SumSquareDifference max =
    SquareOfSums max - SumOfSquares max

SumSquareDifference 100
