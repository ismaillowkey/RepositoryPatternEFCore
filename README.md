# Readme

This Application implement Unit of work and Repository pattern

## Installation
```bash
dotnet restore
cd src
cd Example.Persistence
```
# For Winform NET 5
add Microsoft.EntityFrameworkCore.Design v3.1.11\
add Microsoft.EntityFrameworkCore.Tools v3.1.11\
add project reference Example.Domain and Example.Persistence\
and build solution

```bash
dotnet ef --startup-project ../Example.WinformNET5/ migrations add initial
dotnet ef --startup-project ../Example.WinformNET5/ database update
```

# For Winform Net Framework
Add dummy net core console application(net core 3.1 or net 5), and set project name to "dummy"\
Add Microsoft.EntityFrameworkCore.Design v3.1.11\
Add Microsoft.EntityFrameworkCore.Tools v3.1.11\
Add project reference Example.Domain and Example.Persistence\
Build solution

```bash
dotnet ef --startup-project ../dummy/ migrations add initial
dotnet ef --startup-project ../dummy/ database update
```
Copy file "dbexample.db" from project "dummy" to your Project Winform Net Framework->bin->debug\
Delete project "dummy"


# Source
https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/