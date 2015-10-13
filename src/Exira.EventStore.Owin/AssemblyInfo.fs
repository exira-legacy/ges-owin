namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Owin is an OWIN middleware to keep an EventStore connection shared per application")>]
[<assembly: AssemblyVersionAttribute("0.2.5")>]
[<assembly: AssemblyFileVersionAttribute("0.2.5")>]
[<assembly: AssemblyMetadataAttribute("githash","078d973b9d18944ce2e8def3771f908517c54773")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.5"
