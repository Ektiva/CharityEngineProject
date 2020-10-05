# Charity Engine Challenge

## Question 1

Simple software to track vehicles that park at an apartment complex.
The manager is able to: 
  - Register new vehicles 
  - Edit/update records for already registered vehicles 
  - Search for a vehicle owner’s name and contact using the vehicle's registration number. 

## Frameworks
 
The software was build with ASP.NET MVC (C#), ADO.NET and SQL SERVER.
 
## Run 

 --> Clone the repository

 --> Open the project VehiclesTracking with your IDE (for example Visual Studio)

 --> Run the script dbo.Create_Database_VehiclesTracking.sql in Microsoft SQL Server Management Studio and run 
     to create a new database (You can find all scripts in the folder Database Scripts) 

 --> Run the script dbo.Create_Table_Vehicle.sql

 --> Run the others scripts

 -->  Get the connection String of the database
     (you can use Server Explorer option  in Visual Studio to get the Connection String from the database properties)

 --> Changes the Connection String  in Web.config with your Connection String

 --> Run the project

## Note

This is a very basic MVC project build according to the requirements and there are lot of improvement that can be made.


