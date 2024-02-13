# Factory Method
### Definition
The intent of the factory method patterns is to define an interface for creating
and object, but to let subclasses decide which class to instantiate. Factory
method lets a class defer instantiation to subclasses.
### Common Usage Examples
- When a class can't anticipate the class of objects it must create.
- When a class wants its subclasses to specify the objects it creates.
- When classes delegate responsibility to one of several helper subclasses and
you want to localize the knowledge of which helper subclass is the delegate.
- As a way to enable reusing of existing classes.
- For this project I will use a discount service scenario:
![image](./assets/DiscountService.png)
### Tips
### Pattern Consequences
- Factory methods eliminate the need to bind application-specific classes to your
code.
- New types of products can be added without breaking client code: **Open/Closed
Principle**.
- Creating products is moved to one specific place in your code, the creator:
**Single Responsibility Principle**.
- Clients might need to create subclasses of the creator class just to create a
particular ConcreteProduct object.
### Related Patterns
- **Abstract Factory:** Often implemented with factory method.
- **Prototype:** No subclassing is needed (not based on inheritance),
but an initialize action on Product is often required.
- **Template:** Factory methods are often called from within the template methods.