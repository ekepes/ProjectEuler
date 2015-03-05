type Strategy =
    | Stay
    | Switch

type Outcome =
    | Win
    | Lose

let doors = {0..2}

let trials = 1000

let rnd = System.Random()

let findAnotherDoor winner =
    Seq.nth (rnd.Next(2)) (Seq.filter (fun i -> i <> winner ) doors)

let findThirdDoor choiceOne choiceTwo =
    Seq.pick (fun i -> match i with
                       | x when x = choiceOne || x = choiceTwo -> None
                       | x -> Some x) doors

let getDoorToShow winner guess =
    match winner = guess with
    | true -> findAnotherDoor winner
    | false -> findThirdDoor winner guess

let game strategy =
    let prizeDoor = rnd.Next(3)
    let initialGuess = rnd.Next(3)
    let doorToShow = getDoorToShow prizeDoor initialGuess
    let doorToSwitchTo = findThirdDoor initialGuess doorToShow

    match strategy with
    | Stay -> match initialGuess = prizeDoor with
              | true -> Win
              | false -> Lose
    | Switch -> match doorToSwitchTo = prizeDoor with
                | true -> Win
                | false -> Lose

let runTrials strategy = 
    Seq.sum (seq {
        for _ in 1..trials do
            match game strategy with
            | Win -> yield 1
            | Lose -> yield 0
            })

let stayWins = runTrials Stay

let switchWins = runTrials Switch

printfn "Trials         = %d" trials
printfn "Staying wins   = %d" stayWins
printfn "Switching wins = %d" switchWins