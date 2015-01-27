#load "Common.fs"

open FEuler.Common 

let IsolateAndReverseDigit digits length index = 
    (digits % (pow 10 index)) / (pow 10 (index - 1)) * (pow 10 (length - index))

let ReverseDigits digits =
    let length = int32 (log10 (float 1234)) + 1
    List.fold (fun acc index -> acc + (IsolateAndReverseDigit digits length index)) 0 [1..length] 

let IsPalindrome digits =
    digits = ReverseDigits digits

let crap = IsPalindrome 9009