## Strategy Pattern

Program.cs instantiates the Dog Class in Main(). The Dog inherits the Animal Class which inherits the InterfaceFlys. The fly property in the interface is not directly accessed but instead changed through using other classes which also inherit the interface. These classes return a value for 'fly()' when called in the Animal method 'setFlyingAbility(new cantFly())'

This strategy's use case is to dynamically change an algorithm or property of a class used by an object at run-time. The algorithm here is that it can fly or it cant, and methods to change this are encapsulated within an interface to hide the logic or prevent unauthorized parties from accessing them.

An interface is a class with only abstract methods. A class can inherit many interfaces whereas they may only inherit from one other class. Abstract methods are for defining methods without giving them any logic. In this case the class 'itFlies' inherits the interface and returns/assigns the desired string when called.

The Animal class however uses the interface to define the property/behaviour of the animal, this is much better practice than hardcoding it in and then overriding methods within each subclass. That would cause a lot of duplicate code as the project gets bigger.
