open System.IO

let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

let readData fileName = readLines fileName |> Seq.map int

let part1 data = 0

let part2 data = 0


[<EntryPoint>]
let main argv =
    let data = readData "input.txt"
    let result1 = part1 data
    let result2 = part2 data

    printf "Part1 result: %d" result1
    printf "Part2 result: %d" result2
    0 // return an integer exit code