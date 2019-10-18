### Title: mvc-hw11
#### Author: Greg Stephens
#### Date: 06 October, 2019
___
##### 1. The book states that, in an ideal wold, you would build your model classes at the start of a project, but that this happens only in the simplest cases. How does the iterative approach help deal with a world that is less than ideal?
the iterative approach allows you to develop and extend your models as you complete more of your application and define more requirements

##### 2. How would you use Entity Framework to add a new column to an existing table in your database?
dotnet ef migrations add(954)

##### 3. Can you explain why a web application might need different layouts for different aspects of the application? Note that the book adds an Admin Layout to the SportsStore project.
you would need different layouts for accounts that have different access levels, for example one account might have modifying capabilities and another account wont, they will need a different layout so the modifying account can have access to those capabilities

##### 4. Explain the rationale for having both a List view and an Edit view for the purpose of managing collections of objects.


##### 5. What is CRUD? Be specific. How does this relate to the SQL query commands we have studied?


##### 6. In the Admin Index cshtml file, the form uses an anchor tag (<a>) for the Edit function, and a submit button (<button type=‘‘submit’’>) for the Delete functionality. What is the difference, and why are the two HTML elements used?
when you go to the edit page all you need is the url for the edit page

##### 7. The book states that Entity Framework will not know anything about a new Product object when it is created, and will not update the database. Describe the book’s approach to resolving this problem.
update the database explicity(308)

##### 8. ASP.NET MVC supports a TempData dictionary. Describe the unique feature of this data object and explain its usefulness for this web application.
- TempData stays for a subsequent HTTP Request as opposed to other options (ViewBag and ViewData) those stay only for current request
- TempdData can be used to maintain data between controller actions as well as redirects

##### 9. Write a code snippet that displays a TempData[‘‘message’’] if one exists.
TempData["message"] = $"{product.Name} has been saved"(Pg317)

##### 10. What, specifically, does the asp-validation-for tag helper do when applied to a <span> element?
automatically creates client side validation and server side validation

##### 11. How does the mechanism used for server-side validation interact with client-side validation.
