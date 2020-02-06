namespace FSharpInterop.BusinessRules

module EstateTransactionServices =
    open System
    open System.Collections.Generic
    open Model

    let GetAverageResidentialArealInCity (city:string) (transactions: seq<EstateTransaction>) =
        0.0

    let GetTotalTransactionAmountFromAreaByZip (zip:string) (transactions: seq<EstateTransaction>) = 
        0m

    let GetAverageBedroomsSoldInBetweenDates (date1:DateTime) (date2:DateTime) (transactions: seq<EstateTransaction>) = 
        0.0

    let GetAveragePricePerSquareFeetByCity (transactions: seq<EstateTransaction>)  =
        Map.empty<string, decimal>
    


