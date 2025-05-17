# Design-Pattern---Factory-Pattern
Project to demonstrate Factory Design Pattern


Factory Design Pattern in .NET 8

**Overview**

The Factory Design Pattern is a creational design pattern that provides an interface for creating objects in a super class, but allows subclasses to alter the type of objects that will be created. It promotes loose coupling and scalability by delegating the responsibility of object creation to a factory class or method.
This project demonstrates the implementation of the Factory Design Pattern in a .NET 8 application. It includes multiple notification services (EmailNotification, SMSNotification, WhatsAppNotification) that implement a common interface INotification.

Why Use the Factory Design Pattern?
1.	Encapsulation of Object Creation: The client code does not need to know the exact class to instantiate.
2.	Scalability: Adding new types of objects becomes easier without modifying existing code.
3.	Loose Coupling: The client code depends on abstractions (interfaces) rather than concrete implementations.
---
**Implementation Details**

**1. Interface Definition.**
The INotification interface defines the contract for all notification. 

**2. Concrete Implementations**
  The project includes multiple implementations of the INotification interface:
  
    •	EmailNotification
    
    •	SMSNotification
    
    •	WhatsAppNotification
   
    Each class implements the Send method to handle notifications in its own way

**4. Factory Class**
A factory class is used to encapsulate the logic for creating instances of INotification. This ensures that the client code does not need to know the exact implementation being used.

**5. Using the Factory**
The client code can use the factory to create instances of INotification dynamically:

---
**Benefits of This Implementation**

•	Extensibility: Adding a new notification type (e.g., PushNotification) only requires implementing INotification and registering it in the DI container.

•	Loose Coupling: The controller depends on the INotification interface, not the concrete implementations.

•	Centralized Object Creation: The factory or DI container handles the creation of objects, making the code cleaner and easier to maintain.
