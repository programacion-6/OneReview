# OneReview Project

## Commands used to create the project

`dotnet new sln --name OneReview`

`mkdir src`

`mkdir tests`

`dotnet new webapi -o OneReview`

`dotnet new editorconfig`

`dotnet new globaljson --roll-forward latestMinor --sdk-version 8.0.303`

windows
`dotnet sln add (ls -r **/**.csproj)`

linux/macos
`dotnet sln add **/**.csproj`

`dotnet add src/OneReview/OneReview.csproj package DbUp-PostgreSQL`