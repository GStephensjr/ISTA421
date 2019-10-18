### Title: cssbs-hw23
#### Author: Greg Stephens
#### Date: 08 October, 2019
___
##### 1 List two reasons for multitasking, and explain the rationale for them.
- responsiveness: keep your device from standing still by putting long running processes in the background while focusing on things like user input. the equivalent of not waiting for emails to be sent.
- scalability: improve scalability by making efficient use of the processing resources available and using these resources to reduce the time required to execute the operation

##### 2 Explain Moore’s law. What does Moore’s law have to do with multitasking?
Moore’s Law states that the number of transistors that can be placed inexpensively on an integrated circuit will increase exponentially, doubling approximately every two years

the closer transistors are placed together, the faster they transfer information and the faster computers can process information
##### 3 In UWP, what namespace is used as the container for the multitasking methods?
the Task class

##### 4 What is the difference between tasks and threads? Explain.
Page 358 paragraphs 2 and 3

##### 5 What is the ThreadPool?
A class that provides a pool of threads that can be used to execute tasks, post work items, process asynchronous I/O, wait on behalf of other threads, and process timers

https://docs.microsoft.com/en-us/dotnet/api/system.threading.threadpool?view=netframework-4.8

##### 6 What parameters does the Task() constructor take?
an action object. overloads are on the site below

https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.-ctor?view=netframework-4.8#System_Threading_Tasks_Task__ctor_System_Action_

##### 7 How do you start a thread?
thread.start() method

##### 8 What is the difference between the Start() and Run() methods?
the run method executes within the start method

The Run method takes an Action delegatespecifying the operation to perform (like the Task constructor) but starts the task running immediately.
It returns a reference to the Task object. You can use it like this:
      Task task = Task.Run(() => doWork());
When the method run by the task completes, the task fi nishes and the thread used to run the taskcan be recycled to execute another task

##### 9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.
- Internally, the Parallel class creates its own set of Task objects, and it synchronizes these tasks automatically when they have completed
- 

##### 10 Explain how manual cancellation works using a cancellation token
