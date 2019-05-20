#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise04_01 =
    open Houses
    
    let exercise_4_01 =
        getHouses 20
        |> Array.map (fun house ->
            sprintf "Address: %s - Price: %f" house.Address house.Price)
#if INTERACTIVE
    exercise_4_01;;
#endif

