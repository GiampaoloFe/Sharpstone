﻿(*
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


for ty in value.AsArray() do
  printfn "%s" (col?type.AsString())