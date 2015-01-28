let IsolateAndReverseDigit digits length index = 
    (digits % (pown 10 index)) / (pown 10 (index - 1)) * (pown 10 (length - index))

let ReverseDigits digits =
    let length = int32 (log10 (float digits)) + 1
    List.fold (fun acc index -> acc + (IsolateAndReverseDigit digits length index)) 0 [1..length] 

let IsPalindrome digits =
    digits = ReverseDigits digits

let Generator startValue endValue=
    seq {for x in startValue..(-1)..endValue do 
            for y in x..(-1)..endValue do
                yield (x, y) }

let solution =
    Generator 999 100
    |> Seq.filter (fun (a, b) -> IsPalindrome (a * b))
    |> Seq.maxBy (fun (a, b) -> (a * b))

//let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn "" 
//solution |> printSeq