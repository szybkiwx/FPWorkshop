namespace FSharpInterop.BusinessRules

module EstateTransactionServices =
    open System
    open System.Collections.Generic
    open Model

    let GetAverageResidentialArealInCity (city:string) (transactions: seq<EstateTransaction>) =
         List.ofSeq(transactions)
            |> List.filter (fun x -> x.City = city)
            |> List.map (fun x -> float x.SqFeet)
            |> List.average

    let GetTotalTransactionAmountFromAreaByZip (zip:string) (transactions: seq<EstateTransaction>) = 
        List.ofSeq(transactions)
            |> List.filter(fun x -> x.ZipCode = zip)
            |> List.sumBy (fun x -> decimal x.Price) 

    let GetAverageBedroomsSoldInBetweenDates (date1:DateTime) (date2:DateTime) (transactions: seq<EstateTransaction>) = 
        List.ofSeq(transactions)
            |> List.filter (fun x -> x.SaleDate > date1 && x.SaleDate < date2)
            |> List.map (fun x -> float x.Beds)
            |> List.average

    let GetAveragePricePerSquareFeetByCity (transactions: seq<EstateTransaction>)  =
        Map.empty<string, float>
    


