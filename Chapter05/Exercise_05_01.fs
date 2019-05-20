#if !INTERACTIVE
namespace Chapter05
#endif

module Exercise_05_01 =
    open System

    let clip (ceiling: float) (s: seq<float>) =
        s
        |> Seq.map (min ceiling)

    let exercise =
        [| 1.0; 2.3; 11.1; -5. |]
        |> clip 10.

#if INTERACTIVE
    exercise
#endif