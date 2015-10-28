namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Owin is an OWIN middleware to keep an EventStore connection shared per application")>]
[<assembly: AssemblyVersionAttribute("0.2.9")>]
[<assembly: AssemblyFileVersionAttribute("0.2.9")>]
[<assembly: AssemblyMetadataAttribute("githash","964964fbcdfc3c6a8034ba388282c500eec85497")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.9"
