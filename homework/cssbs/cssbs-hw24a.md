### Title: cssbs-hw24a
#### Author: Greg Stephens
#### Date: 16 October, 2019
___
##### 1. What is an asynchronous method? When the book talks about a contract, what is the contract and who is it with?
- An asynchronous method is one that does not block the current thread on which it starts to run
- When an application invokes an asynchronous method, an implied contract expects the method to return control to the calling environment quite quickly and to perform its work on a separate thread.

##### 2. What can be the problem with decomposing a series of discrete method calls into a set of tasks, such as we saw in chapter 23?
- responsiveness becomes an issue
- user interface runs on a single thread and if its busy, the ui freezes


##### 3. What can be the problem with decomposing a series of discrete method calls into a set of continuations? When does the last continuation “complete” as compared to the previous continuations? What problem might this cause?
Unfortunately, this approach exposes another problem. If you try to run this code in debug mode, you will find that the final continuation generates a System.Exception exception with the rather obscure message, “The application called an interface that was marshaled for a different thread.” The issue here is that only the user interface thread can manipulate user interface controls, and now you are attempting to write to a TextBox control from a different thread(pg571)

##### 4. What might be the problem with implementing the previous solution as a continuation passing a delegate? What would be your interpretation with this error message: “The application called an interface that was marshaled for a different thread.”?
it means the separate processing thread is trying to perform a process that only the main processing thread can do

##### 5. The book suggests a solution using a continuation delegate calling another continuation delegate via an anonymous function. What does the book identify as a problem with this suggested solution?


##### 6. What does the async modifier do? What does the await operator do?
- The async modifier indicates that a method contains functionality that can be run asynchronously
- The await operator specifies the points at which this asynchronous functionality should be performed.

##### 7. What is an awaitable object? Be specific.
- An awaitable object is a type that provides the GetAwaiter method, which returns an object that in turn provides methods for running code and waiting for it to complete(pg572)
- its the buzzer on the dryer that buzzes when the dryer is done running

##### 8. In a method definition, how do you create and run a Task and return a reference to the Task? What is the type of such a method? What does the method return?
use the task class to define a task and then use the static run method within the task class to run your instansiated task. the run method returns a reference to the task

##### 9. How do you define method calls in the implementation of an async method? Specifically, you must define a task, you must run the task, you must implement the task, and you must await the task. What is the syntax for doing this?
within an async method use the await keyword

      private async void slowMethod()
      {
      await doFirstLongRunningOperation();
      await doSecondLongRunningOperation();
      await doThirdLongRunningOperation();
      message.Text = "Processing Complete";
      }

##### 10. What is the difference between decomposing a series of method calls that do not return values, and a series of method calls that return values? What is the Result property of a method that returns a value? How do you use the await operator in this circumstance?
- for method calls that return values, you need to use the generic task<TResult> class
- TResult specifies the return type of the method
- The result property is a property within the method that contains the return value of the methods
- you dont use the await method, the result property blocks blocks calls for the value until it obtains the value from the completed method
(pg 578)

##### 11. What is the difference between the await operator and the Wait method?
The await operator is not the same as using the Wait method of a task. The Wait method always blocks the current thread and does not allow it to be reused until the task completes
