#time "on"

let IsPrime x =
    match x with
    | 1 -> false
    | 2 -> true
    | _ -> match Seq.tryFind (fun i -> x % i = 0) {2..((x/2)+1)} with
            | Some factor -> false
            | None -> true

let Primes =
    Seq.filter IsPrime {1..1000000}

Seq.take 10001 Primes
|> Seq.last
