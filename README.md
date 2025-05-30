# Employee Management System
Employee Management System Overview

The Employee Management System is designed to manage employee data, including their personal information, 
job positions, and salary details. It provides functionalities to fetch employee data, 
calculate salaries based on the number of days worked, and display this information in a user-friendly format.
# To run the system use:
 User_id=Admin
 
 Password=1234

# How the System Works
  1)  Splash Screen:
  	      Displays a progress bar on application startup.
  	      Once the progress bar reaches 100%, it hides the splash screen and shows the login form.
         
  2)  User Authentication:
  	      Provides a login form for users to enter their credentials.
  	      Validates credentials against default values or a database.
  	      On successful login, it shows the main form.
      
  3) Main Navigation:
  	     Provides navigation to different sections of the system: Employee, Details, and Salary.
  	     Each section is represented by a clickable picture box or label.
     
  4) Employee Management:
  	   Allows adding, editing, and deleting employee records.
  	   Displays employee data in a DataGridView.
  	   Handles database operations for CRUD (Create, Read, Update, Delete) actions.
     
  5) Employee Details:
  	   Fetches and displays detailed information about a specific employee.
  	   Shows data such as name, address, position, date of birth, phone number, education, and gender.
      
  6) Salary Calculation:
  	  Fetches employee data based on the employee ID.
  	  Calculates salary based on the number of days worked and the employee's position.
  	  Displays the calculated salary details.

# Sql codes
     -- Create the database
    CREATE DATABASE employeemangementsystembd;

    -- Use the database
    USE employeemangementsystembd;

    -- Create the users table
    CREATE TABLE users (
    user_id VARCHAR(50) NOT NULL PRIMARY KEY,
    password VARCHAR(50) NOT NULL
    );

    -- Insert default user
    INSERT INTO users (user_id, password) VALUES ('Admin', '1234');
    
    -- Create the employeetable
    CREATE TABLE employeetable (
        EmpId INT AUTO_INCREMENT PRIMARY KEY,
        EmpName VARCHAR(100) NOT NULL,
        EmpAdd VARCHAR(255) NOT NULL,
        EmpPos VARCHAR(50) NOT NULL,
        EmpDob DATE NOT NULL,
        EmpPhone VARCHAR(15) NOT NULL,
        EmpEdu VARCHAR(50) NOT NULL,
        EmpGend VARCHAR(10) NOT NULL
    );
    
    



