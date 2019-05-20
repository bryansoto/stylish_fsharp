#if !INTERACTIVE
namespace Chapter06
#endif

module Exercise_06_01 =
    open System

    type MeterValue =
        | Standard of int
        | Economy7 of Day:int * Night:int

    type MeterReading =
        { ReadingDate: DateTime
          MeterValue: MeterValue }

    let formatReading({ ReadingDate = date; MeterValue = value }) =
        let shortDate = date.ToShortDateString()
        
        match value with
        | Standard reading ->
            sprintf "Your reading on %s was %07i" shortDate reading
        | Economy7(Day=day; Night=night) ->
            sprintf "Your readings on: %s: Day: %07i Night: %07i" shortDate day night

    let exercise =
        let reading1 = { MeterValue=Standard 12982;
                         ReadingDate=DateTime.Now }
        
        let reading2 = { ReadingDate = DateTime.Now;
                         MeterValue = Economy7(Day = 3432, Night = 98218) }
        
        
        reading1 |> formatReading |> printf "%s\n"
        reading2 |> formatReading |> printf "%s\n"

#if INTERACTIVE
    exercise
#endif