namespace FSharpInterop.BusinessRules

open System

module EstateTransactionServices =
    open Model
    open System.Collections.Generic

    let GetAverageResidentialArealInCity (city:string) (transactions: IEnumerable<EstateTransaction>) =
        0.0

    let GetTotalTransactionAmountFromAreaByZip (zip:string) (transactions: IEnumerable<EstateTransaction>) = 
        0m

    let GetAverageBedroomsSoldInBetweenDates (date1:DateTime) (date2:DateTime) (transactions: IEnumerable<EstateTransaction>) = 
        0.0

    


