#if !INTERACTIVE
namespace Chapter04
#endif

module Exercise_04_11 =
    open Houses

    let exercise: (House * double) option =
        getHouses 20
        |> Array.choose (fun house ->
            let qualifications = (house.Price < 100_000m,
                                  Houses.trySchoolDistance house)

            match qualifications with
            | (true, Some distance) -> Some (house, distance)
            | (_, _) -> None)
        |> Array.tryHead

#if INTERACTIVE
    exercise
#endif