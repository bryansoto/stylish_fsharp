#if !INTERACTIVE
namespace Chapter04
#endif

module Array =
    let inline tryAverage (array: 'T[]): 'T option =
        match Array.length array with
        | 0 -> None
        | _ -> array |> Array.average |> Some

    let inline tryAverageBy (f: 'T -> 'T) (array: 'T[]): 'T option =
        if array.Length = 0 then
            None
        else
            array |> Array.averageBy f |> Some  