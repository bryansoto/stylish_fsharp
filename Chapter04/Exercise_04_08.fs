#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise_04_08 =
    open Houses

    let exercise: (House * double) =
        getHouses 20
        |> Array.filter (fun house -> house.Price > 100_000m)
        |> Array.pick (fun house ->
            match Houses.trySchoolDistance house with
            | Some distance -> Some (house, distance)
            | None -> None)

#if INTERACTIVE
    exercise
#endif