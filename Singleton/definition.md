# Singleton
### Definition
The intent of the singleton pattern is to ensure that a class only has one
instance, and to provide a global point of access to it.
### Common Usage Examples
- **Logger:** It is often only required one logger to log all the information
found in the project
- Managing a database connection pool
- Caching frequently accessed data
- Managing application configuration settings
- General resource management
### Tips
- One instance is preferred to avoid unintended consequences.
- Make the class responsible for ensuring only one instance of itself exists.
- Holding the class instance in a global variable doesn't prevent clients from
creating other instances of the class.
- **Prefer lazy instantiation:** Create and store the instance when it's
requested for the first time and return that instance on subsequent requests.
- Make the implementation thread safe with Lazy < T >.
### Pattern Consequences
- Strict Control over how and when the client access it
- Avoids polluting the namespace with global variables
- Subclassing allows configuring the application with an instance of the class
that you need at runtime
- Multiple instances can be allowed without having to alter the client
- Violates the single responsibility principle
### Related Patterns...
- **Abstract Factory:** Can be implemented as a singleton
- **Builder:** Can be implemented as a singleton
- **Prototype:** Can be implemented as a singleton
- **State:** State objects are often implemented as singletons