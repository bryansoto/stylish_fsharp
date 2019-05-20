#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise_04_06 =
    open Houses

    let exercise: unit =
        getHouses 20
        |> Array.filter (fun house -> house.Price > 100_000m)
        |> Array.sortByDescending (fun house -> house.Price)
        |> Array.iter (fun house -> Printf.printf "%s - $%.0M\n" house.Address house.Price)

#if INTERACTIVE
    exercise
#endif