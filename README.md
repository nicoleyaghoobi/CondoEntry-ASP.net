# CondoEntry-ASP.net
This project is a web service to keep track of visitors parking of a building.
The applicaiton logs the entry and exist time stamps, the name of the visitor and the parking spot which was assigned to them.

# Database
This applicaions creates two tables in the MSSql database on Azure named visitor and parking.
The database connection string on Azure is:
```
Server=tcp:comp2084-yaghoobi-1.database.windows.net,1433;Initial Catalog=CondoEntry;Persist Security Info=False;User ID=Nicole;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
```

# How to Run
Create a Azure App Services and pass the url to this repository. Currently this fails because my project is done by .NET Core 3 and Azure only accepts Apps that are written with .NET Core 2.2 or lower.
## Azure App Services Link:
	https://condoentry.azurewebsites.net
## Azure App Services Deployment Error:
	```
	Command: "D:\home\site\deployments\tools\deploy.cmd"
Handling ASP.NET Core Web Application deployment.
D:\Program Files (x86)\dotnet\sdk\2.2.109\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.TargetFrameworkInference.targets(137,5): error NETSDK1045: The current .NET SDK does not support targeting .NET Core 3.0.  Either target .NET Core 2.2 or lower, or use a version of the .NET SDK that supports .NET Core 3.0. [D:\home\site\repository\CondoEntry\CondoEntry.csproj]
Failed exitCode=1, command=dotnet restore "D:\home\site\repository\CondoEntry.sln"
An error has occurred during web site deployment.
\r\nD:\Program Files (x86)\SiteExtensions\Kudu\84.10924.4104\bin\Scripts\starter.cmd "D:\home\site\deployments\tools\deploy.cmd"
```