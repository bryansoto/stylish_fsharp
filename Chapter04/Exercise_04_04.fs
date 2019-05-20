#if !INTERACTIVE


namespace Chapter04
#endif



module Exercise04_04 =
    open Houses

    let exercise: (House * double) [] =
        getHouses 20
        |> Array.choose (fun house ->
            match Houses.trySchoolDistance house with
                | None -> None
                | Some(distance) -> Some(house, distance))

#if INTERACTIVE
    exercise
#endif