namespace Chapter02

module MilesChains =
    open System
    open Microsoft.FSharp.Quotations

    type MilesChains =
         MilesChains of wholeMies: int * chains: int

    let private nameof (q: Expr<_>) =
      printf "%O" q
      match q with
      | Patterns.ValueWithName(_, _, name) -> name
      | Patterns.Let(_, _, DerivedPatterns.Lambdas(_, Patterns.Call(_, mi, _))) -> mi.Name
      | Patterns.PropertyGet(_, mi, _) -> mi.Name
      | DerivedPatterns.Lambdas(_, Patterns.Call(_, mi, _)) -> mi.Name
      | _ -> failwith "Unexpected format"

    let private ensurePositive (name: string, value: int) =
          if value < 0 then
             raise <| ArgumentOutOfRangeException(name, "Expected positive value")

          value

    let makeMilesChains (wholeMiles: int, chains: int) =
        ensurePositive (nameof <@ wholeMiles @>, wholeMiles) |> ignore
        ensurePositive (nameof <@ chains @>, chains) |> ignore

        if chains > 80 then
            raise <| ArgumentOutOfRangeException(nameof <@ chains @>,
                                                 "80 chains = 1 mile")

        MilesChains(wholeMiles, chains)

    let toDecimalMiles (MilesChains(wholeMiles, chains)): float =
        (float wholeMiles) + ((float chains) / 80.)

    makeMilesChains(-1, 100) |> ignore