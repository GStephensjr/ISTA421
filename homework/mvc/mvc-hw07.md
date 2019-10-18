### Title: mvc-hw07
#### Author: Greg Stephens
#### Date: 8 September, 2019
###### Read chapter 07, in the Pro ASP.NET Core MVC book.
___

##### 1. There are many kinds of tests, including Unit Tests. What is a unit test, and what does it enable you to do?
- Unit testing is a form of testing in which individual components are isolated from the rest of the application
- so their behavior can be thoroughly validated

##### 2. What is the primary benefit of using unit tests?
write unit tests for features and functions will be hard to write and that are likely to be the source of bugs in deployment. unit testing helps structure thoughts about how to best implement what's needed
##### 3. What is the purpose of using method GetHashCode() when using Assert.Equal()?
Implement the GetHashCode method whenever you implement the Equals method. This keeps Equals and GetHashCode synchronized.

https://docs.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/7h9bszxx(v=vs.100)
##### 4. The book states: “[T]he chain of dependencies can make it difficult to understand what causes a test to fail.” Why is this statement true?
you will end up following a rabbit hole trying to pinpoint a bug because dependencies mean each component relies on the previous one working properly

##### 5. How do unit tests isolate small parts of an application?
Arrange - create objescts, Act - implement objects for testing, Assert - verify the actual outcome matches the expected outcome

##### 6. According to the book, what is the key to isolating components?
The key to isolating components is to use C# interfaces (Pg 175)

##### 7. Briefly discuss the nature and purpose of a fake implementation of a class. What does a fake implementation do that a real implementation cannot do?
- Isolating components effectively requires fake implementations of classes to provide test data or to check that a component behaves the way it should pg 186
- pg 178: fake implementation ensures your data will remain consistent, something that real data cannot always do

##### 8. What is test driven development? What is the development cycle for test driven development? This is not in the book.
test driven development is when you create a feature/unit of your complete program and test it immediately to make sure it does what it's supposed to do. every time you create a new part of your program you move immediately to the testing part of the cycle.

##### 9. What are parameterized tests and why would we want to use them?
A parameterized unit test (PUT) is the straightforward generalization of a unit test through the use of parameters. A PUT makes statements about the code's behavior for an entire set of possible input values, instead of just a single exemplary input value

https://stackoverflow.com/questions/31731884/parameterized-unit-tests-with-visual-studio-2015-intellitest/31767134
##### 10. What is a mocking framework? What is the difference between a fake object and a mock object?
- Fake: a class that implements an interface but contains fixed data and no logic. Simply returns "good" or "bad" data depending on the implementation.
- Mock: a class that implements an interface and allows the ability to dynamically set the values to return/exceptions to throw from particular methods and provides the ability to check if particular methods have been called/not called.
https://stackoverflow.com/questions/346372/whats-the-difference-between-faking-mocking-and-stubbing
##### 11. (Optional) Can you think of one very important drawback to writing unit tests?
