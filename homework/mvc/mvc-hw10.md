### Title: mvc-hw10
#### Author: Greg Stephens
#### Date: 29 September, 2019
___
##### 1. What are services? What are services commonly used for? Generally, how are services implemented? You don’t need to go into a lot of detail.
services are features that sit at the heart of asp.net core.
Services are most commonly used to hide details of how interfaces are implemented from the components that depend on them

##### 2. What does the AddScoped<T>() method do? Where do you call the method?
The AddScoped method specifies that the same object should be used to satisfy related requests for Cart instances.

##### 3. What does the AddSingleton<T>() method do? Where do you call the method?
the AddSingleton method specifies that the same object should always be used

addsingleton is called under the configure services method
##### 4. (Not in book) In the cotext of software design patterns, the term singleton has a specific meaning. What is the singleton pattern used for?
Ensures a class has only one instance and provides a global point of access to it.

A singleton is a class that only allows a single instance of itself to be created, and usually gives simple access to that instance.

Most commonly, singletons don't allow any parameters to be specified when creating the instance, since a second request of an instance with a different parameter could be problematic! (If the same instance should be accessed for all requests with the same parameter then the factory pattern is more appropriate.)

##### 5. Microsoft has removed support for Bower from Visual Studio. How do you install the Font Awesome package without using Bower?
fontawesome.com

##### 6. In building a shopping cart summary functionality, the author creates a view component that takes advantage of a service. Describe how a view component can take advantage of a service.


##### 7. What does the [BindNever] attribute do? Why do we need it?
Can only be applied to model properties, not to method parameters. Prevents model binding from setting a model's property

https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.0
##### 8. What does the HTML `<label>` element do? How does the author use it in build the HTML order checkout form?
The <label> tag defines a label for a <button>, <input>, <meter>, <output>, <progress>, <select>, or <textarea> element.

The <label> element does not render as anything special for the user. However, it provides a usability improvement for mouse users, because if the user clicks on the text within the <label> element, it toggles the control.

in the book its used to on the form inputs to implement functionality with the mouse

##### 9. What do the following two commands do?
      dotnet ef database drop --force
      dotnet ef database update

in powershell database drop drops the database without confirmation
database update updates the database to the last migration or to a specified migration.



##### 10. What do the following two LINQ methods do?
      .Include()
      .ThenInclude()


##### 11. What is the difference between Http GET and Http POST?


##### 12. What is the difference between server-side validation and cliet-side validation? Do we need both? If so, why do we need both?
