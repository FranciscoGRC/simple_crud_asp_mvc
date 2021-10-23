# Project: Simple CRUD made with ASP.NET / MVC / SQL SERVER
-------------------------------------------------------------
About the project:

Project to create, read, update and delete books records on a database.
The project use a SQL Server that you should configure before run the project.
-------------------------------------------------------------
How to configure the SQL Server?

Step 1
Open the file appsettings.json and edit the following line of code, put your server name, username and password.

"DefaultConnection": "Server=SERVENAME;Database=SimpleCrudDB;User ID=USERNAME;Password=PASSWORD;Trusted_Connection=false;MultipleActiveResultSets=true"

Step 2
Open "Tools\NuGetPackageManager\PackageManagerConsole" and use the following commands.

"add-migration migration_01_added_book_model"
"update-database"

Now your SQL Server is ready.
-------------------------------------------------------------

Simple CRUD Made by Francisco Reyes
