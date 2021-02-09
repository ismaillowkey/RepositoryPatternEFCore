dotnet restore
cd src
cd Example.Persistence

// for Winform NET 5
// add Microsoft.EntityFrameworkCore.Design v3.1.11
// add Microsoft.EntityFrameworkCore.Tools v3.1.11
// add project reference Example.Domain and Example.Persistence
// build solution
dotnet ef --startup-project ../Example.WinformNET5/ migrations add initial
dotnet ef --startup-project ../Example.WinformNET5/ database update

// for Winform NET Framework
// add dummy net core console application(net core 3.1 or net 5), and set project name to "dummy"
// add Microsoft.EntityFrameworkCore.Design v3.1.11
// add Microsoft.EntityFrameworkCore.Tools v3.1.11
// add project reference Example.Domain and Example.Persistence
// build solution
dotnet ef --startup-project ../dummy/ migrations add initial
dotnet ef --startup-project ../dummy/ database update
// Copy file "dbexample.db" from project "dummy" to your Project Winform Net Framework->bin->debug
// delete project "dummy"

winform using simpleinjector
https://simpleinjector.readthedocs.io/en/latest/windowsformsintegration.html
https://simpleinjector.readthedocs.io/en/latest/advanced.html

source : https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/