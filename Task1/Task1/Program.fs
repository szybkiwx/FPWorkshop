open System.IO

let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

let readData fileName = readLines fileName |> Seq.map int

let calcFuel mass =
    let fl = (float mass) / 3.0 |> floor |> int
    int (fl-2)

let part1 input = input |> Seq.map calcFuel |> Seq.sum

let calcMoreFuel mass =
    let rec loop inputMass result =
        let nextMass = calcFuel inputMass
        if nextMass <= 0 then 
            result 
        else 
            loop nextMass (result + nextMass) 
    loop mass 0  

let part2 input = input |> Seq.map calcMoreFuel |> Seq.sum

[<EntryPoint>]
let main argv =
    let data = readData "input.txt"
    let result1 = part1 data
    let result2 = part2 data

    printf "Part1 result: %d" result1
    printf "Part2 result: %d" result2
    0 // return an integer exit code
