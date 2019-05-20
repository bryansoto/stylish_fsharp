#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise_04_07 =
    open Houses

    let exercise: decimal =
        getHouses 20
        |> Array.filter (fun house -> house.Price > 200_000m)
        |> Array.averageBy (fun house -> house.Price)

#if INTERACTIVE
    exercise
#endif