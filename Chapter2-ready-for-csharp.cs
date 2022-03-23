//  "Chapter 2" : Get ready for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // A sample to display the words HelloWorld.



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Read();
        }
    }
}


//////////////////////////////////////////////////////////////////////////////////////

// "Basic Structure Of A Structure" :

/* The "using" system statements are known as directives.
   These directives tell our compiler that we're using certain namespaces.
   EXAMPLE : using System; our program uses the System namespace.
*/

/* A "Namespace" is simply a grouping of related code elements.
   These elements include 'Classes','interfaces' , 'enums' , 'structs'.
   C# has alot of pre-written code organised into different namespaces.
   
  The "System" Namespace contains code for methods that allow us to interact with our users.
We use 2 of these methods in our programs : WriteLine(); and Read();
*/

//We can even declare our own namespacespaces.
// The advantage to declaring our own namespace is that we prevent naming conflicts.
// Two or more "code elements" can have the same name as long they belong to "different namespaces"
//EXAMPLE: we have 2 different "namespaces" but have the same "class" called "MyClass".

namespace First
{

    class MyClass
    {

    }
}
namespace Second
{

    class MyClass
    {

    }
}



//Within the "HelloWorld namespace" 'Program Class' we have the Main() method.

// THE MAIN () METHOD.
/*
   The "Main () Method" is the entry point of all C# console applications.
   When a console application is started, the "Main() Method" is the first method to be called.
 */

// Without Main Method you cannot run console programs.

/* Notice the words "" String[] args " inside the parenthesis of our Main() Method.
   This means that the Main() Method can take in a "Array of strings" as input.

CONSOLE.WRITELINE(); displays the line written inside the parentheses
CONSOLE.READ(); waits for a key press from the user before closing the window.
  */