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
type Deck = JsonProvider<"https://raw.githubusercontent.com/Maurizio-Mario/Sharpstone/master/SharpStone/deck1.txt">
let value = Deck.GetSamples()

// Return every value of the name "Artist" and "Type"
for col in value do                  //Returns all artists
  if col.Collectible then
    printfn "%s" col.Artist

for ty in value do                   //Retuns how many minions           
  if ty.Type = "MINION" then
    printfn "%s" ty.Type

value.[1].Type;;                    //Return [1] type


(*Create the subDeck1 with only minions*)     
let minDeck1 = value |> Seq.filter (fun c -> c.Type = "MINION")                                 
    



     