#if !INTERACTIVE
namespace Chapter05
#endif

module Exercise_05_02 =
    let extremes (s: seq<float>) =
        Seq.min s, Seq.max s

    let exercise =
        [| 1.0; 2.3; 11.1; -5. |]
        |> extremes

#if INTERACTIVE
    exercise
#endif