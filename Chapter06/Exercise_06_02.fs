#if !INTERACTIVE
namespace Chapter06
#endif

module Exercise_06_02 =
    type FruitBatch = { Name: string
                        Count: int }

    let fruits =
        [ { Name = "Apples"; Count = 3 }
          { Name = "Oranges"; Count = 4 }
          { Name = "Bananas"; Count = 2 } ]

    let exercise =
        for fruitBatch in fruits do
            printfn "There are %i %s" fruitBatch.Count fruitBatch.Name

        fruits
        |> List.iter (fun { Name = name; Count = count } ->
            printfn "There are %i %s" count name)

#if INTERACTIVE
    exercise
#endif