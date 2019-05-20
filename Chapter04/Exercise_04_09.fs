#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise_04_09 =
    open Houses

    let exercise: (Houses.PriceBand * Houses. House []) [] =
        getHouses 20
        |> Array.groupBy (fun house -> Houses.priceBand house.Price)
        |> Array.map (fun (priceBand, houses) ->
            (priceBand, houses |> Array.sortBy (fun house -> house.Price)))

#if INTERACTIVE
    exercise
#endif