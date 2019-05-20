#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise04_02 =
    open Houses
    
    let exercise_4_02 =
        getHouses 20
        |> Array.map (fun house -> house.Price)
        |> Array.average

    // |> Array.averageBy (fun h -> h.Price) // mised the std lib

#if INTERACTIVE
    exercise_4_02;;
#endif