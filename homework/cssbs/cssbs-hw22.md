### Title: cssbs-hw22
#### Author: Greg Stephens
#### Date: 01 October, 2019
___
##### 1. Explain the difference between the concepts of associativity and precedence.
precedence refers to operators that are performed before other operator like * being performed before +

associativity is when an operator evaluates from right to left. like the assignment operator(=) assigning the right value to the left variable

##### 2. Explain the difference between the concepts of binary and unary operators.
unary operators have one operand, meaning it only performs it evaluation on a single evaluates(1++)

binary operators have two operands, meaning it uses two values to evaluate(1+1)

##### 3. List four constraints imposed by C# with respect to operator overloading.
- All operators must be public
- All operators must be static. Operators are never polymorphic and cannot use the virtual, abstract, override, or sealed modifiers.
- A binary operator (such as the + operator shown in this example) has two explicit arguments, and a unary operator has one explicit argument.
- at least one of the parameters must always be of the containing type.

##### 4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.
(pg 506)

##### 5. What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?


##### 6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain why not.


##### 7. What is the difference between overloading increment and decrement operators for value types and reference types?
the difference in a reference type is that when you increment a variable, you also increment the original variable too. in order to avoid this you create a new object with the incremented variable as an argument.(pg 509)

##### 8. Why do we overload some operators in pairs?
because certain operators are natural pair like ==  and !=,
but also the compiler will make you define each one explicitly

##### 9. What is the difference between widening conversion and narrowing conversion?
- An implicit conversion is sometimes called a widening conversion because the result is wider than the original value—it contains at least as much information as the original value, and nothing is lost.
- An explicit conversion is sometimes called a narrowing conversion because the result is narrower than the original value (that is, it can contain less information) and can throw an OverflowException exception if the resulting value is out of the range of the target type.

##### 10. What is the difference between explicit conversion and implicit conversion?
