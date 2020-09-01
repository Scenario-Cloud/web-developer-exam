# Welcome!
If you're here, you may be interested for a Software Developer / Web Developer post for [Scenario Cloud](https://www.scenariocloud.com) team. Please read the sections below for the coverage of the exam.

# Solution - ScenarioCloud.WebDeveloperExam
In this Repository, a .NET Solution file with three Projects coded in C# can be found.

# Project - ScenarioCloud.WebDeveloperExam.Business
This .NET Class Library Project contains initial models that will be used throughout the App. By the end of the exam, the App should be utilizing Entity Framework using the model(s) that can found in this Project.

# Project - ScenarioCloud.WebDeveloperExam.Data
This .NET Class Library Project contains inital DbContext that will be used throughout the App. This Project should also include the business logic when persisting data - which will be described as part of the requirements of the exam.

# Project - ScenarioCloud.WebDeveloperExam.Web
This .Net Web Application Project will be the main App. This will contain the UI itself and any UI-related logic.

# Getting Started
The first thing to do is [Clone](https://github.com/Scenario-Cloud/web-developer-exam.git) this Repository.

```bash
git clone https://github.com/Scenario-Cloud/web-developer-exam.git
```

Afterwards, create a branch named '{Your First Name}.{Your Middle Initial}.{Your Last Name}' which will serve as your working branch. 

Example:

```bash
git checkout -b juan.c.delacruz 
```

# Requirements - Server Side / Backend
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

9. Make a logic that will create a default list of Project if data does not exists. Ensure that there are at least three (3) Project data.

10. Make a logic that persists 'Document' object. Persisting Documents should have these conditions:

    a. DocumentNo field should be required.
	
	b. Subject field should be required.
	
	c. Register should be required and should enforce Foreign Key constraints.
	
	d. Project should be required and should enforce Foreign Key constraints.

11. Make a logic that persists 'Attachment' objects for a given 'Document'. Persisting Attachments should have these conditions:

    a. Filename field should be required.
	
	b. FileSize field should always be greater than zero (0) and should be less than the byte equivalent of one (1) Gigabyte (GB).
	
	c. Document field should be required and should enforce Foreign Key constraints.
	
	d. DateUploaded should be the date and time the data is persisted but in UTC.
	
12. Setup all of the data persisting and business logic into a Web API.

BONUS: Create a API method that will return a list of the below object type:

```c#
public class DocumentInfo
{
  public int Id { get; set; }
  public string DocumentNo { get; set; }
  public string Subject { get; set; }
  public string RegisterCode { get; set; }
  public string ProjectNo { get; set; }
  public int AttachmentCount { get; set; }  
}
```

The API method should acccept a criteria object as its payload as shown below.

```c#
public class DocumentSearchCriteria
{
  public int? DocumentId { get; set; } // this should search a Document with particular Id if value is supplied.
  public int[] RegisterIds { get; set; } // nullable - this should search Documents with matching Register Ids if value(s) is (are) supplied.
  public int[] ProjectIds { get; set; } // nullable - this should search Documents with matching Project Ids if value(s) is (are) supplied.
  public string SearchText { get; set; } // this should search keywords in the Document's Subject and DocumentNo fields if value is supplied.
  public bool? WitAttachments { get; set; } // this should search whether a Document has Attachments or not if value is supplied.
}
```
 
The method that will return the list of the DocumentInfo object should be produced through the use of Raw Sql Statement (Query). 

This feature is a nice to have but not really required.

# Requirements - UI / Frontend

1. Create a UI that will list all of the available Documents. The list should have the following feature:

   a. The list should be able to display at least these fields: Project, Register, DocumentNo, Subject.
   
   b. A button / link that will enable adding new Document should be available within this page.
   
   c. A list item should be capable of handling edits or deletions.
   
   BONUS: If possible, add something that can indicate Attachment(s) exists for a list item. Nice to have - but not really required.
 
2. Create a UI for entering Document Information. The page should have the following feature:

   a. Able to select the Register for the Document.
   
   b. Able to select the Project for the Document.
   
   c. A section that could add Attachment(s) for the Document.
   
   BONUS: Some Form Validation in the client-side. Nice to have - but not really required since the server-side should be able to handle validations as well.
   
   BONUS: Display Attachment's upload Date and Time based on browser's timezone.
  
# Additional Notes
You are free to use any tool and libraries you think that can make your coding efficient as long as you are not violating any licensing agreement. This applies both on the Backend and the Frontend.

For SQL Database, you're also free to choose the engine you may want. But it will be nicer if you plug the App using MS SQL Server. :)
  
# Submission
Once your OK and confident with your work, push your working branch and do a [Pull Request](https://github.com/Scenario-Cloud/web-developer-exam/pulls) going to the 'master' branch so we can do the review.

Good Luck and Happy Coding! ;)

- Scenario Development Team