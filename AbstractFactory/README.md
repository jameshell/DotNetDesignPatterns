# Abstract Factory
### Definition
The intent of the abstract factory pattern is to provide an interface for creating
families of related or dependent objects without specifying their concrete classes.
### Common Usage Examples
- In this particular case, we will be using the following model:

![image](./assets/DiscountServiceAbstractFactory.png)


### Tips
- Use an abstract class when you need to provide some basic functionality that can
be potentially overridden.
- Use an interface when you only need to specify the expected functionality of a
class.
- An **Abstract Product** declares an interface for a type of product object.
- A **Concrete Product** defines the product that has to be created by a corresponding
factory, and implements the AbstractProduct interface.
- An **Abstract Factory** declares an interface for operations that create *Abstract Product*
objects.
- A **Concrete Factory** implements the operations to create *Concrete Product* objects.
- Updated model with *Concrete* and *Abstract* representations:
  ![image](./assets/DiscountServiceAbstractFactory2.png)
- The client uses only interfaces declared by *Abstract Factory* and *Abstract Product*.
### Pattern Consequences
- The client is decoupled from the concrete factory implementation.
### Related Patterns