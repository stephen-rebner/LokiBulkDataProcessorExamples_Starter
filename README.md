# Loki Bulk Data Processor Examples Starter Project

This project contains an uncompleted Web API project, which is used as starting point for a YouTube tutorial on how to use
the Bulk Data Processor.

The following files are included in this solution:

- Post.cs and Blog.cs - domain model objects
- BlogDbContext.cs - Entity Framework database context file
- Startup.cs - Adds Loki Bulk Data Processor and EF to the project
- appsettings.json - contains the database connection string and currently points at local host
- BulkProcessorController.cs - To be completed

Before starting the tutorial, open up the Nuget Package Console window in Visual Studio and run the following command:

Update-Database

This will create a database called BlogsDb with 2 tables (Blogs and Posts).
