#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise04_03 =
    open Houses
    
    let exercise =
        getHouses 20
        |> Array.filter (fun house -> house.Price > 250_000m)

#if INTERACTIVE
    exercise;;
#endif