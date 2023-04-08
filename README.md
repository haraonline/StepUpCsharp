# StepUpCsharp: Inheritance ...

In the provided example, you are able to use the functionalities of a List<string> without explicitly declaring a property or variable of type List<string> because the MyClass class directly inherits from List<string>. This means that MyClass is a subclass of List<string> and, as a result, inherits all the properties and methods available in the List<string> class.

When you create an instance of MyClass, it also creates an instance of List<string> internally, since it is a derived class. Therefore, you can directly access all the functionalities of a List<string> through the MyClass instance, without needing to declare a separate list property or variable.

This is an example of inheritance, which is a fundamental concept in object-oriented programming. Inheritance allows you to create new classes that reuse, extend, or modify the behavior defined in another class. In this case, the behavior of the List<string> class is reused and extended by MyClass.


## The ref keyword:

In C#, the ref keyword is used to pass a variable to a method by reference rather than by value. This means that when you pass a variable to a method using the ref keyword, the method can modify the original variable's value directly, instead of working with a copy of the variable. Any changes made to the variable inside the method will be reflected in the original variable outside the method.

To use the ref keyword, you need to do the following:

Declare the method parameter with the ref keyword.
Pass the argument to the method with the ref keyword.


## The out keyword:

In C#, the out keyword is used to pass a variable to a method by reference, similar to the ref keyword. However, there's a key difference: while both ref and out allow a method to modify the original variable's value, the out keyword indicates that the method must assign a new value to the parameter before the method returns. In other words, the out keyword is used when you want a method to return a value through one of its parameters.

To use the out keyword, you need to:

Declare the method parameter with the out keyword.
Pass the argument to the method with the out keyword.
