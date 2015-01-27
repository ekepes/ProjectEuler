#load "Common.fs"

open FEuler.Common

let FindFilteredSum list filter =
    List.sum (List.filter filter list)

FindFilteredSum (Fibonacci 4000000) IsEven