let Group ungrouped =
    ungrouped |> Seq.groupBy fst |> Seq.map (fun(x,y) -> x, Seq.map snd y)

let rec Factors value =
    match Seq.tryFind (fun i -> value % i = 0) {2..(value / 2)} with
    | Some factor -> (factor, 1) :: Factors (value / factor)
    | None -> [(value, 1)]

let ReducedFactors value =
    Factors value
    |> Group
    |> Seq.map (fun (k,(vs:seq<int>)) -> k, Seq.sum vs)

let answer =
    Seq.concat (Seq.map (fun x -> ReducedFactors x) {2..20})
    |> Group
    |> Seq.map (fun (k,(vs:seq<int>)) -> k, Seq.max vs)
    |> Seq.fold (fun acc (f, u) -> acc * pown f u) 1
   