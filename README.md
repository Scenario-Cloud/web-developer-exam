# Welcome!
If you're here, you may be interested for a Software Developer / Web Developer post for [Scenario Cloud](https://www.scenariocloud.com) team. Please read the sections below for the coverage of the exam.

# Solution - ScenarioCloud.WebDeveloperExam
In this Repository, a .NET Solution file with three Projects coded in C# can be found.

# Project - ScenarioCloud.WebDeveloperExam.Business
This .NET Class Library Project contains initial models that will be used throughout the App. By the end of the exam, the App should be utilizing Entity Framework using the model(s) can found in this Project.

# Project - ScenarioCloud.WebDeveloperExam.Data
This .NET Class Library Project contains inital DbContext that will be used throughout the App. This Project should also include the business logic when persisting data - which will be described as part of the requirements of the exam.

# Project - ScenarioCloud.WebDeveloperExam.Web
This .Net Web Application Project will the main App. This will contain the UI itself and any UI-related logic.

# Requirements - Server Side
1. Create a Model named 'Register'. This should have the following fields:
```c#
 int Id { get; set; }
 string Code { get; set; }
 string Description { get; set; }
```

2. Create a Model named 'Project'. This should have the following fields:
```c#
int Id { get; set; }
string ProjectNo { get; set; }
string Name { get; set; }
```

3. Create a Model named 'Attachment'. This should have the following fields:
```c#
int Id { get; set; }
string Filename { get; set; }
long Size { get; set; }
DateTime DateUploaded { get; set; }
```

4. Make the 'Register' Model a Foreign Key of the 'Document' Model linked thru the 'RegisterId' field.

5. Make the 'Project' Model a Foreign Key of the 'Document' Model linked thru the 'ProjectId' field.

6. Make the 'Attachment' Model a Child of the 'Document' Model linked thru a new field in the 'Attachment' Model named: 'DocumentId'.

7. Make the 'Register', 'Project' and 'Attachment' entities available in the ScenarioDbContext.

8. Make a logic that will create a default list of Register if data does not exists. Ensure that there are at least three (3) Register data.

9. Make a logic that will create a default list of Project if data does not exists. Ensure that there are at least three (3) Register data.

10. Make a logic that persists 'Document' object. Persisting Documents should have these conditions:
    a. DocumentNo field should be required.
	b. Subject field should be required.
	c. Register should be required and should enforce Foreign Key constraints.
	d. Project should be required and should enforce Foreign Key constraints.

11. Make a logic that persits 'Attachment' objects for a given 'Document'. Persisting Documents should have these conditions:
    a. Filename field should be required.
	b. FileSize field should always be greater that zero (0) and should be less than the byte equivalent of one (1) Gigabyte (GB).
	c. Document field should be required and should enforce Foreign Key constraints.