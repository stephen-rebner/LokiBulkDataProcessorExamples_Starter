# Loki Bulk Data Processor Examples Starter Project

This project contains an uncompleted Web API project, which is used as starting point for a YouTube tutorial on how to use
the Bulk Data Processor.

The following files are included in this solution:

- Post.cs and Blog.cs - domain model objects
- BlogDbContext.cs - Entity Framework database context file
- Startup.cs - Adds Entity Framework to the project
- appsettings.json - contains the database connection string and currently points at localhost
- BulkProcessorController.cs - To be completed as part of the tutorial
- Loki.Tests.postman_collection.json - an import file for Postman, containing the HTTP requests used in the tutorial

Before starting the tutorial, open up the Nuget Package Console window in Visual Studio and run the following command:

Update-Database

This will create a database called BlogsDb with 2 tables (Blogs and Posts).
