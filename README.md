# OOP_Object_Oriented_Programming

### Object-oriented programming (OOP) is the core ingredient of the .NET framework. OOP is so important that, before embarking on the road to .NET, you must understand its basic principles and terminology to write even a simple program. The fundamental idea behind OOP is to combine into a single unit both data and the methods that operate on that data; such units are called an object. All OOP languages provide mechanisms that help you implement the object-oriented model.


### [Encapsulation](https://github.com/serhatyamann/OOP_Object_Oriented_Programming/tree/master/Encapsulation)

#### Encapsulation is the mechanism that binds together the code and the data it manipulates, and keeps both safe from outside interference and misuse. In OOP, code and data may be combined in such a way that a self-contained box is created. When code and data are linked together in this way, an object is created and encapsulation exists.

#### Within an object, code, data or both may be private or public to that object. Private code is known to and accessible only by another part of the object, that is private code or data may not be accessible by a piece of the program that exists outside the object. When the code and data is public, other portions of your program may access it even though it is defined within an object.

### [Inheritance](https://github.com/serhatyamann/OOP_Object_Oriented_Programming/tree/master/Inheritance)

#### Inheritance is the process by which one object can acquire the properties of another object. Inheritance is a "is a kind of" relationship and it supports the concept of classification in which an object needs only define those qualities that make it unique within the class. Inheritance involves a base class and a derived class. The derived class inherits from the base class and also can override inherited members as well as add new members to extend the base class.

#### A base type represents the generalization, whereas a derived type represents a specification of an instance. Such as Employees that can have diverse types, such as hourly, salaried and temporary so in that case Employees is the general base class and hourly, salaried and temporary employee are specialized derived classes.

#### Classes can inherit from a single class and one or more interfaces. When inheriting from a class, the derived class inherits the members including the code of the base class. The important point to remember is that Constructors and Destructors are not inherited from the base class.

### [Polymorphism](#)

#### Polymorphism is a feature that allows one interface to be used for a general class of action. This concept is often expressed as "one interface, multiple actions". The specific action is determined by the exact nature of circumstances.

### [Reusability](#)

#### Once a class has been written, created and debugged, it can be distributed to other programmers for use in their own program. This is called reusability, or in .NET terminology this concept is called a component or a DLL. In OOP, however, inheritance provides an important extension to the idea of reusability. A programmer can use an existing class and without modifying it, add additional features to it.

### [Classes and Objects](#)

#### Classes are special kinds of templates from which you can create objects. Each object contains data and methods to manipulate and access that data. The class defines the data and the functionality that each object of that class can contain.

#### The class header includes attributes, modifiers, and the class keyword. The class body encapsulates the members of the class, that are the data members and member functions. The syntax of a class declaration is as follows:

#### Attributes accessibility modifiers class identifier: baselist { body }

#### Attributes provide additional context to a class, like adjectives; for example the Serializable attribute. Accessibility is the visibility of the class. The default accessibility of a class is internal. Private is the default accessibility of class members. The following table lists the accessibility keywords;

Keyword | Description
------------ | -------------
public | Public class is visible in the current and referencing assembly.
private | Visible inside current class.
protected | Visible inside current and derived class.
Internal | Visible inside containing assembly.
Internal protected | Visible inside containing assembly and descendent of thecurrent class.

#### Modifiers refine the declaration of a class. The list of all modifiers defined in the table are as follows;

Modifier | Description
------------ | -------------
sealed | Class can't be inherited by a derived class.
static | Class contains only static members.
unsafe | The class that has some unsafe construct likes pointers.
Abstract | The instance of the class is not created if the Class is abstract.

#### The baselist is the inherited class. By default, classes inherit from the System.Object type. A class can inherit and implement multiple interfaces but doesn't support multiple inheritances.

### [Constructor and Destructor](#)

#### A constructor is a specialized function that is used to initialize fields. A constructor has the same name as the class. Instance constructors are invoked with the new operator and can't be called in the same manner as other member functions. There are some important rules pertaining to constructors as in the following;

* Classes with no constructor have an implicit constructor called the default constructor, that is parameterless. The default constructor assigns default values to fields.
* A public constructor allows an object to be created in the current assembly or referencing assembly.
* Only the extern modifier is permitted on the constructor.
* A constructor returns void but does not have an explicitly declared return type.
* A constructor can have zero or more parameters.
* Classes can have multiple constructors in the form of default, parameter or both.

### [Static Constructor](#)

#### A constructor can be static. You create a static constructor to initialize static fields. Static constructors are not called explicitly with the new statement. They are called when the class is first referenced. There are some limitations of the static constructor as in the following;

* Static constructors are parameterless.
* Static constructors can't be overloaded.
* There is no accessibility specified for Static constructors.

### [Destructors](#)

#### The purpose of the destructor method is to remove unused objects and resources. Destructors are not called directly in the source code but during garbage collection. Garbage collection is nondeterministic. A destructor is invoked at an undetermined moment. More precisely a programmer can't control its execution; rather it is called by the Finalize () method. Like a constructor, the destructor has the same name as the class except a destructor is prefixed with a tilde (~). There are some limitations of destructors as in the following;

* Destructors are parameterless.
* A Destructor can't be overloaded.
* Destructors are not inherited.
* Destructors can cause performance and efficiency implications.

### [Function Overloading](#)

#### Function overloading allows multiple implementations of the same function in a class. Overloaded methods share the same name but have a unique signature. The number of parameters, types of parameters or both must be different. A function can't be overloaded on the basis of a different return type alone. 

### [Interface](#)

#### An interface is a set of related functions that must be implemented in a derived class. Members of an interface are implicitly public and abstract. Interfaces are similar to abstract classes. First, both types must be inherited; second, you cannot create an instance of either. Although there are several differences as in the following;

* An Abstract class can contain some implementations but an interface can't.
* An Interface can only inherit other interfaces but abstract classes can inherit from other classes and interfaces.
* An Abstract class can contain constructors and destructors but an interface can't.
* An Abstract class contains fields but interfaces don't.

>###### Source: https://www.c-sharpcorner.com/

