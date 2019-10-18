### Title: cssbs-hw20
#### Author: Greg Stephens
#### Date: 13 September, 2019
###### Read chapter 20, pages 439 – 466 in the C# Step by Step book.
___
##### 1. What is a delegate? Explain delegates in terms of pointers and reference types.
a delegate is sort of like a function pointer but type safe. it points to a method or a group of methods and is used to implement them

##### 2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
    public delegate int PerformCalculation(int x, int y);
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

##### 3. How do you create instances of delegates and assign values to the instance? What are the values?

the values of delegates of function pointers
    using System;

    namespace Akadia.BasicDelegate
    {
        // Declaration
        public delegate void SimpleDelegate();

        class TestDelegate
        {
            public static void MyFunc()
            {
                Console.WriteLine("I was called by delegate ...");
            }

            public static void Main()
            {
                // Instantiation
                SimpleDelegate simpleDelegate = new SimpleDelegate(MyFunc);

                // Invocation
                simpleDelegate();
            }
        }
    }
https://www.akadia.com/services/dotnet_delegates_and_events.html
##### 4. How do you invoke a method that has been added to a delegate?
call the delegate as if it were a method


##### 5. What is an event? Why do we have events?
Events are a special kind of multicast delegate that can only be invoked from within the class or struct where they are declared (the publisher class). If other classes or structs subscribe to the event, their event handler methods will be called when the publisher class raises the event

when an event is raised, that is when a situation arises that needs to be handled, you can assign procedures to handle the new arisen situation however needed

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event
##### 6. How do you declare events?
    public event SampleEventHandler SampleEvent;
event keyword

##### 7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
- Use the addition assignment operator (+=) to attach an event handler to the event
- Use the subtraction assignment operator (-=) to unsubscribe from an event
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-subscribe-to-and-unsubscribe-from-events
##### 8. How do you raise an event? How do you declare code that raises an event?
      class Counter
      {
          public event EventHandler ThresholdReached;

          protected virtual void OnThresholdReached(EventArgs e)
          {
              EventHandler handler = ThresholdReached;
              handler?.Invoke(this, e);
          }

          // provide remaining implementation for the class
      }
https://docs.microsoft.com/en-us/dotnet/standard/events/
##### 9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.
when an event fires the system runs the event handler which is the delegate that contains the methods to handle the event.
