namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Owin is an OWIN middleware to keep an EventStore connection shared per application")>]
[<assembly: AssemblyVersionAttribute("0.3.14")>]
[<assembly: AssemblyFileVersionAttribute("0.3.14")>]
[<assembly: AssemblyMetadataAttribute("githash","4a945228b449219ca983eca941bc8b07eb6377b3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.14"
