### Title: cssbs-hw21
#### Author: Greg Stephens
#### Date: 24 September, 2019
###### Read chapter 21, pages 479 – 502 in the C# Step by Step book.

___

##### 1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?
SQL is for database users that need to query the information in the database and doesnt care how the system retrieves it. the language is made specifically so that you can tell the system what you want and you let the system figure out how to get to it. sql is for external data(flat files)

linq is designed specifically to handle a wider variety of data datastructures with more flexibility but the only time you would use linq over SQL is in a .NET environment. linq is for data in memory or internal data

##### 2. What is the one essential requirement for the datastructures used with LINQ? Why is this requirement important?
it needs to have IEnumerable because the query statements have to be able to iterate throughout your collection like a table.(Pg 481)

##### 3. Were does the LINQ Select() method live?
it lives in the Enumerable class in the System.Linq namespace (pg 483)

##### 4. (Select) Explain, token by token, each token in this line of code:
    `IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);`

- customerFirstNames, of type IEnumerable<String>, is assigned the values of the query select (lambda expression getting each first name of customer) from customers


##### 5. (Filter) Explain, token by token, each token in this line of code:
    `IEnumerable<string> usCompanies = addresses.Where(addr => String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);`

- Ienumerable usCompanies is assigned the value of addresses where ((lambda expression addr iterates through countries that equal "United States")subquery select statement asking for all company names from the us)

##### 6. (OrderBy) Explain, token by token, each token in this line of code:
    `IEnumerable<string> companyNames = addresses.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName);`
companyNames equals addresses in order (subquery companynames from each address)

##### 7. (Group) Explain, token by token, each token in this line of code:
    `var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);`

    companiesGroupedByCountry(of type var) is equal to the addresses grouped by (addrs iterating through and finding each country)


##### 8. (Distinct) Explain, token by token, each token in this line of code:
    `int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();`

number of countries is an integer equaling (lamba expression getting each countries from each address) distinct taking only one of each, count adding them together.

##### 9. (Join) Explain, token by token, each token in this line of code:
    `var companiesAndCustomers =
      customers.Select(c =>
        new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs =>
        custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) =>
        new {custs.FirstName, custs.LastName, addrs.Country });`


##### 10. Explain the difference between a deferred collection and a static, cached collection.
 - in a deferred collection, because the collection is enumerated only after its been iterated over, the data in the collection can be changed between the time of the query and the actual retrieval of the data, meaning you have to iterate through your collection before obtaining the values from it

 - the evaluation of a linq query is forced in a cached collection. the cache is a copy of the original data and doesnt change when the original copy is iterated over. pg(497)
