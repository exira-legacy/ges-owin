namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Owin is an OWIN middleware to keep an EventStore connection shared per application")>]
[<assembly: AssemblyVersionAttribute("0.3.0")>]
[<assembly: AssemblyFileVersionAttribute("0.3.0")>]
[<assembly: AssemblyMetadataAttribute("githash","009c321b0bf980acd4b0f779af68803204f6454a")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.0"
