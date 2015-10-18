namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Owin is an OWIN middleware to keep an EventStore connection shared per application")>]
[<assembly: AssemblyVersionAttribute("0.2.0")>]
[<assembly: AssemblyFileVersionAttribute("0.2.0")>]
[<assembly: AssemblyMetadataAttribute("githash","2c48cdf780193177a479942f1baeac360d286729")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.0"
