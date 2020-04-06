open Saturn
open Giraffe

//**************************************************//
//             HTTP HANDLERS                        //
//**************************************************//
let getValues =
    [|1;2;3|]

let getValue (input:int) = 
    let values = [|1;2;3|]
    
    values
    |> Array.tryFind(fun el -> el = input)

//**************************************************//
//             ROUTER DEFINITION                    //
//**************************************************//
let apiRouter = router {
    get "/api/values" (getValues |> json)
    getf "/api/values/%i" (getValue >> json)
}

//**************************************************//
//             APP CONFIG                           //
//**************************************************//
let webapp = application {
    use_router apiRouter
    url "http://0.0.0.0:7078"
}

run webapp