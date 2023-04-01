# StepUpCsharp: Inheritance ...

In the provided example, you are able to use the functionalities of a List<string> without explicitly declaring a property or variable of type List<string> because the MyClass class directly inherits from List<string>. This means that MyClass is a subclass of List<string> and, as a result, inherits all the properties and methods available in the List<string> class.

When you create an instance of MyClass, it also creates an instance of List<string> internally, since it is a derived class. Therefore, you can directly access all the functionalities of a List<string> through the MyClass instance, without needing to declare a separate list property or variable.

This is an example of inheritance, which is a fundamental concept in object-oriented programming. Inheritance allows you to create new classes that reuse, extend, or modify the behavior defined in another class. In this case, the behavior of the List<string> class is reused and extended by MyClass.
