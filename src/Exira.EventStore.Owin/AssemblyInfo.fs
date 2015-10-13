namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.EventStore.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.EventStore.Owin is an OWIN middleware to keep an EventStore connection shared per application")>]
[<assembly: AssemblyVersionAttribute("0.2.6")>]
[<assembly: AssemblyFileVersionAttribute("0.2.6")>]
[<assembly: AssemblyMetadataAttribute("githash","538a297d586bf88eaf62879f576ff034ff6bad79")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.6"
