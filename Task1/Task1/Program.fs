open System.IO

let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

let readData() = readLines "input.txt" |> Seq.map int |> Seq.toList

let part1 data = 0

let part2 data = 0


[<EntryPoint>]
let main argv =
    let data = readData()
    let result1 = part1 data
    let result2 = part2 data
    0 // return an integer exit code