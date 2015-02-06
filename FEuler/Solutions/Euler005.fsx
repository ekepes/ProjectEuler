let rec Factors value =
    match Seq.tryFind (fun i -> value % i = 0) {2..(value / 2)} with
    | Some factor -> (factor, 1) :: Factors (value / factor)
    | None -> [(value, 1)]

let reducefunc (k,(vs:seq<int>)) =
    let count = vs |> Seq.sum
    k, count

let ReducedFactors value =
    Factors value
    |> Seq.groupBy fst |> Seq.map (fun(x,y) -> x, Seq.map snd y)
    |> Seq.map reducefunc

let maxfunc (k,(vs:seq<int>)) =
    let max = vs |> Seq.max
    k, max

let answer =
    Seq.map (fun x -> ReducedFactors x) {2..20}
    |> Seq.concat 
    |> Seq.groupBy fst |> Seq.map (fun(x,y) -> x, Seq.map snd y)
    |> Seq.map maxfunc
    |> Seq.fold (fun acc (f, u) -> acc * pown f u) 1
   