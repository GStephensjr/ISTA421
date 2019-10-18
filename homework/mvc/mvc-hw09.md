### Title: mvc-hw09
#### Author: Greg Stephens
#### Date: 22 September, 2019
###### Read chapter 09, in the Pro ASP.NET Core MVC 2 book.

___
##### 1. In the Configure() method of the Startup.cs file, note the four map routes defined in the book.
-  ##### What is the difference in the definitions of the four routes defined?
they're all the same with the exception of the templates which are are all individual parts of the first map route definition (pgs 242-243)

-  ##### How are the routes ordered?
        routes.MapRoute(
        name: null,
        template: "{category}/Page{productPage:int}",
        defaults: new { controller = "Product", action = "List" }
        );

        routes.MapRoute(
        name: null,
        template: "Page{productPage:int}",
        defaults: new { controller = "Product",
        action = "List", productPage = 1 }
        );

        routes.MapRoute(
        name: null,
        template: "{category}",
        defaults: new { controller = "Product",
        action = "List", productPage = 1 }
        );

        routes.MapRoute(
        name: null,
        template: "",
        defaults: new { controller = "Product", action = "List",
        productPage = 1 });

        routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");


-  ##### Why does it matter that the routes are ordered this way?
if a component on the page is missing, the MapRoute still can define the page without the component


##### 2. When you define tag helpers, you can specify a prefix for the attribute name.
- ##### What happens when you define several attributes with the same prefix?
whenever those attributes are called with that prefix, the tag helper with the specified prefix is applied to the attributes

- ##### What is the benefit of doing this?
you can include/exclude the use of the helpers from specified prefixed or non prefixed attributes, like if you only wanted a certain font applied to some words

##### 3. How does using the attribute page-url-category benefit the application? Be specific with your answer and give an example.

##### 4. What is a view component and what purpose do view components have in building a web application?
- A view component is a C# class that provides a small amount of reusable application logic with the ability to select and display Razor partial views(pg 246)
- View components are intended anywhere you have reusable rendering logic that's too complex for a partial view, such as:
  - Dynamic navigation menus
  - Tag cloud (where it queries the database)
  - Login panel
  - Shopping cart
  - Recently published articles
  - Sidebar content on a typical blog
  - A login panel that would be rendered on every page and show either the links to log out or log in, depending on the log in state of the user

https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.2

##### 5. The book notes that you can build a list of categories programmatically or use the “more expressive Razor syntax” to render the HTML. What do you think that this means?


##### 6. What does @await Component.InvokeAsync("InformationSidebar") do?
- Within a view, view components are used through the @await Component.InvokeAsync expression
- it creates a view component with the "InformationSidebar" parameter and insert that view into the webpage

##### 7. Describe the functionality of the RouteData property of the ViewComponent class, and give a concrete example of that functionality.
routedata in the viewcomponent class returns the values for the current request. if you were looking for an ID that existed within the request, you could call it using RouteData.Values["ID"]

##### 8. What is the purpose of session state, and how does the Sports Store application use session state?
its used to store details of a current state, the sports store uses it specifically to store information on the user's cart

##### 9. Describe model binding and give a specific example. Explain how model binding relates form elements, HTTP query requests, variables, and properties.
model binding is when you match paramater names to input elements in HTML forms to associate incoming variables with the paramaters, and therefore automatically processing the form so you dont have to. (pg 265)

##### 10. What does the RedirectToAction() method do?
Redirects to the specified action using the included parameter(s) (string, Object)
