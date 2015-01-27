#load "Common.fs"

open FEuler.Common

let LargestFactor value = 
    Factors value
    |> List.max

//Factors 13195L

LargestFactor 600851475143L
