### Title: mvc-hw08
#### Author: Greg Stephens
#### Date: 13 September, 2019

###### Read chapter 08, in the Pro ASP.NET Core MVC 2 book.
___
##### 1. What is the purpose of the Startup class in an MVC application?
The Startup class is responsible for configuring the ASP.NET Core application

##### 2. What is the purpose of the ConfigureServices() method?
The ConfigureServices method is used to set up shared objects that can be used throughout the
application through the dependency injection feature,

##### 3. What is the purpose of the AddMvc() method?
The AddMvc method that I call in the ConfigureServices method is an extension method that sets up the shared objects used in
MVC applications
##### 4. What does the book describe as “the heart of an MVC application?” Why do you think that this “heart” is the starting point of all applications?
the domain model because its a conceptual model that dictates the behavior and data of the entire project.


##### 5. What is the purpose of the Queryable<T> interface? What does it allow you to do?
Provides functionality to evaluate queries against a specific data source wherein the type of the data is known.

https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1?view=netframework-4.8

##### 6. How does the book describe loosely coupled components? Why is this an important principle of software design?
- loosely coupled components just means you can make a change in one part of the application without having to make corresponding changes elsewhere
-

##### 7. What, specifically, does the AddTransient() method do?
Adds the specified service as a Transient service to a collection

##### 8. Describe dependency injection? What is the dependency? What does it mean to say that it is injected?
- dependency injection (DI) is a software design pattern, and is a technique for achieving Inversion of Control (IoC) between classes and their dependencies
- A dependency is any object that another object requires
- "injecting" is a means of enforcing dependency on an object that wouldnt have ordinarily required it
##### 9. What is the purpose of a shared Layout?
to give a consistent look across all pages of your project

##### 10. What is a database context class? What purpose does it serve?
A DbContext instance represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database and group together changes that will then be written back to the store as a unit. DbContext is conceptually similar to ObjectContext

##### 11. What function does the EnsurePopulated() method perform?
The static EnsurePopulated method receives an IApplicationBuilder argument, which is the interface used in the Configure method of the Startup class to register middleware components to handle HTTP requests, and this is where I will ensure that the database has content.

##### 12. What is a ViewModel? How does a ViewModel differ from an ordinary model?
a view model is used specifically to pass data between a controller and a view..

##### 13. Describe in your own words a composable URL. Note that it is not an answer to this question to say that it is one that makes sense to a user.
a composable url lays out the location of the page. it should have a coherent name, an understandable nesting scheme and a number increment if there are multiple pages of the same subject

##### 14. What is a partial view? Illustrate the concept of a partial view with an example other than the one used in the book.
A partial view is a Razor markup file (.cshtml) that renders HTML output within another markup file's rendered output.
it would be effective if you only wanted to display one column of a table on a page without showing the rest of it
