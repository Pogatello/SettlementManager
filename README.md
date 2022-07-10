This is an app for managing settlements that are connected to countries.
App contains .NET 6 REST API, and a Blazor Server App as frontend componet. 
Implemented methods are SettlementQuery with paging, Create, Update and Delete.


**How To Run**

**Step 1. - Database**


Create a fresh new SQL database (prefered name SettlementManagerDb)

Open soulution in Visual Studio or some other IDE

Adjust connection string if neccessary - both in SettlementManager.Web (for blazor frontend) and SettlementManager.API (for rest api)

Open Package Manager Console, targer project SettlementManager.Repository and execute Update-Database command

Database tables should be created.

Open Solution folder, there should be a InitDatabaseScript.sql file, execute script for initial Countries and some settlements




**Step 2. - RestAPI**


If you want to use .NET 6 Rest Api, right click on SettlementManager.API and set it as startup project

Run the application and you should see Open API (Swagger) in your web browser



**Step 3. - Blazor App**

If you want to see a frontend for this application, right click on SettlementManager.Web and set it as a startup project

Run the application and you should have a web app open in your browser

Features
- Table on the home page with all settlements
- Paging (prev, next, page number)
- Action buttons for Update and delete in the last column
  - Actions open a modal with an update form or delete confirmation
- Top rigght corner of table - Create button
   - Opens a modal for creating a settlement
- Bottom left corner of a table - total settlements in a database
