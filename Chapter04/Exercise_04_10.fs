#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise_04_10 =
    open Houses

    let exercise: decimal =
        getHouses 20
        |> Array.choose (fun house ->
                         match house.Price > 200_000m with
                         | true -> house.Price |> Some
                         | false -> None)
        |> Array.tryAverage
        |> function
            | None -> 0m
            | Some average -> average

#if INTERACTIVE
    exercise
#endif