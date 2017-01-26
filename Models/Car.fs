namespace WebApi.Models

open Newtonsoft.Json

[<CLIMutable>]
type Car = {
    Make : string
    Model : string
    Id : int
}
