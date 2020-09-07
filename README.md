# DesignPatterns
A guide created for myself with examples and explanations within the Readme of each Design Pattern.

Design patterns are best practices for coding solutions to consistent problems developers run into whilst programming.

- [X] Strategy example finished
- [X] Observer example finished
- [x] Singleton example finished
- [ ] Decorator example finished
- [ ] State example finished

## Terms
### Coupling:
Loose coupling detaches the components to reduce reliance on each other. For example, instantiating 2 objects then creating a function to get them both to interact would be tight coupling because there is a dependency on the logic of the main class to make them interact. This would then need to be duplicated in any other class that wants to do the same logic. 

If the first object instead had a function within it's class to handle the intended logic, then you could call 'object1.method(object2)' making the class hosting both objects interchangeable. This makes the code cleaner for better readability and adding new functionality to software becomes easier. 
