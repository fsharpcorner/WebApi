namespace WebApi.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http
open WebApi.Models

/// Retrieves values.
type CarsController() =
    inherit ApiController()

    let values = [| { Make = "Ford"; Model = "Mustang"; Id=1 }; { Make = "Nissan"; Model = "Titan"; Id=2 } |]

    /// Gets all values.
    member x.Get() = values

    member x.Get(id:int) = values |> Array.filter(fun v -> v.Id = id)
