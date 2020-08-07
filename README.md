# Dr Snuess's Factory, Engineer and Machine Manager

#### Many-to-Many Relationships with C# Exercise for Epicodus 08.07.2020

### By Kate Skorija

## Description

This week I focused on making databases with many-to-many relationships with SQL and Entity. This specific project is a C# MVC web application for Dr. Snuess's Factory. It was built to help the Dr. Snuess track the engineers and machines in his factory, specifically which engineers are licensed to repair which machines. 

## Specifications

**Behavior**: Program will list all engineers.
  * Input: *User clicks "View engineers"*
  * Output: User is taken to a page with a list of engineers

**Behavior**: Program will list all machines.
  * Input: *User clicks "View machines"*
  * Output: User is taken to a page with a list of machines

**Behavior**: Program will allow user to select an engineer and see all machines that engineer is licensed to repair 
  * Input: *User clicks on specific engineer*
  * Output: User is taken to a details page with machines listed 

**Behavior**: Program will allow user to select a machine and see all engineers licensed to repair that machine
  * Input: *User clicks on specific machine*
  * Output: User is taken to a details page with engineers listed

**Behavior**: Program will allow user to add new engineers
  * Input: *User clicks "Add new engineer"*
  * Output: User is taken to a page with a form to add another engineer

**Behavior**: Program will allow user to add new machines
  * Input: *User clicks "Add new machine"*
  * Output: User is taken to a page with a form to add another machine

**Behavior**: Program will allow user to add new engineers even if there are not machines installed 
  * Input: *User submits engineer form"*
  * Output: Engineer is added to the list page

**Behavior**: Program will allow user to add new machines even if there are no engineers employed
  * Input: *User submits machine form"*
  * Output: Machine is added to the list page

**Behavior**: Program will allow user to add or remove machines that a engineer is licensed to repair
  * Input: *User clicks "Edit engineer"*
  * Output: User is taken to a page with a form that allows them to add or remove machines for that engineer

  **Behavior**: Program will allow user to add or remove engineers that are licensed to repair a specific machine
  * Input: *User clicks "Edit machine"*
  * Output: User is taken to a page with a form that allows them to add or remove engineers for that machine

## Setup/Installation Requirements

*_These instructions are specifically for MySql Workbench, but should work similarly for or any generic SQL database manager._* 

1.  Navigate to the [Factory.Solution respository](https://github.com/kate-skorija/Factory.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/kate-skorija/Factory.Solution.git`


3. Navigate to the `Factory.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

4. Within the project, navigate to the Factory directory, and type `dotnet restore`, then `dotnet build`. 

5. Next ensure the MySQL server is running by opening a separate terminal and entering the command `mysql -uroot -pepicodus` (or your equivalent username and password).

6. Return to your terminal for the Factory directory, and enter `dotnet ef migrations add Initial`. If there is an `Unable to resolve project` error, ensure you are in the correct directory, Factory. A Migrations folder should automatically generate in the Factory directory.

7. After the initial migration is complete, run the command `dotnet ef database update`. This will create a `kate_skorija` database. Open MySql Workbench or your database manager and confirm that the new database has been created.

8. Type `dotnet run` into the terminal. Click on the provided local host link in the terminal to view the web application in your browser. 

### SQL Schema Query

*_The SQL commands below could also be used with any SQL manager to create the database for this project_*

DROP DATABASE IF EXISTS `kate_skorija`;  
CREATE DATABASE `kate_skorija`;  

USE `kate_skorija`;

CREATE TABLE `stylists` (  
  `Name` varchar(255) NOT NULL,  
  `Phone` varchar(14) NOT NULL,  
  `WorkStation` varchar(2) NOT NULL,  
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,  
  PRIMARY KEY (`StylistId`)  
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `clients` (  
  `Name` varchar(255) NOT NULL,  
  `Phone` varchar(14) NOT NULL,  
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,  
  `StylistId` int(11) NOT NULL DEFAULT '0',  
  PRIMARY KEY (`ClientId`)  
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/kate-skorija).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET-Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
*  [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)

### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Kate Skorija_** 