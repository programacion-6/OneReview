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

## Development environment

You should run the `docker-compose-development.yaml` file.

The connection string for local environment is `Host=localhost;Port=5432;Database=dbpreview;Username=postgres;Password=strong_password`. The credentials are configurable at the `docker-compose` file.

`docker-compose -f docker-compose-development.yaml up --build`

## Production environment 

You should run the `docker-compose.yaml` file.

`docker-compose -f docker-compose.yaml up --build`

> Note: You can use the `-d` detached mode as well.

## Packages installed

You can see the installed packages at `OneReview.csproj` file

```xml
<ItemGroup>
  <PackageReference Include="Dapper" Version="2.1.35" />
  <PackageReference Include="dbup-postgresql" Version="5.0.40" />
  <PackageReference Include="FluentValidation" Version="11.10.0" />
  <PackageReference Include="Npgsql" Version="8.0.4" />
  <PackageReference Include="Throw" Version="1.4.0" />
</ItemGroup>
```