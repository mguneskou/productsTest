# productsTest
RESTful API to implement CRUD operations on a local SQLServer DB

.NET Core app for an Online Marketplace, let's users for CRUD operations on a local SQLServer database.
The database is stored in application's root directory by default so the connection string is looking for the .mdf file in the |DataDirectory|.
Because the project doesn't have an App_data directory the database must be stored in "..\bin\debug\net5.0" folder instead.
Application uses:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Web.CodeGeneration.Design
- Swashbuckle.AspNetCore
NuGet packages. Ensure you restore the packages (right click solution and select 'Restore NuGet Packages') once cloned the app in your local repo in case the app complains
about references!

The app is tested using Swagger and passed all CRUD operations. Another test option is using Postman. An exported Postman collections JSON file is provided within the root
directory of the app for testing.
