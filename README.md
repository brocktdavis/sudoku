Commands used to create project structure:
```
dotnet new sln
dotnet new classlib -o src
dotnet sln add src/src.csproj
dotnet new xunit -o test
dotnet sln add test/test.csproj
dotnet add test/test.csproj reference src/src.csproj
```
