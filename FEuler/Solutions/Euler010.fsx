// Summation of primes
//  The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//  Find the sum of all the primes below two million.

open System.Collections

let primeGenerator max =
    let primes = new BitArray(max+1, true)
    seq { 2.. max }
    |> Seq.filter (fun x ->
        if primes.[x] then
            for i in int64 x * int64 x..int64 x..int64 max do primes.[int i] <- false
        primes.[x])

let solution =
    primeGenerator 2000000 |> Seq.fold (fun acc i -> int64 i + acc) 0L

printfn "%A" solution