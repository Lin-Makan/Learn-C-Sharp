// Object Oriented Programming (OOP) >>>>>OBJECT ORIENTED PROGRAMMING//////////////////

/* In this chapter, we'll learn what "object-oriented-programming" is and how to 
   write our own "classes" and "create objects" from them.
 In addition, we'll discuss the concept of "fields", "properties", "contructors"
 and "methods".
 */      // We'll cover :
/*
 * What is Object-Oriented-Programming ?            NUMBER : 23-30
 * Writing our own class                            NUMBER : 32-112
 * Fields                                           NUMBER : 113-173
 * Properties                                       NUMBER : 174-347
 * Methods                                          NUMBER : 346-567
 * Constructors                                     NUMBER : 568-614
 * Instantiating an Object                          NUMBER : 615-851
 * Static Keyword                                   NUMBER : 852-931
 * Advanced Method Concepts                         NUMBER : 932-938
 * Using Arrays and Lists                           NUMBER : 939-1010
 * Using "Params" Keyword                           NUMBER : 1011-1062
 * Passing Value Type vs Reference Type Parameter   NUMBER : 1063-1141
 */

///////////////////What is  Object-Oriented-Programming ? /////////////////////////
/* OOP is an approach to programming that breaks a "programming problem"
   into 'objects' that 'interact' with each other.

Objects/OBJECTS are created from templates known as "classes".
You can think of a "class" a 'blueprint' of a building.
An "object" is the actual "building" that we build based on the 'blueprint'.
*/

///////////--Writing Our Own Class--///////////// WRITING OUR OWN CLASS//////////////////
// For instance, to create a "Staff class", we write :
/*

class Staff
{
    // contents of the class
    //including 'fields', 'properties' and 'methods'
}
*/
// It is common practice to use "Pascal Casing" when naming our "classes".
/* Pascal Casing refers ti the practice of capitalizing the first letter of each word,
   including the first word (e.g : ThisIsAClassName).
This is the convention we'll be using here throughout.
 */

// The content of the class is enclosed within the pair of 'curly braces' that follow the "class name".
/*
   Contents of a "class" include : * Contructors
                                   * Destructors
                                   * Constants
                                   * Fields
                                   * Methods
                                   * Properties
                                   * Indexes
                                   * Operators
                                   * Events
                                   * Delegates
                                   * Interfaces
                                   * Structs
                                   * And other "Classes"
 */
/* We'll cover more of the 'common elements' of a "Class" :
                                                            * Fields
                                                            * Methods
                                                            * Properties
                                                            * Constructors
*/
// Let's now build a class from scratch 
// CREATE A new console Application project called "ClassDemo".
// the namespace is called ClassDemo 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Read();

        }
    } 
}
/* By default, the "Main()" method (which is the starting point for all C# applications)
   is put into the "Program Class" created by VSC.

   If we want, we can change the name of the "Program class" to something
   else, but the "Main() method" must be called "Main()".
   
   The Main() Method must be present in all C# Applications at all times.
*/
// Next in this chapter, we are going to add a second class to the "ClassDemo" namespace.

//We'll call this "new class" 'Staff' and add "fields", "properties" and "methods" to the 'class'.

// Let's first declare first declare the "class".
/*
   class Staff
   {

   }
 */
// We now have "two classes" in our project: "Staff" and "Program".

//////--Fields--////////////////////FIELDS///////////////
// Inside the "Staff class" add the lines:


   class Staff
   {
     private string nameOfStaff;
     private const int hourlyRate = 30;
     private int hWorked;
   }

// Here, we declare one string variable "(nameOfStaff)" and two "int variables" 
// These "VARIABLES" are known as "fields of the class".
// A field is simply a Variable that is 'declared' "inside a class".
// Just like any other 'variable', they are used to "store data".

// Notice that there is a word "private" in front of "each declaration statement ???
// This is known as an "Access Modifier".
/* Access Modifiers are like 'gate keepers', they control who has access to that "field"
   (i.e.  who can read and 'modify' the "value of that field").
*/
// A field can either be "private", "public", "protected" or "internal".
// in our case, we've declared three fields as "private".
// This means that they can only be accessed from within the "staff" class itself.

// There are two reasons why we do not want the three "fields" to be accessible outside the "class".

// The first reason is that there is no need for other "classes" to know about those "fields".
/* In our case , the field "hourlyRate" is only needed within the "Staff class" that
   uses the field "hourlyRate" to calculate the "Monthly Salary" of an 'Employee'.

Other "classes" do not use the "hourlyRate" field at all.
Hence, it is appropriate to declare "hourlyRate" as "private" so as to hide this 'field' from other "classes".
* This is known as "Encapsulation"/"ENCAPSULATION". 
* "Encapsulation" enables an 'object' to 'hide data' and behaviour from other "classes' that don't 
  need to know about them.

This makes it easier for us to make changes to our code in future if neccessary.

We can safely change the value of "hourlyRate"  inside the "Staff class" without 
affecting other "classes".
*/

/*
   The second reason for "declaring a field" as 'private' that we do not want other classes
   to "freely modify" them.
   This helps to prevent the 'fields' from being corrupted.
 */

/* Apart from the "private" keyword, we also added the "const" keyword when we declared the 
   the "hourlyRate" field.
*/
private const int hourlyRate = 30;

// The "const" keyword indicates that the value cannot be changed after it is created.
// The 'const' keyword is extreme 'encapsulation'.
// "const" is the 'keyword' to create 'constants' (variables which don’t change their value).
// Any variable that is declared as "const" must be 'initialized' at the "point of declaration".
// In this example we initialized "hourlyRate" to 30.
// This value cannot be changed subsequently anywhere in the code.

///////////////--Properties--///////////////////PROPERTIES////////////////////
// Next, look at properties.
/* A property is commonly used to provide access to a "private field" in cases
   where the "field" is needed by other "classes".

* This may sound like a contradiction, did'nt we say that we use "private fields",
  so that other "classes" do not have access to them ???
* If that is the case, why are we 'allowing access' to the via 'propeties" ???

* One of the main reasons is that using "properties" gives us greater control over
  what rights other "classes" have when accessing these "Private Fields".
We'll see how to do that later ;
for now lets learn how to declare a "property".
*/

// Add the following lines of code to our "staff class", after the  the line "private int hWorked."

class Staff
{
    private string nameOfStaff;
    private const int hourlyRate = 30;
    private int hWorked;
    public int HoursWorked                         // <<<<<< Here we declared our "Property".
    {
        get
        {
            return hWorked;
        }
        set
        {
            if (value > 0)
                hWorked = value;
            else
                hWorked = 0;
        }
    }
}

/* We declared our property as :public int HoursWorked
                                {
                                }  

 * The access modifier is 'public' as we want other "classes" to have 
   access to this "property".
*/
/* The 'data type' is 'int' because this property is used to provide 
   'access' to the private int "field hWorked"
 */
// hWorked is known as the backing field of the 'property'.
// The name of the 'property' is "HoursWorked".
// We usually use "PascalCasing" for 'property' names.
// 
//  A "Property"/ PROPERTY contains two special methods known as 'accessors'.
//  The 'first accessor' is a "getter" and the 'second accessor' is the "setter".

// The basic getter simply returns the value of the "private field", Hence We Write :
get
{
    return hWorked;
}

// When 'return' is a keyword and 'hWorked' is the name of the backing field.

// The setter sets the value of the "private field", we write :
set
{
    if (value > 0)
        hWorked = value;
    else
        hWorked = 0;
}

// Value is a keyword when it is used inside a "setter".
/* It refers to the 'value' that is an on the 'right side' of 'assignment' statement
   when users use the "property" to set the 'value' of the "private field".

>> Inside the "setter", we did a simple check using an 'if statement'.
>> We checked if value is more than zero.
>> If it is, we assign it to "hWorked".
>> Else, we set "hWorked" to zero.
>> This 'setter' demonstrates how we can use properties to control
   what values can be assigned to our 'private field'.

*/
/* By default, "getter" and "setter" have the same access level as the property itself
   ('public' in this case), Hence we do not need to specify them.
*/
/* HOWEVER, if you don't want the 'setter' to have the same access level as the 
   property, you can declare the "setter" as private so that other classes 
   cannot modify your "private field" :
*/
private set
{

}
// The property is then a read-only property outside the "Staff" class
// It's value can only be set within the "Staff class" itself.

//////////////////////Completed Program////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Read();

        }
    }

    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        public int HoursWorked                         // <<<<<< Here we declared our "Property".
        {
            get
            {
                return hWorked;
            }
            private set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }
    }
}

////////Auto-implemented Properties///////////////////////////

/* Note that in cases where no 'additional logic' is required in the 'getter' and 
   'setter', C# provides us with a shorthand to declare the property.
This is known as an "auto-implemented property".             { get; set; }
*/
// To declare an 'auto-implemented' property , we write :
public int HoursWorked { get; set; } 


// This is equivalent to :
  private int hWorked;
  public int HoursWorked
   {
     get
     {
         returned hWorked;
     }
     set
     {
       hWorked = value;
     } 
}

/*
  When you use this shorthand, you do not have to declare a "private field"
  The compiler will create an anonymous "private backing field" for 'automatically'.
 */
// If you want to make the 'property read-only', you can set the 'setter' to private like this : 
public int HoursWorked { get; private set; }


//////////////////Methods////////////////////METHODS///////////////////////
// Next, let us look at 'methods'.
// A "method" is code block that performs a certain task.
// Lets add a method to our "Staff" class.

public void PrintMessage()
{
    Console.WriteLine("Calculating Pay...");
}
// The 'Method' is declared as :

/* 
   public void PrintMessage()
   {
   }
 */
// The "Method" declaration first states the accessibility level of the 'method'.
/* Here we declared the method as 'public' so that the method is accessible 
   everywhere in the program (not just within the 'Staff class').

Next, we state the return type of the method.
A 'method' may "return" a 'certain result' after performing it's task.
If the method does not return any result, we use the "void" keyword in our example.
*/
// Finally, we state the name of the 'method' ("PrintMessage" in our example).
// The "Parenthesis()" after the method name is where we include the parameters of the method.
// "Parameters" are names given to 'data' that we 'pass in' to the "method" in order for it to 'perform' it's task.
// If the method requires no data, (like our example above), we just add a pair of empty parenthesis after the method name.

// After we declare the method, we define what it does inside the pair of curly braces that follow.
// This is known as implementing the method.
// In our example the "PrintMessage()" Method simply prints the line "Calculating Pay...".
// Thats all to the "PrintMessage()" method.

// Next, lets move to a more complex method.
// The second method 'calculates' the 'pay' of 'each employee' and 'returns' the 'result' of the calculation.
// Add the following lines of code to "Staff" :

public int CalculatePay()
{
    PrintMessage();

    int staffPay;
    staffPay = hWorked * hourlyRate;

    if (hWorked > 0)
        return staffPay;
    else
        return 0;
}
// This method is declared as :
public int CalculatePay()
{
}

/*
   The 'int' keyword indicates that this mwthod returns a value that is of "int" type (datatype).
 */
// Inside the curly braces, we have the statement :
PrintMessage();

// This is known as calling the "PrintMessage()".
/* When the program reaches this statement, it will execute the 'PrintMessage()' method first
   and print the line "Calculating Pay..." before executing the rest of the "Calculate Pay()" method.
 */
// This example demonstrates how you call one method inside another 'method'.

/* Next, we declare a "local variable" called "StaffPay" and assign the product of the private fields 
   'hourlyRate' and 'hWorked' to it.
*/
// A 'method' can 'access' all the "fields" and "properties" that are declared inside the "class".
// In addition, it declare it's own 'variables'.
// These are known as "Local Variables" and only exist within the 'method'.
// An example is the 'StaffPay' variable in our example.

/* After assigning the "staffPay" Variable, we use an if statement to determine what result
   the 'method' should return.
*/
// A method usually has a least "one return statement".
// return/RETURN is a keyword that is used to 'return' an 'answer' from the "method".
// There can be more than one "return" statement in a method.
// However, once the method executes a "return statement", the method will exit.

/* In our example, if hWorked is greater than zero, program will execute the statement :  "return StaffPay;"
   and exit the method.
 */
// This return value can then be assigned to a variable.
// For instance, if 'hWorked' is 10 and hourlyRate is 20, we can use the statement:-
int pay = CalculatePay();
// to assign the result of "CalculatePay()" to the variable pay.
// The value of pay will then be 200.
// On the other hand, if "hWorked" is less than or equal to zero, the program will execute the statement:-
return 0;
// and exit the method. The value of pay will be "0".


/////////////Overloading////////////OVERLOADING/////////////////////////
/* In C#, and other most languages, you can create two methods of the same name as long
   as they have different signatures.
This is known as "overloading".
 */
// The signature of a method refers to the name of the method and the parameters that it has.
// Add the following method below the previous "CalculatePay()" method :

public int CalculatePay(int bonus, int allowance)
{
    PrintMessage();

    if (hWorked > 0)
        return hWorked * hourlyRate + bonus + allowance;
    else
        return 0;
}

/* The signature of the first method is 'CalculatePay()' while that of the second method
   is 'CalculatePay(int bonus, int allowance)'.
*/
// This second method has two parameters - "bonus" and "allowance".
/* It calculates the pay of the employees by adding the values of these two 
   parameters to the product of "hWorked" and "hourlyRate".

>>> In this example we did not use a 'local variable' to store the result of 'hWorked * hourlyRate + bonus
    + allowance'.
>>> We simply return the result of the computation directly. This is okay to do.
*/
// We'll learn about this method later.

///// >>>>>>>>>>>>>>>>>  The Completed Program  <<<<<<<<<<<<<<< //////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Read();

        }
    }

    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        public int HoursWorked                         // <<<<<< Here we declared our "Property".
        {
            get
            {
                return hWorked;
            }
            private set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }
    }
}

//--------------------------------------------------------------------------------------------------

//////The ToString() Method/////////////////TOSTRING() METHOD///////////////////////

/*
   The "ToString()" Method is a special method that 'returns' a "string" that represents
   the "current class".
 */
// In C#, all classes come with a pre-defined "ToString()" Method.
// However, it is customary (and expected of us) to "override" this method.
// "Overriding" a method simply means writing our own version  of the "method".

/* Typically, the "ToString()" method that we write displays the values of the
   "Fields" and "Properties" of the 'class'.
 */
// Add the following code to the "Staff class" :

public override string ToString()
{
    return "Name of staff = " + nameofStaff + ", hourlyRate = " + hourlyRate + " , hWorked = " + hWorked;
}

// As you can see, the "ToString" method returns a 'string' type.
// The string that it returns contains information about the "Staff" class.
// The "Override" keyword in the method declaration indicates that this method overrides the default method.

// We'll dicuss more about the "Override" keyword in chapter 8.


//---------------------------------------------------------------------------------------------------------------
////////--Constructors--///////////////>>>///////////CONSTRUCTORS//////////////////
// A constructor is a special method that is used to 'construct' an 'object' from the 'class template'.
// It is the first method that we call whenever we create an "object" from our class.
// Constructors are commonly used to "initialize" the 'fields of the class'.

/* A "Constructor" always has the same name as the class ("Staff" in our case)
   and it does not 'return' any "value".
*/
// We do not need to use the 'void' keyword when declaring a constructor.
// Add the following lines of code to our "Staff" class :

public Staff (string name)
{
    nameofStaff = name;
    Console.WriteLine("\n" + nameofStaff);
    Console.WriteLine("-------------------------");
}

/*
   In this "Constructor", we first initialize the field nameofStaff with the string
   that is passed in to the "Constructor" (name).

   We then display the value of "nameofStaff" on the screen and underline it with a series of dashes.
 */
// Like any other method, we can have more than one "constructor" as long as the signature is different.
// We can add another 'constructor' to our 'class' :

public Staff(string firstName, string lastName)
{
    nameofStaff = firstName + "" + lastName;
    Console.WriteLine("\n" + nameofStaff);
    Console.WriteLine("------------------------------");
}

// This 'constructor' has two parameters - "firstName" and "lastName".
// The first line 'concatenates' the "two strings" and "assigns" the resulting string to 'nameofStaff'.
// The next two lines print 'nameofStaff' on the screen and underline it with a series of dashes.

// Declaring a 'constructor' is optional.
// If you do not declare your own constructor, C# creates one for you automatically.
/*
   The default "constructor" simply 'intitalizes' all the fields in the class to
   default values, which is normally zero for numerical fields and 'empty string' for 'string fields'.
 */

//------------------------------------------------------------------------------------------------------------

/////////--Instantiazing An Object--///////////////INSTANTIAZING AN OBJECT/////////////
/*
   Now that we know how to create a class, let's look at how we can make use of
   the "class" to create an object.

  This processed is known as "instantiazing an object".
An object is known as an 'instance'.
*/

// To recap, our "Staff class" has the following components : 

//                  "Fields"
             private const int hourlyRate
             private string nameofStaff
             private int hWorked 

//                  "Properties"
             public int HoursWorked

//                  "Methods"
             public void PrintMessage()
             public int CalculatePay()
             public int CalculatePay(int bonus, int allowance)
             public override string ToString()

//                 "Constructors"
             public Staff(string name)
             public Staff(string firstName, string lastName)


// We shall instantiate a "Staff" object in the "Main() method" inside the "Program class".

//  The "Syntax" for "instantiazing" an Object is :-

ClassName objectName = new ClassName(arguments);

// Add the following lines inside the 'Curly Braces' of the Main() method in the "Program Class".

int pay;

Staff staff1 = new Staff("Peter");
staff1.HoursWorked = 160;
pay = staff1.CalculatePay(1000, 400);
Console.WriteLine("Pay = {0}", pay);

/// <summary>
/// ///////////////////////////////////////////////////////////////////////////////////////
/// </summary>

static void Main(string[] args) {
    
    int pay;

    Staff staff1 = new Staff("Peter");
    staff1.HoursWorked = 160;
    pay = staff1.CalculatePay(1000, 400);
    Console.WriteLine("Pay = {0}", pay);
    Console.WriteLine("Hello World");
    Console.Read();

}

////////Summarising :
// Here, we use the "first constructor" (with one parameter) to create our 'staff1' object.
/* Once we create the object, we can use the dot operator(.) after the objects name to access
   any 'field', 'property' or method in the "Staff class".

 * Note that we need to use the dot operator(.) as we are trting to access members of the "Staff class" from
   the 'Program class'.

The dot operator is neccessary if we want to access a field, property or method from another class. 
*/

// If you are accessing members of the same class, you do not need to use the dot operator(.)
// An example is when we called the 'PrintMessage()' method from the "CalculatePay()" method earlier.
// We did not use the dot operator as both methods are from the same 'class'.

/* After creating our "staff1" object, the next line shows how we can use the public "EmployeeType" property
   to assign a value to the 'hWorked' field.
*/
staff1.HoursWorked = 160;

// if we try to access the "Private field" 'hWorked' directly by writing:
staff1.HoursWorked = 160;
// We will get an error as 'hWorked' is a private field and is therefore only accessible within the 'Staff class'.

// To call the "CalculatePay()" method, we write :
staff1.CalculatePay(1000, 400);

/*
   In this example, as we have the number 1000 and 400 inside the parenthesis, we are using the second
   "CalculatePay()" mehtod.

We are passing in the values 1000 and 400 to the parameters "bonus" and "allowance" respectively.
*/
// The values that we passed in are known as 'arguments'.
// The program then uses that method to calculate the 'pay' and return the answer.
// This answer is asssigned to the variable 'pay'.

// Finally, we use the 'Console.WriteLine()' method to display the value of 'pay' on the screen.

// If you run the code above, you'll get :

   Peter
   ------------------------------------------
   Calculate Pay...
   Pay = 6200

// Play around with the code to get a better understanding of how classes work.

    Staff staff2 = new Staff("Jane", "Lee");
    staff2.HoursWorked = 160;
    pay = staff2.CalcualtePay();
    Console.WriteLine("Pay = {0}", pay);

// If you run the code above you'll get :

Jane Lee
------------------------------------
Calculating Pay...
Pay = 4800

// Finally let's create a third object to demonstrate how data validation works when we use 'properties'
// Add the following lines of code :
staff staff3= new Staff("Carol");
staff3.HoursWorked = -10;
pay = staff3.CalculatePay();
Console.WriteLine("Pay = {0}", pay);

// Here we tried to set the "HoursWorked" property to -10, which is an "invalid value".
// The setter of that 'property' sets the value to zero instead.
// Run the code :

Carol
----------------------------
Calculating Pay...
Pay= 0




/////////////////////////////////Complete Program :
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args) { 

        
            int pay;

            Staff staff1 = new Staff("Peter");                        // staff1 is the first object
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);
            Console.WriteLine("Hello World");
            Console.Read();


            Staff staff2 = new Staff("Jane", "Lee");                 // staff2 is the second object
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
             
            Staff staff3 = new Staff("Carol");                      // staff3 is the third object
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
        }
    }


    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        public int HoursWorked                         // <<<<<< Here we declared our "Property".
        {
            get
            {
                return hWorked;
            }
            private set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of staff = " + nameofStaff + ", hourlyRate = " + hourlyRate + " , hWorked = " + hWorked;
        }

        public Staff(string firstName, string lastName)
        {
            nameofStaff = firstName + "" + lastName;
            Console.WriteLine("\n" + nameofStaff);
            Console.WriteLine("------------------------------");
        }
    }
}

//----------------------------------------------------------------------------------------------
//////////////////Static Keyword///////////// >>>>>>STATIC KEYWORD//////////////////////
// We've covered some pretty complicated concepts in this chapter.
// Practice with due diligence because of these concepts, learn to understand them effectively.
// Fully understand them.

/*
   In this section, we'll look at another keyword that is sometimes used when we
   declare 'classes' or 'class members'(i.e. "methods", "fields", "properties", "constructors" etc..).

   previously we looked at how we can use the 'Staff' class to create our "staff1",
   "staff2" amd "staff3" objects.
 */
/* However, there are some "classes" or "class members" that can be accessed without 
   the need to create any objects */
// These are known as "Static Classes" or "Class Members" and are declared using the 'Static' keyword.
// Follow the folllowing class :

class MyClass
{
    //Non Static Members
    public string message = "Hello World";                        // One-non static field "message".
    public string Name { get; set; }                              // One-non static property "Name".
    public void DisplayName()                                     // One-non static method "DisplayName()"
    {
        Console.WriteLine("Name = {0}", Name);
    }

    // Static Members
    public static string greetings = "Good Morning";              // One static field "greetings"
    public static int Age { get; set; }                            // One static property "Age"
    public static void DisplayAge()                               // One static method "DisplayAge()"
    {
        Console.WriteLine("Age = {0}", Age);
    }
}

/*
   MyClass contains one non 'static' field "message", one non static property "Name"
   and non-static method "DisplayName()"
 */

// It also contains one static field "greetings", one static property

// To access the "non-static members" of MyClass from another class, we need to instantiate an object as before:

MyClass classA = new MyClass();

Console.WriteLine(classA.message);
classA.Name = "Jamie";
classA.DisplayName();

// However, to access the "static" members, we do not need to create any object.
// We simply use the "Class name" to access them as shown below:

Console.WriteLine(MyClass.greetings);
MyClass.Age = 39;
MyClass.DisplayAge();

// If you run the code above, you will get this output:
Hello World
Name
Good Morning
Age = 39

// -------------------------------------------------------------------------------------------------------------------------
// In addition to having 'static methods, 'fields', 'properties' and 'constructors', we can also have "static Classes".
// A "STATIC CLASS" can only contain "static members". EXAMPLE :

    static class MyStaticClass
{
    public static int a = 0;
    public static int B { get; set; }
}

// Some of the pre-written 'classes' in C# are declared as "static classes".
// An example is the "console class".
// We don't need to create a "console object" when using methods from the "Console class". We simply write :
Console.WriteLine("Hello World");

//-----------------------------------------------------------------------------------------------------------------
//////Advanced Method Concepts///////////////------ADVANCED METHOD CONCEPTS////////////////////////////////////
/* Now that we familiar with 'classes', lets move on to more 'advanced concepts' in regards to the "declaration" 
   and use of "methods" in a class.

These concepts are more complex and may require more than one readingto fully understand them.
*/

//////////////Using Arrays and Lists///////////////////////USING ARRAYS AND LISTS//////////////////////////
// Previously, we learned to use 'basic data types' like "int" and "float" as parameters to a method.
// In addition to usng 'basic data types', we can also use "Arrays" and "Lists".

// To use an "array" as a parameter, we add a "square bracket"[ ] after the parameter's data type in the method declaration.
// EXAMPLE Below :

public void printFirstElement(int[] a)
{
    Console.WriteLine("The first element is {0}.\n", a[0]);
}

// To call this method, we need to declare an array and pass it in as as an argument to the method
int[] myArray = { 1, 2, 3, 4, 5 };
printFirstElement(myArray);



// The next example shows how we can use a list as a parameter  :
public void printFirstElement(List<int> a)
{
    Console.WriteLine("The first list element is {0}.\n", a[0]);
}

// To call the method, we need to declare a list and pass it in as an argument to the method :

List<int> myList = new List<int> { 1, 2, 3 };
printFirstListElement(myList);

/* In addition to using arrays or lists as parameters to a method, we can also return an array or list
   from a method.

   To return an array from a method, we add a square bracket[ ] after the return type in the method declaration:
*/

public int[] ReturnUserInput()
{
    int[] a = new int[3];

    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("Enter an integer: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Integer added to array.\n");
    }
    return a;
}

// To use this method, we need to declare an array and assign the methods result to it :
int[] myArray2 = ReturnUserInputList();

// To return a list from a method, we use the List<> keyword as the return type in the method declaration. 
// Exampe ;
public List<int> ReturnUserInputList()
{
    List<int> a = new List<int> < int >();
    int input;

    for (int i = 0; i<3;i++)
    {
        Console.Write("Enter an integer: ");
        input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Integer added to list.\n");
        a.Add(input);
    }
    return a;
}

// To use this method, we need to declare a list and assign the method's result to it:
List<int> myList2 = ReturnUserInputList();

//-----------------------------------------------------------------------------------------
////////Using Params Keyword////////////////////--USING PARAMS KEYWORDS/////////////////////
// Next, let's expose the 'params' keyword.
// The 'params' keyword is useful when we do not know the 'number of arguments' a method has.
/*
  For example, we may have a method that prints a series of names, but we do not know how 
  many names there are in advance.

  In cases like this, we can use or array as the parameter and add the 'params' keyword
  in front of it.
 */
// EXAMPLE :
public void PrintNames (params string[] names)
{
    for (int i= 0, i < names.Length; i++)
    {
        Console.Write(names[i] + " ");
    }
    Console.WriteLine();
}

// To use this method, we can pass in any "number of strings as arguments".

// EXAMPLE:-/////////////////

PrintNames("Peter");
PrintNames("Yvonne", "Jamie");
PrintNames("Abigail", "Betty", "Carol", "David");

//////  OUTPut:////////

   Peter
   Yvonne Jamie
   Abigail Betty Carol David
 
/* Note that no additional parameters are permitted after the "params" keyword
   in a method declaration, and only one 'params' keyword is permitted in a 
   method declaration.
 */
// Hence, the following method declaration is fine:-
public void printNames2 (int a, double b, params int[] ages)

    // But the following declarations are not :

public void printNames3 (int a, params string[] names, double b)        // printNames3 is not allowed because 'double b' comes after "params string[] names"

public void printNames4 (params string [] names, params int [] ages)    // printNames4 is not allowed because there are two "params" keyword.

// printNames3 is not allowed because 'double b' comes after "params string[] names".
// printNames4 is not allowed because there are two "params" keyword.

//--------------------------------------------------------------------------------------------------------------------

//////>>>Passing Value Type vs Reference Type Parameters//////////PASSING VALUE TYPE VS REFERENCE TYPE////////////////
// Now theres an understanding of how 'classes' and 'methods' work.
// Before we end this chapter, let us revisit the concept of "Value Data Type" and "Reference Data Types".
// In chapter 4 we learnt that are two main 'categories' of 'data types' in C#- Value Types and Reference Types.

/*
   There is a difference when you pass in a "value type variable" to a method vs "reference type variable".
*/

    /* When you pass in a value type variable, any change made to the value of that varriable is only
       valid within the method itself.
    
       Once the program exits the method, the change is no longer valid.
 */

/*
   On the other hand, if you pass in a reference type variable, any change made to
   the variable is valid even after the method ends.
 */
// Consider the class the below :

class MethodDemo
{
    public void PassByValue(int a)
    {
        a = 10;
        Console.WriteLine("a inside method = {0}", a);
    }

    public void PassByReference(int [] b)
    {
        b[0] = 5;
        Console.WriteLine("b[0] inside method = {0}", b[0]);
    }
}

// Within the class, we have two "methods".
// The "first method" accepts a value type 'variable' and tries to change the 'value' of that "variable".
// It then prints the value of the variable.

/* The "second method" accepts an array (reference type) and tries to change the value of the first
   element in the array.

   It then prints the value of that element.
*/
// In our "Main()" program, suppose we have the following lines of code :--

int a = 2;
int[] b = { 1, 2, 3 };
MethodDemo obj = new MethodDemo();

Console.WriteLine("a before = {0}", a);
obj.PassByValue(a);
Console.WriteLine("a after = {0}", a);

Console.WriteLine("\n\n");

Console.WriteLine("b[0] before = {0}", b[0]);
obj.PassByReference(b);
Console.WriteLine("b[0] after =  {0}", b[0]);


  a before = 2
  a inside method = 10
  a after = 2

  b[0] before = 1
  b[0] inside method = 5
  b[0] after = 5
 
/*
   The value of "a" stays the same before and after the method call, the change is
   only valid inside the method itself.
 */

// On the other hand, the value of "b[0]" changes after the ,method call.
/*
   Be aware of this difference when you pass in a "value type variable" to a 
   method (e.g. "int", "float" etc..) vs a "Reference Type Variable" (such as an "Array" or "List").
 */
