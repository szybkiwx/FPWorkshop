open System.IO

let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

let readData fileName = readLines fileName |> Seq.map int

let part1 data = data |> Seq.map int |> Seq.sum

let part2 data = 
    let rec find input acc history =
        match input with
            | [] -> find data acc history
            | head::rest -> if List.contains acc history then 
                                acc 
                            else 
                                find rest (acc+head) (acc::history)

    find data 0 []

[<EntryPoint>]
let main argv =
    let data = readData "input.txt"
    let result1 = part1 data
    let result2 = part2 data

    printf "Part1 result: %d" result1
    printf "Part2 result: %d" result2
    0 // return an integer exit code
