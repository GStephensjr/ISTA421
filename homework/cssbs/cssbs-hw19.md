### Title: cssbs-hw19
#### Author: Greg Stephens
#### Date: 10 September, 2019
###### Read chapter 19, pages 423 - 438 in the C# Step by Step book.
___
##### 1. What is an enumerable collection?
- The quick answer is that it is a collection that implements the System.Collections.IEnumerable interface
  - The IEnumerable interface contains a single method called GetEnumerator(pg435)

##### 2. What properties and methods does the IEnumerable interface contain?
The IEnumerable interface contains a single method called GetEnumerator

##### 3. What properties and methods does the IEnumerator interface contain?
IEnumerator interface specifies the following property and methods:

    object Current { get; }
    bool MoveNext();
    void Reset();

##### 4. What values does the MoveNext() method return? What does it do?
- it advances the enumerator to the next element of the collection.
- it returns a boolean
https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext?view=netframework-4.8

##### 5. What values does the Reset() method return? What does it do?
- Sets the enumerator to its initial position, which is before the first element in the collection.
- it does not have a return type

https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.reset?view=netframework-4.8

##### 6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?
you enforce type safety by implementing typed parameters
https://www.c-sharpcorner.com/blogs/introduction-to-ienumerable-and-ienumerator

##### 7. Why don't recursive methods retain state when used with data structures like binary trees?
The main problem is that when defi ning an enumerator, you need to remember where you are in the structure so that subsequent calls to the MoveNext method can update the position appropriately
(pg437)

##### 8. How do you define an enumerator?
Enumerator knows exactly where you are in the collection (the current item)
https://stackoverflow.com/questions/3415107/definition-of-enumerator-in-c-sharp
##### 9. What is an iterator?
An iterator can be used to step through collections such as lists and arrays.

##### 10. What does yield do?
You use a yield return statement to return each element one at a time.
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield
