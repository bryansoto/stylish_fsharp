namespace Chapter03

module BillingDetails =
    type Delivery =
    | AsBilling
    | Physical of string
    | Download
    | ClickAndCollect of storeId: int

    type BillingDetails = {
        name: string
        billing: string
        delivery: Delivery }

    let tryDeliveryLabel (billingDetails: BillingDetails) =
        match billingDetails.delivery with
        | AsBilling ->
            billingDetails.billing |> Some
        | Physical address ->
            address |> Some
        | Download -> None
        | ClickAndCollect _ -> None
        |> Option.map (fun address ->
            sprintf "%s\n%s" billingDetails.name address)
    let deliveryLabels (billingDetails: BillingDetails seq) =
        billingDetails
        |> Seq.choose tryDeliveryLabel
    let myOrder = {
        name = "Kit Eason"
        billing = "112 Fibonacci Street\nErehwon\n35813"
        delivery = AsBilling }
    let hisOrder = {
        name = "John Doe"
        billing = "314 Pi Avenue\nErewhon\n15926"
        delivery = Physical "16 Planck Parkway\nErewhon\n62291" }
    let herOrder = {
        name = "Jane Smith"
        billing = "9 Gravity Road\nErewhon\n80665"
        delivery = Download }

    let collectionsFor (storeId: int) (billingDetails: BillingDetails seq): BillingDetails seq =
        billingDetails
        |> Seq.choose (fun bd ->
            match bd.delivery with
            | ClickAndCollect sId when sId = storeId -> Some bd
            | _ -> None)

    let countNonNullBillingAddress (billingDetails: BillingDetails seq): int =
        billingDetails
        |> Seq.map (fun bd -> Option.ofObj bd.billing)
        |> Seq.sumBy Option.count

    [ myOrder; hisOrder; herOrder ]
    |> deliveryLabels
    |> ignore

