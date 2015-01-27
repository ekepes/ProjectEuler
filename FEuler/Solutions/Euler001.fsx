let FindFilteredSum list filter =
    List.sum (List.filter filter list)

let IsDivisibleByThreeOrFive value =
    value % 3 = 0 || value % 5 = 0

FindFilteredSum [1..9] IsDivisibleByThreeOrFive

FindFilteredSum [1..999] IsDivisibleByThreeOrFive