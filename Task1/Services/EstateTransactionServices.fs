namespace FSharpInterop.BusinessRules

module EstateTransactionServices =
    open System
    open System.Collections.Generic
    open Model

    let GetAverageResidentialArealInCity (city:string) (transactions: IEnumerable<EstateTransaction>) =
        0.0

    let GetTotalTransactionAmountFromAreaByZip (zip:string) (transactions: IEnumerable<EstateTransaction>) = 
        0m

    let GetAverageBedroomsSoldInBetweenDates (date1:DateTime) (date2:DateTime) (transactions: IEnumerable<EstateTransaction>) = 
        0.0

    let GetAveragePricePerSquareFeetByCity (transactions: IEnumerable<EstateTransaction>)  =
        Map.empty<string, float>
    


