/////////////Object-Oriented-Programming///////////////OBJECT ORIENTED PROGRAMMING////////////////////////
// Let us move on to more advanced topics in "Object Oriented Programming(OOP).

// This chapter, we will learn : *"inheritance"*                     ..NUMBER 18-431
//                              Writing the parent class
//                              Writiting the child class
//                              The Main() Method

//                               *"polymorphism"*                    ..NUMBER 433-621
//                              GetType() and typeof()
                               
//                               *"abstract classes and Methods"*    ..NUMBER 624-725

//                               *"interfaces"*                      ..NUMBER 727-820

//                               *"Access Modifiers Revisited"*      ..NUMBER 823-911

//|||||||Inheritance|||||||||///////////INHERITANCE/////////////--
// Inheritance is one of the key concepts of Object Oriented Progamming (OOP),
/*
  Inheritance allows us to create a "new class" from an "existing class" so that we
  can effectively 'reuse existing code'.
 */

////////Writing The Parental Class////.
/*
  Suppose we are writing a program for a fitness club that has two types of "membership" -
  "VIP" and "Normal".
 */
// To do that, let's create a 'class' called "Member" first.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassObject
{



    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;
    }

    // Member contains "one protected field" and "three private fields".
    /*
      A protected field is a field that is only accessible within the class in which
      is declared and any class that is derived from it.
     */
    // We'll talk about "derived classes" soon.

    // Next, let us write a "ToString()" method to display the values of the four fields :

    public override string ToString()
    {
        return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;
    }

    // finally lets 'add' "two constructors" to the "Member class".

    public Member()
    {
        Console.WriteLine("Parent constructor with no parameter");
    }


    public Member(string pName, int pMemberID, int pMemberSince)
    {
        Console.WriteLine("Parent contructor with 3 parameters");

        name = pName;
        memberID = pMemberID;
        memberSince = pMemberSince;
    }
}

// The 'first constructor' merely prints the line "Parent Constructor with no parameter".

// The secOnd constructor is a bit more interesting.
/*
   It prints the line "Parent Constructor with 3 parameters" and assign it's parameters
   to the three 'private fields' in the "Member Class".
 */

/////Writing The Child Class//////
//Now, let's learn how to "derive a class" from the "Member class".
// "Derived classes" are known as "Parent classes" or "base classes".

// A 'derived class" 'inherits' all the "public" and "protected members" from the "parent class".
// In other words, it can use those 'fields', 'properties' and 'methods' as if they are part of it's own code.

// A "Derived Class" inherits all the 'public' and 'protected' members from the 'parent class'.
// In other words, it can use those "fields", "properties" and "methods" as if they are part of own.

// Our parent class "(Member)" has the following contents :


          ///////Fields :

          protected int annualFee
          private string name
          private int memberID
          private int memberSince

          //////Methods :

          public override string ToString()

          //////Constructors :

          public Member ()
          public Member (string pName, int pMemberID, int pMemberSince)
           


// We shall derive two classes - NormalMember and VIPMember- from the Member Class.

// First, lets declare the "child class" NormalMember.
// We indicate that it is derived from the "Member class" using a colon (:) like this :

class NormalMember : Member
{

}
// Now we need to write the 'constructor' for the "child class".
// The "constructor" of a child class is built upon the "parent'sconstructor".
// Whenever we create a "child object", the parent class constructor is always called first.

// There are two ways to create a "child constructor" :
// The first way is to simply declare it like any other "constructor".

public NormalMember()
{
    Console.WriteLine("Child constructor with no parameter");
}

/* When we declare our "constructor" as above, C# looks for a "parameterless"
   constructor (i.e. a constructor with no parameter) in the 'parent class' and 
   calls that first before executing the code in the "child constructor".
*/

// If you use this "constructor" to create a "child object", the following two lines will be displayed on screen:
/*
    Parent constructor with no parameter
    Child constructor with no parameter
 */
// The first line is from the 'parent constructor', while the second line is from the "child constructor".

/* The second way to declare a 'child constructor' is to use the "colon sign(:)" and the base keyword
   to call a non "parameterless constructor" in the "parent class".
*/
// An example is shown below:
public NormalMember (string remarks) : base ("Jamie", 1, 2015)
{
    Console.WriteLine("Remarks = {0}", remarks);
}

/* When we call a non parameterless constructor in the parent class, we need to 
   'pass in values' to its "parameters".

In the example we passd in "Jamie" 1 2015 to the 'parent constructor'.
*/
// These values are then assigned to the fields "name", "memberID" and "membersSince" in the 'base class' respectively.

// In this example, we passed in fixed values as arguments to the "base constructor".
// However, a better way is to 'pass in the arguments' through the 'child constructor'.
// The example shows how this can be done.

// Replace the previous constructor with the constructor below :

public NormalMember (string remarks, string name, int memberID, int memberSince)
{
    Console.WriteLine("Child constructor with 4 parameters");
    Console.WriteLine("Remarks = {0}", remarks);
}

// The new child constructors has four parameters.
// The first parameter is a string parameter called 'remarks'.
// This parameter is used inside the "child constructor".

// The second, third and fourth parmeters are not used in the "child constructor"
// Instead they are passed in as arguments to the 'parent constructor' based on their names.

/* For instance, the second parameter in the 'child constructor'(string name) is passed in 
   as the first argument to the 'parent constructor' (name).
*/
// When we create a 'child object' with this 'constructor', we write something like :

NormalMember myChildMember = new
NormalMember("Special Rate", "Jamie", 1, 2010);

// The base "constructor" with 3 parameters is called and executed first.
// The values 'James', 1, and 2010 are passed to the base constructor.
/* Behind the scene, these values are assigned to the fields 'name', memberID and
   and memberSince in the base class respectively. 
*/

// When you run code, you will get the output ;
Parent Constructor with 3 parameters
Child constructor with 4 parameters
Remark = Special Rate
    
/* Now that we have created the 'constructors' for our 'child class', let us move
   on to create a method to calculate the 'annual fee' of a 'normal member'.
*/
// The code is simply :

    public void CalculateAnnualFee()
{
    annualFee = 100 + 12 * 30;
}

// When we write "annualFee" in the code above, we are accessing the protected field 'annualFee' in the parent class.
// Recall that a child class has access to all "public" and "protected fields" in it's 'parents class' ???
   // Hence, the 'child class' can use this filed as if it is it's own field.
// The child class does not need to create an instance of the 'parents class' in order to access it's protected fields.
// That's all for our 'child class' "NormalMember". The 'class' has the following contents:

//               //////    Fields :   /////////                 
//                         Inherited from parent class :
                          protected int annualFee
                        
                /////////  Methods :    //////////
//                        Inherited from parent class :
                          public override string ToString()

//                        Declared in child class :
                          public void CalculateAnnualFee()

//             //////////  Constructors :     //////////
                      
                          public NormalMember ()
                          public NormalMember (string remarks, string name, int memberID, int memberSince)

// Next, let us write another class that inherits from "Member".
// This time, the 'derived class' is called "VIPMember".
// The code for it is below :

class VIPMember : Member
{
    public VIPMember (string name, int memberID, int memberSince): 
    base (name, memberID, memberSince)
    {
        Console.WriteLine("Child constructor with 3 parameters");
    }

    public void CalculateAnnualFee()
    {
        annualFee = 1200;
    }
}

/* >>> This class has one 'constructor' (with 3 parameters) and one method "CalculateAnnualFee()."
   >>> The "CalculateAnnualFee()" method here uses a different formula for calculating annual fee
       from the "CalculateAnnualFee()" method in the "NormalMember" class.
   >>> It is alright for the two methods to share the same name (and signature) as they are in 
       "different classes"
.*/

// "VIPMember" class has thefollowing contents.

            //////  Fields     //////
      ///   Inherited from "parent class"
      protected int annualFee

     //////     Method ///////
     //     Inherited from "parent class"
     public override string ToString()

    //      Declared in "child class"
     public void CalculateAnnualFee()

    /////////   Constructors  ///////
     public VIPMember(string name, int memberID, int memberSince)


///// The Main Method///////>>>THE MAIN METHOD////////////////
/* Now that we have written the 'three classes' that we need, let's write
   the code for the "Main() Method". 
*/
// First, we'll create "two objects" from the two "derived classes".

NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
VIPMember mem2 = new VIPMember("Andy", 2, 2011);

// mem1 is created using the 4 parameters constructor from the "NormalMember" class.
// mem2 is created using the 3 parameters constructor from the VIPMember class.

// Next, we'll use the "CalculateAnnualFee()" methods in the respective classes.

mem1.CalculateAnnualFee();
mem2.CalculateAnnualFee();

// As "mem1" is an instance of the "NormalMember" class, the "CalculateAnnualFee()" method from that class is executed.
// The annual fee for "mem1" is thus 100 + 12 * 30 = 460
// For "mem2", the annual fee is 1200 as it uses the method from the "VIPMember" class.
// Finally, let's use the "ToString()" method from the "parent class (Member)" to display the information on screen. We Write :

Console.WriteLine(mem1.ToString());
Console.WriteLine(mem2.ToString());

/* Since the "ToString ()" method belongs to the 'parent class' and is public, both "mem1 and mem2"
   have inherited the method and are thus able to use it in the "Main()" method.
*/
// This facilitates code reause as we do not need to rewrite the "ToString()" method for both the "child classes".

// You'll see the Output when yo run this program : 


   Parent Constructor with 3 parameters
   Child Constructor with 4 parameters
   Message = Special Rate
   Parent Constructor with 3 parameters
   Child Constructor with 3 parameters

   Name : James
   Member ID : 1
   Member Since : 2010
   Total Annual Fee : 460

   Name : Andy
   Member ID : 2
   Member ID: 2011
   Total Annual Fee : 1200

// Complete Program Of The Above :::

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ClassObject
{
    class Member
    {
        static void Main(string[] args)
        {
            NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember mem2 = new VIPMember("Andy", 2, 2011);
        }
         protected int annualFee; 
         private string name; 
         private int memberID;
         private int memberSince;


    }

    public override string ToString()
    {
        return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;
    }

    public Member()
    {
        Console.WriteLine("Parent constructor with no parameter");
    }


    public Member(string pName, int pMemberID, int pMemberSince)
    {
        Console.WriteLine("Parent contructor with 3 parameters");

        name = pName;
        memberID = pMemberID;
        memberSince = pMemberSince;
    }

    class NormalMember : Member
    {

    }

    public NormalMember()
    {
        Console.WriteLine("Child constructor with no parameter");
    }

    public NormalMember(string remarks) : base("Jamie", 1, 2015)
    {
        Console.WriteLine("Remarks = {0}", remarks);
    }

    public NormalMember(string remarks) : base("Jamie", 1, 2015)
    {
        Console.WriteLine("Remarks = {0}", remarks);
    }

    public NormalMember(string remarks, string name, int memberID, int memberSince)
    {
        Console.WriteLine("Child constructor with 4 parameters");
        Console.WriteLine("Remarks = {0}", remarks);
    }

    NormalMember myChildMember = new
    NormalMember("Special Rate", "Jamie", 1, 2010);


    public void CalculateAnnualFee()
    {
        annualFee = 100 + 12 * 30;
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child constructor with 3 parameters");
        }

        public void CalculateAnnualFee()
        {
            annualFee = 1200;
        }

        mem1.CalculateAnnualFee();
        mem2.CalculateAnnualFee();
    
        Console.WriteLine(mem1.ToString());
        Console.WriteLine(mem2.ToString());
    }

 }

/////// Polymorphism  /////////>>>POLYMORPHISM//////
/* Now that we have seen an example of how "inheritance" works, let us move on to
   a topic that is closely related to 'inheritance' which is 'Polymorphism'.
*/
/* "Polymorhism" refers to a program's ability to use the correct method for an 
   object based on it's run-time type.
*/
// The best way to explain polymorphism is through an example.
// Let's expand on our "Fitness Club" example above.

// First delete all the code in the previous "Main()" method and Add the following lines :

Member[] clubMembers = new Member[5];

clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2010);
clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
clubMembers[3] = new VIPMember("Carol", 4, 2012);
clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

// Here, we declare an array of Member type and add 5 members to it.
/*
   The first "three members" are instances of the "NormalMember" class,
   while the last two instances are of the "VIPMember" class.
 */
// We do not need to declare seperate arrays for "NormalMember" and "VIPMember" objects.
// Next, we'll use a 'foreach' loop to calculate the "annualFee" of each member and display the information.
// To do that, we write :

foreach (Member m in clubMembers)
{
    m.CalculateAnnualFee();
    Console.WriteLine(m.ToString());
}

/*
   If you try to run the program at this stage, you'll get an error that says
   "Member' does not contain definition for "CalculateAnnualFee".
*/
// This is because "clubMembers" is declared to be an array of 'Member type'.
/* Hence, the compiler tries to execute the "CalculateAnnualFee()" method in the
   "Member class" when we write 'm.CalculateAnnualFee()'.
*/
/* An error occurs because we do not have such a method in our "Member" parent
   class; we only have it in the "two child classes".
*/
// To rectify this error, we have to add the following method to our 'parent class':

public void CalculateAnnualFee()
{
    annualFee = 0;
}

// Now run the program and pay attention to the "Total Annual Fee" for each member.
// What do you notice ? It should all show $0.
// This means the "CalculateAnnualFee()" method that is invoked is the one in the "parent class".
// This is not suprising as "clubMembers" is declared to be of "Member type".

// If you want the child method to be invoked instead, you have to make two changes :
// First you need to declare the 'parent method' as virtual, like this :
public virtual void CalculateAnnualFee()
{
    annualFee = 0;
}
// The "Virtual" keyword tells the compiler that this method may be overridden in "derived classes".
/* When the compiler encounters this keyword, it'll look for the same method in the "derived class"
   and execute that method instead.

 * Next, in the "derived class", you have to declare that your method overrides the method in the 
   "parent class" using the 'override' keyword, like this :
*/

// In VIPMember child class
public override void CalculateAnnualFee()
{
    annualFee = 1200;
}

// In NormalMember child class
public override void CalculateAnnualFee()
{
    annualFee = 100 + 12 * 30;
}
/* Now if you run the program again, the annualFee for the first three members
   (NormalMember) and the last two members (VIPMember) will be $460 and $1200 respectively.
*/
// This is the result of 'Polymorphism'.
/* At run-time (i.e. when the program runs), the program determines that the first three members
   of "clubMembers" are of "NormalMember" type and executes the "CalculateAnnualFee()" method from that class.

 * It also determines that the last two members are of "VIPMember" type, and executes the 'method' from that
   'class'.
*/
/* "Polymorphism" simply means that at run-time, the program us smart enoughto use the "CalculateAnnualFee()"
   method from the correct child class even when that object is declared to be of "Member" type.
*/
/* We say that the 'runtime' type of the first three elements of "clubMembers" is "NormalMember" while the
   "runtime type" of the 'last two elements' is "VIPMember".
*/
// The declared type of all the 5 elements is "Member".

////////--GetType() and typeof() /////////////////
/* In the previous example, we let the program determine the "runtime" type of each
   member of the "clubMembers" array and invoke the correct "CalculateAnnualFee()" method.

However, sometimes, it may be necessary for us to determine the 'runtime' type of
each individual member ourselves when we code.

We'll see that later in our projects.
*/

/*
   The "if" statement below shows how you can determine whether the first element of the 
   "clubMember" array is of "VIPMember" type at 'runtime'.
 */

if (clubMembers[0].GetType() == typeof(VIPMember))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

// The "GetType()" method returns the 'runtime' type of an object.

/*
   The 'typeof()' method takes the name of a data type (e.g. int, float, or the name ofa class)
   and returns the type of that name, which we can then compare with the result of the 
   "GetType()" method on the left.
 */

/*  If you run the code above, you'll get "No" as the output since 'clubMembers' [0] is not
    of "VIPMember" type.
*/


// Complete Program  /////-----
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ClassObject
{
    class Member
    {
        static void Main(string[] args)
        {
            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2010);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }
            
            public void CalculateAnnualFee()
            {
                annualFee = 0;
            }
        }

        class VIPMember:Member
        {
            public override void CalculateAnnualFee()
            {
                annualFee = 1200;
            }
        }

        class NormalMember:Member
        {
            public override void CalculateAnnualFee()
            {
                annualFee = 100 + 12 * 30;
            }
        }

        if (clubMembers[0].GetType() == typeof(VIPMember))
           Console.WriteLine("Yes");  
            else
           Console.WriteLine("No");
    }
 }


///////--Abstract Classes and Methods--////////
        /* Now that we're familiar with 'inheritance' (and polymorphism), let us move on to discuss
           two special types of "Parent Class" in C# "Abstract Classes" and "Interfaces".

        First, let's look at "abstract classes".
        */
        /* An abstract class is a special type of class that is created strictly to be a 
           base class for other classes to derive from.
        */
        // They can not be 'instantiated'.
        // In other words, if "fourWheelVehicles" is an abstract class, the statement :
        FourWheelVehicle myVeh = new FourWheelVehicle();
// will give you an error as you cannot create an object of an 'abstract' class.

// Abstract classes  may have 'fields', 'properties' and 'methods' just like any other classes.
// However, they cannot have 'static members'.
// In addition, 'abstract classes' can have a special 'type of method' known as 'abstract methods'.
// Abstract methods are methods that have no 'body' and MUST be implemented in the derived class.
// They can only exist in 'abstract classes'.
// In a way, an 'abstract method' is like a contract.
/*
  If you want to ensure that any class that inherits your class implements a certain
  method, you can declare the class as an 'abstract class' and the method as an 
  'abstract method'.
 */

/*
   To declare an abstract class, simply add the 'abstract' keyword before the 
   keyword 'class' like this :
 */

abstract class MyClass
{
}

/* To declare an 'abstract' method inside an 'abstract' class,
   add the 'abstract' keyword before the return type, like this :
*/
public abstract void MyAbstractMethod();

// As abstract methods have no body, we end the 'declaration' with a semi-colon (;).
// To implement an 'abstract method' in the 'derived' class, we use the 'override keyword', like this :
public override void MyAbstractMethod()
{
}

// The code below shows an example of an abstract class :-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyAbstractClass abClass = new MyAbstractClass();
            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();
            Console.Read();
        }
    }
    abstract class MyAbstractClass
    {
        private string message = "Hello C#";
        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
        public abstract void PrintMessageAbstract();
    }

    class ClassA : MyAbstractClass
    {
        public override void PrintMessageAbstract()
        {
            Console.WriteLine("C# is fun !");
        }
    }
}

// The abstract class is from line '523 to 531'.
// It contains a 'private field message' and a public method 'PrintMessage()'.
// It also contains an abstract method 'PrintMessageAbstract()' on line '530'.
// Lines '533 to 539' show the derived class which implements the abstract method (lines 530 to 538).

// If you run the program above, you'll get : Output :
/*
Hello C#
C# is fun
*/

// Notice that Line 516 is commented out with the // sign?
/*
   if we remove the two slashes, you will getan error as an 
   'abstract class' cannot be "instantiated".
 */

///////////////Interfaces///////////---INTERFACES/////////
// Let's look at "interfaces".
// Interfaces are much like abstract classes in that they cannot be 'instantiated' and must be inherited.
// However, 'interfaces' are more conceptual than 'abstract classes'.
// They can only contain methods with no bodies.
// In addition, they cannot contain 'fields' but can contain 'properties'.
// Interfaces also cannot have static members.
// When a 'child class' inherits an 'interface', we say that it 'implements' the interface.

/* One of the key differences between an abstract class and an interface is that a class
   can only 'inherit' one "abstract class" but can "implement multiple interfaces".
*/
/*
  We won't be showing an example of "multiple interfaces implementation" as that is an 
  advanced topic beyond the scope of this "book". 
 */

// The code below shows an example of how a 'class' can 'implement' one "interface".
// It is common to start the name of an 'interface' with the letter "I".
/*
  All "properties" and "methods" in an interface are public, so there is no need to 
  add any access modifiers to them :-
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[]args)
        {
            ClassA a = new ClassA();
            a.MyNumber = 5;
            a.InterfaceMethod();
            Console.Read();
        }
    }

    interface IShape
    {
        int MyNumber
        {
            get;
            set;
        }
        void InterfaceMethod();
    }

    class ClassA : IShape
    {

        public int myNumber;
        public int MyNumber
        {
            get
            {
                return myNumber;
            }
            set
            {
                if (value < 0)
                    myNumber = 0;
                else
                    myNumber = value;
            }
        }

        public void interfaceMethod()
        {
            Console.WriteLine("The number is {0}.", MyNumber);
        }
    }
}

// The "interface" is declared on lines 601 to 609
// On lines 603 to 607 we declared a 'property' and on line 611 we declared a "method".

// ClassA implements the "IShape interface".
/*
   The property is implemented on lines 614 to 628 where we 
   declared a 'private backing field' (myNumber) for the property
   and implemented some "control rules".
 */
// The method is implemented on lines 630 to 633.
/* We do not needto use the 'override' keyword when implementing a 'method' that
   belongs to an "interface".
*/
// If you run this program, you'll get : Output :
/*
The number is 5.
    */

////// Access Modifiers Revisited/////////////----
/* Now that we've covered various topics related to inheritance, let us take
   a second look at the concept of 'access modifiers' in Object-Oriented-Programming.
*/
// Erlier we learnt that an "access modifier" is like a "gate-keeper".
// It controls who has access to a certain "field", "property" or "method".
// C# comes with 4 access modifiers : "private", "public", "protected" and "internal".

/*
  * Anything declared as "internal" is only accessible within the current assembly.
  * As we won't be covering assemblies in this book, we will not be demostrating how
    "internal" works.
 */
// To understand how "private","public" and "protected" work, let's consider the example below.
// We'll be using 'fields' to demostrate the concept.
// The same applies to 'methods' and 'properties'.
// Suppose we have a class with "three fields" :

class ClassA
{
    private int privateNum = 1;
    public int publicNum = 2;
    protected int protectedNum = 3;
}

// If "ClassB" is derived from "ClassA",

class ClassB:ClassA
{
    public void PrintMessage()
    {
        // This is ok
        Console.WriteLine(publicNum);
        // This is ok
        Console.WriteLine(protectedNum);
        // This is NOT ok
        Console.WriteLine(privateNum);
    }
}
/*
  The first two WriteLine() statements will not give us any error
  as a derived class can access any "public" and "protected" fields
  in the "parent class".
 */
/*
  However, the third statement gives us an "error" as "privateNum" is a 'private field'
  and is thus only accessible in "ClassA" itself.
*/

/*
  If a 'class' is not derived from "ClassA", we need to instantiate a "ClassA" object
  in order to 'access' the "public field" of "ClassA".
  
  However, even with a "ClassA" object, we cannot access the "private" and "protected"
  fields of "ClassA".
*/
// In the example below, "ClassC" is not derived from "ClassA".
/*
   Hence, the first 'WriteLine()' statement will not give us any error but
   the second and third statements will :
 */
class ClassC
{
    ClassA a = new ClassA();

    public void PrintMessages()
    {
        // This is ok
        Console.WriteLine(a.publicNum);

        // This is  NOT ok
        Console.WriteLine(a.protectedNum);

        // This is NOT ok
        Console.WriteLine(a.privateNum);
    }
}

/*
   In short, anything that is derived as "public" is accessible everywhere;
   there are no restrictions on "accessing public members".
*/

/*
  On the other hand, anything declared as "private" is only accessible within
  the "class" in which it is declared.

  Anything declared as "protected" is accessible within the class in which
  it is declared and any class that is derived from it.
 */
