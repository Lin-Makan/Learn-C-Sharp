// CHAPTER 9 : ENUM & STRUCT
// In chapter 3 and 4, we looked at some built-in data types provided by C#.
// These include value types like 'int', 'float', and 'double' and reference data types like 'array', 'strings' and 'lists'.
// In addition to that, we looked at how we can write our own 'classes' in chapter 7 & 8.
/* A 'class' can be considered to be an "advanced user-defined data type" that groups 
   a set of related "fields", "properties" and "methods" into a logical unit.
*/
// This chapter, we'll look at two more user-defined data types in C# - 'enum' and 'struct'.

//////Enum///////>>>>ENUM

/*
  An "Enum"(which stands for enumerated type) is a special data type in C# that allows
  programmers to provide meaningful names for a set of 'integral constants'. 
*/
// To declare an "enum", we use the "enum" keyword followed by the name of the "enum".
// The members of the 'enum' are enclosed in a set of 'curly braces' and seperated by commas.
// An example is shown below:

enum DaysOfWeek
{
    Sun, Mon, Tues, Wed, Thurs, Fri, Sat
}

// Note that we do not put a semi-colon at the end of the last member.

// After declaring the "DaysOfWeek" enum, we can declare and initialize a DaysOfWeek variable like this:

DaysOfWeek myDays = DaysOfWeek.Mon;

//The name of the variable is myDays. If we write :
Console.WriteLine(myDays);

// We'll get 
Mon

// By default, each member in the enum is assigned an integer value, starting from zero.
// That is, in our example, "Sun is assigned a value of 0", "Mon is 1", "Tues is 2" and so on.....

/* As members of an enum are essentially integers, we can cast a 'DaysOfWeek' variable into
   an 'int' and vice versa. For instance,
*/
Console.WriteLine((int) myDays);

// gives us the 'integer 1' while :
Console.WriteLine((DaysOfWeek)1);
// gives us 'Mon'.
// If you want to assign a different set of integers to your 'enum' members, you can do the following :
enum DaysOfWeekTwo
{
    Sun = 5, Mon = 10, Tues, Wed, Thurs, Fri, Sat
}

/* Now, "Sun" is assigned a "value of 5" and "Mon is assigned 10".
   As we did not assign values for "Tues to Sat", consecutive numbers
   after 10 will be assigned to them.
*/
// That is Tues = 11, Wed=12 and so on.
// All enums are stored internally as integers (int).
/* If you want to change the underlying data type from int to another data,
   you add a "colon after the enum name" followed by the desired'data type'.
*/
// Any integer data type is allowed except for "char".
// An example is :

enum DaysOfWeekThree : byte
{
    Sun, Mon, Tues, Wed, Thurs, Fri, Sat
}

// Of course, if you use a "byte" data type, you cannot do something like :
enum DaysOfWeekFour : byte
{
    Sun = 300, Mon, Tues, Wed, Thurs, Fri, Sat
}
// as the range of 'byte' is from "0 to 255".
// There are 2 main reasons for using 'enums' :

// The first is to improve the readability of your code. The Statement :
myDays = DaysOfWeek.Mon;
// is more self-explantory than the statement :
myDays = 1;

// The second reason is to restrict the values that a variable can take.
/*
  If we have a variable that stores the 'days' of a week, we may accidently
  assign the value 10 to it.

This can be prevented when we use an 'enum' as we can only assign the
pre-defined members of the enum to the variable.
*/

////Struct//////>>>STRUCT/////////
// Now, let's look at the 'struct' data type.
// A "Struct" is similar to a class in many aspects.
/* Like classes, they contain elements like "properties", "constructors", 
   "methods" and "Fields" and allow you to group related members into
   a single package so that you can manipulate them a group.
*/

// To declare a 'struct', you use the 'struct' keyword. An example :
struct MyStruct
{
    // Fields
    private int x, y;
    private AnotherClass myClass;
    private Days myDays;

    // Constructor
    public MyStruct(int a, int b, int c)
    {
        myClass = new AnotherClass();
        myClass.number = a;
        x = b;
        y = c;
        myDays = DaysOfWeek.Mon;
    }

    // Method
    public void PrintStatetment()
    {
        Console.WriteLine("x = {0}, y = {1}, myDays = {2}", x, y, myDays);
    }
}

class AnotherClass
{
    public int number;
}

enum Days { Mon, Tues, Wed }

// The 'struct' is declared from "lines 102-124".
// On line "105", we declared two 'private int fields' for the "struct".
// On line "106", we declared another "private field" called "myClass".
// This 'field' is an "instance" of the class 'AnotherClass'.
// On line "107", we declared an 'enum' variable "myDays".
/*
   The two 'fields' ("myClass and myDays") are specially included in this 
   example to demonstrate how we can include a 'class instance' and an 'enum'
   variable as the "fields" of a 'struct'.
*/
/* Structs (and classes) can contain "enum" variables and "instances" of other
   "structs" and "classes" as 'fields'.
*/

/*
   After declaring the 'fields', we declared the "constructor" for the 'struct'
   (lines 110-117), followed by a 'method' to print the values of 'x, y and myDays'
   on lines (120-123).
 */

/*
   After declaring the "struct", we declared the 'class' "AnotherClass" on "lines
   126-129" and the enum "Days" on "line 131".
 */
// In this example,we declared the 'class' and 'enum' outside the 'struct' "myStruct".
// However, it is possible for us to declare the 'enum' or 'class' inside the "struct" itself.
// An 'enum', 'struct' or 'class' can be nested inside another 'struct' or 'class'.

// We'll look at an example of an 'enum' declared inside a 'class' when we work through the project in the end.

// To use the "struct" above, we can add the following code to our :
                                                                     Main() method:
MyStruct example = new MyStruct(2, 3, 5);
example.PrintStatetment();

// If we run the code above, we'll get :
x = 3, y = 5, myDays = Mon

// There are two main differences between a "struct" and a "class".
// firstly, the "struct" 'data type' does not support 'inheritance'.
// Hence you cannot derive one "struct" from another.
// However, a 'struct' can implement an 'interface'.
// The way to do it is identical to how it is done with 'classes'. Refer to "chapter 8" for for more information.

/*
  The second difference between "structs" and "classes" is that "structs" are 'values types'
  ,while "classes" are 'reference types'.
*/

    //// Complete Program :
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void main (string[]args)
        {
            MyStruct example = new MyStruct(2, 3, 5);
            example.PrintStatetment();
        }

        enum DaysOfWeek
        {
            Sun, Mon, Tues, Wed, Thurs, Fri, Sat
        }
           DaysOfWeek myDays = DaysOfWeek.Mon;
           Console.WriteLine(myDays);
           Console.WriteLine((int) myDays);
           Console.WriteLine((DaysOfWeek)1);

        enum DaysOfWeekTwo
        {
            Sun = 5, Mon = 10, Tues, Wed, Thurs, Fri, Sat
        }

        enum DaysOfWeekThree : byte
        {
            Sun, Mon, Tues, Wed, Thurs, Fri, Sat
        }

        enum DaysOfWeekFour : byte
        {
            Sun = 300, Mon, Tues, Wed, Thurs, Fri, Sat
        }

        struct MyStruct
        {
            private int x, y;
            private AnotherClass myClass;
            private Days myDays;
        }

        public MyStruct(int a, int b, int c)
        {
            myClass = new AnotherClass();
            myClass.number = a;
            x = b;
            y = c;
            myDays = DaysOfWeek.Mon;
        }

        public void PrintStatetment()
        {
            Console.WriteLine("x = {0}, y = {1}, myDays = {2}", x, y, myDays);
        }

        class AnotherClass
        {
            public int number;
        }

        enum Days { Mon, Tues, Wed }





    // Do More research for List of differences between a "struct" and a 'class'.