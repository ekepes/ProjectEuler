namespace FEuler

module Common =

    let rec fibsRec a b maxValue =
        if a + b < maxValue then
            let current = a + b
            let rest = fibsRec b current maxValue 
            current :: rest
        else 
            []

    let Fibonacci maxValue = 1::2::(fibsRec 1 2 maxValue)

    let IsEven value = value % 2 = 0

    let IsOdd value = value % 2 = 1

    let rec Factors value =
        match Seq.tryFind (fun i -> value % i = 0L) {2L..(value / 2L)} with
        | Some factor -> factor :: Factors (value / factor)
        | None -> [value]

    let pow value exponent = 
        List.fold (fun acc elem -> acc * value) 1 [1..exponent] 
