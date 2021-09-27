# OOP_Object_Oriented_Programming
### Object-oriented programming (OOP) is the core ingredient of the .NET framework. OOP is so important that, before embarking on the road to .NET, you must understand its basic principles and terminology to write even a simple program. The fundamental idea behind OOP is to combine into a single unit both data and the methods that operate on that data; such units are called an object. All OOP languages provide mechanisms that help you implement the object-oriented model. They are encapsulation, inheritance, polymorphism and reusability. Let's now take a brief look at these concepts.

* OOP's overview
* Classes and Objects
* Constructor and Destructor
* Function Overloading
* Encapsulation
* Inheritance
* Interface
* Polymorphism

### [Encapsulation](https://github.com/serhatyamann/OOP_Object_Oriented_Programming/tree/master/Encapsulation)

#### Encapsulation binds together code and the data it manipulates and keeps them both safe from outside interference and misuse. Encapsulation is a protective container that prevents code and data from being accessed by other code defined outside the container.

### Inheritance

#### Inheritance is the process by which one object acquires the properties of another object. A type derives from a base type, taking all the base type members fields and functions. Inheritance is most useful when you need to add functionality to an existing type. For example all .NET classes inherit from the System.Object class, so a class can include new functionality as well as use the existing object's class functions and properties as well.

### Polymorphism

#### Polymorphism is a feature that allows one interface to be used for a general class of action. This concept is often expressed as "one interface, multiple actions". The specific action is determined by the exact nature of circumstances.

### Reusability

#### Once a class has been written, created and debugged, it can be distributed to other programmers for use in their own program. This is called reusability, or in .NET terminology this concept is called a component or a DLL. In OOP, however, inheritance provides an important extension to the idea of reusability. A programmer can use an existing class and without modifying it, add additional features to it.

### Classes and Objects

#### Classes are special kinds of templates from which you can create objects. Each object contains data and methods to manipulate and access that data. The class defines the data and the functionality that each object of that class can contain.

#### The class header includes attributes, modifiers, and the class keyword. The class body encapsulates the members of the class, that are the data members and member functions. The syntax of a class declaration is as follows:

#### Attributes accessibility modifiers class identifier: baselist { body }

#### Attributes provide additional context to a class, like adjectives; for example the Serializable attribute. Accessibility is the visibility of the class. The default accessibility of a class is internal. Private is the default accessibility of class members. The following table lists the accessibility keywords;

*Keyword	            *Description
*public	            *Public class is visible in the current and referencing assembly.
*private 	          *Visible inside current class.
*protected	          *Visible inside current and derived class.
*Internal	          *Visible inside containing assembly.
*Internal protected	*Visible inside containing assembly and descendent of thecurrent class.

