(*
Install FSharp.Data in project folder via package manager console
PM> Install-Package FSharp.Data 
*)

(*Path to the library. Make it relative in the future. Ex:
let value = JsonValue.Load(__SOURCE_DIRECTORY__ + "../../data/WorldBank.json")
*)

#r "C:/Users/mauri/OneDrive/Programmazione1/Sharpstone/dataAccessManipulation/packages/FSharp.Data.2.3.2/lib/net40/FSharp.Data.dll";;

(*Load library and JSON extensions*)
open FSharp.Data
open FSharp.Data.JsonExtensions

(*Load data*)
type Deck1 = JsonProvider<"https://raw.githubusercontent.com/Maurizio-Mario/Sharpstone/master/SharpStone/deck1.txt">
let value1 = Deck1.GetSamples()

type Deck2 = JsonProvider<"https://raw.githubusercontent.com/Maurizio-Mario/Sharpstone/master/SharpStone/deck2.txt">
let value2 = Deck2.GetSamples()

type Deck3 = JsonProvider<"https://raw.githubusercontent.com/Maurizio-Mario/Sharpstone/master/SharpStone/deck3.txt">
let value3 = Deck3.GetSamples()

// Return every value of the name "Artist" and "Type"
for col in value1 do                  //Returns all artists
  if col.Collectible then
    printfn "%s" col.Artist

for ty in value1 do                   //Retuns how many minions           
  if ty.Type = "MINION" then
    printfn "%s" ty.Type

value1.[1].Type;;                    //Return [1] type

(*Subset decks with only minions with attack and health <> 0
The values of health and attack are of type option. See details*)
let minDeck1 = 
    value1 |> Seq.filter (fun c -> c.Type = "MINION" && c.Health <> Some 0)

let minDeck2 =
    value2 |> Seq.filter (fun c -> c.Type = "MINION" && c.Health <> Some 0)

let minDeck3 =
    value3 |> Seq.filter (fun c -> c.Type = "MINION" && c.Health <> Some 0)
                                 
    



     