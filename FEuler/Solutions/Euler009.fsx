let findC (a, b) =
    let cSquared = (a ** 2.0) + (b ** 2.0)
    sqrt cSquared

let matchSum a b sum =
    let c = findC (a, b)
    (a + b + c) = sum

//matchSum 3.0 4.0 12.0

let Generator endValue=
    seq {for a in 1.0..endValue do 
            for b in 1.0..endValue do
                yield (a, b) }

let solution =
    let sum = 1000.0
    Generator sum
    |> Seq.filter (fun (a, b) -> matchSum a b sum)
    |> Seq.iter (fun (a, b) -> 
        let c = findC (a, b)
        let product = a * b * c
        printfn "a=%A b=%A c=%A product=%A" a b c product)