namespace Exira.EventStore.Owin

open Owin
open System
open System.Net
open System.Collections.Generic
open System.Threading.Tasks
open System.Runtime.CompilerServices

open Exira.EventStore
open Exira.EventStore.EventStore

type EventStoreOptions() =
    let defaultConnectionString = "ConnectTo=tcp://admin:changeit@127.0.0.1:1113"

    member val ConnectionString = defaultConnectionString with get, set

type EventStoreMiddleware(next: Func<IDictionary<string, obj>, Task>, options: EventStoreOptions) =
    let awaitTask = Async.AwaitIAsyncResult >> Async.Ignore

    let es = connect options.ConnectionString |> Async.RunSynchronously

    let updateOrAdd key value (dict: dict<'Key, 'T>) =
        lock dict <| fun () -> dict.[key] <- value
        dict

    member this.Invoke (environment: IDictionary<string, obj>) =
        let updatedEnvironment =
            environment
            |> updateOrAdd "ges.connectionString" (options.ConnectionString :> obj)
            |> updateOrAdd "ges.connection" (es :> obj)

        async {
            do! next.Invoke updatedEnvironment |> awaitTask
        } |> Async.StartAsTask :> Task

[<ExtensionAttribute>]
type AppBuilderExtensions =
    [<ExtensionAttribute>]
    static member UseEventStore(appBuilder: IAppBuilder, options: EventStoreOptions) =
        appBuilder.Use<EventStoreMiddleware>(options)
