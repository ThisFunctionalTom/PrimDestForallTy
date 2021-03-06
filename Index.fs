module Index

open Elmish

type Model = int

type Msg =
    Nothing

let init(): Model * Cmd<Msg> =
    1, Cmd.none

let update (msg: Msg) (model: Model): Model * Cmd<Msg> =
    model, Cmd.none

open Fable.React

let view (model : Model) (dispatch : Msg -> unit) =
    div [] []
