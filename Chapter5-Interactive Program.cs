// We've covered the basics of "Variables" and "Data Types".
// Now let's create a program that makes use of them.

/*
    Here we'll learn:
*How to "Accept Input from users"
*"Store" the data in 'variable'.
*And "Display Messages To Our Users"
 */

/////////////--Displaying Messages To Users--////////////////////
/*To display messages to our users, we use the "Write()" or "WriteLine()" Method in C# which is
  available in the "System" namespace.

 *The difference between "Write()" and "WriteLine()" is that WriteLine() moves the cursor down
  after displaying the message, whilst Write() does not.
*/

using System;

Console.WriteLine("Hello ");
Console.WriteLine("How are you?");
// we'll get :
/* Hello
   How are you?
 */

Console.Write("Hello ");
Console.Write("How are you?");

// we'll get :
              // Hello How are you?

//Notice that we added the word "Console" in front of the "method name" whenever we call "Write" or "WriteLine" method
// This is because both methods are "Static Methods" of the Console class.
// We'll talk more on "static methods".

// If you find trouble adding the word 'console" when you use these two methods,
// add the directive : using System static.Console;     to the start of your program
using System static.Console;

// If you do that, you can simply say :
WriteLine("Hello World");

// instead of :
Console.WriteLine("Hello World");

/* Whenever you use any of the "static methods" in the "Console Class".
*/

/////EXAMPLE 1/////
Console.WriteLine("Hello, how are you?");
// output : Hello, how are you?

/////EXAMPLE 2/////
/* To display the value of a variable, wepass in the the variable name
   as an argument. For instance, suppose we have :
*/
int userAge = 30;
// we display the value of "userAge" by writing:
Console.WriteLine(userAge);
// Output is :
30
// Note that we do not enclose it with double qoutas :
// If we write :
Console.WriteLine("userAge");
// We'll get :
// "userAge" as the 'output' itself.

///////EXAMPLE 3///////////////////////
/* To combine two or more strings and display them, 
   we use the "Concatenation (+) sign" mentioned earlier.
// For instance: 
*/
Console.WriteLine("Hello, " + " how are you?" + " I love C#.");

//We'll get :
// Hello, how are you? I love C#.

/////////////EXAMPLE 4///////////////////////////////////
// We can also use the "concatenation sign" to combine a string and a variable ;

int results = 79;
// The Statement :
Console.WriteLine("You scored " + results + "marks for your test.");
// Output ;
// You scored 79 marks for your test

/////////////////EXAMPLE 5 /////////////////////////
//  We can also use placeholders on top of strings and variables
// Suppose we have ;
int results = 79;
// If we write ;
Console.WriteLine("{ 0 }! You scored { 1 } marks for your test.", "Good morning", results);

// The Output will be :

// Good morning ! You scored 79 marks for your test.
// In this example, we passed three arguments in the WriteLine() method, seperated by commas.

// * The THREE ARGuments Are :
/*
   1) "{ 0 }! You scored { 1 } marks for your test."
   2) "Good morning"
   3) results.
 */

/* The first is the string that will be displayed.
 * Within the string, the curly braces act as placeholders and will be replaced by the arguments
   that follow.
 */

* { 0 }   /*Is a placeholder for the next argument, which is the string*/ "Good morning"  // In this case.

* { 1 }  //is a placeholder for the variable 'results'.
         // Therefore, the output is :
         Good morning! You scored 79 marks for your test.
// If you write :

Console.WriteLine("{ 1 }! You scored { 0 } marks for your test.", "Good morning", results);
// The output will be :

79! You scored Good morning marks for your test.

/* Of course, such a statement makes no sense.
 * However, it demonstrates how placeholders are replaced by the corresponding arguments.
 * We can specify how we want "numeric values" to be displayed when using placeholders.
   This is done using a "format specifier", such as the "C" and "F" 'specifier'.
 * The "F" specifier specifies the number of decimal places a number should be displayed with.
*/
 // If we write :
 Console.WriteLine("The number is {0:F3}." ,123.45678);

// Output is :
___________________________
The number is 123.457
_________________________

// * The F3 specifier rounds the number "123.45678" off to "123.457".
// * Note that there should not be any space before the specifier.
// * In other words, it has to be {0:F3} and not {0: F3}.

/* The "C" specifier is for formatting currencies, it adds the
   "S" symbol in front of the number and displays the number with
   2 decimal places.
In addition, it seperates every thousand with a comma.
*/
// If we write :
Console.WriteLine("Deposit = {0:0}. Account balance= {1.0}." , 2125, 12345.678);

// The output is :
 11     // will be displayed on the screen.

//////////EScape SEquences/////////////////
// 
/*
  Sometimes in our programs, we may need to print some special
  "Unpredictable" characters such as a "tab" or a "newline".
 */

// In this case, you need to use the \(backslash) character to escape characters.
// For instance, to print a tab, we type the backslash character before the letter 't' like this
  \t

// without the "\ character", the letter "t" will be printed. with it,  a tab is printed.
// Hence if you write ;
Console.WriteLine("Hello\tWorld");

// You'll get :  Hello World

// Other Common uses of the BackSlash Character include:-

// To Print a newline "(\n)".
// EXAMPLE
Console.WriteLine("Hello \nWorld");

// Output is : 
/* 
   Hello
   World
 */
// To Print the BackSlash Charaacter itself : (\\).
// Example :
Console.WriteLine("\\");

//Output is :
\

// To Print double qoutes (\") so that the double qoute does not end the 'string".
// Example ;
Console.WriteLine("I am 5'9\" tall");

// Output ;
I am 5'9" tall 
      

///////////////////////////ACCepting USer Input///////////////////////
// Now that we know how to display messages to our users.
// let us look at how we can "accept" input from them.

 // To accept user input, we can either use the "Read()" or "ReadLine()" method.

    /* Read() reads the next character from standard input, whilst, 
     * ReadLine() reads a line of characters.
     * 
     * "Standard input" refers to the standard device that users use to 
        enter date, which is usually the keyboard.
     */

// Below we have examples on how to use the ReadLine() method to read input from users.
// The Read() method works the same way.

string userInput = Console.ReadLine();

/*
  Both the Read() and ReadLine() methods read in user input as a string.
  Hence, the illustration above, we assign the result of Console.ReadLine() to a string
  variable called "userInput".

 */
// We can then say ;
Console.WriteLine(userInput);

// To print out the "input" that the "user entered".

//////////////COnverting A String To A Number:-////////////////
/* Sometimes its necessary to convert the input that users entered into
   a "numeric data type" so that you can "perform "calculations" on it.
*/
// C# has a number of methods to do the conversion.
/* The methods that we use are found in the "Convert Class", which
   is also grouped under the "System namespace".
*/

/* To convert a string to integer, we use the*/ "ToInt32()" method.
    // For Instance ;

string userInput = Console.ReadLine();

// And the user keys in "20", userInput will be equal to "20"
// (Which is a string and not an integer because of the double qoutes).

// We can then use ;

int newUserInput = Convert.ToInt32(userInput);

// To convert the string to the "integer 20" and "assign" it to an 'int" variable.

/* 
   Besides converting a string to an integer, we can also convert a 
   string to a "decimal" , "float" or "double" using the "ToDecimal()" ToSingle() and ToDouble() methods respectively.
 */
'decimal' , 'float' or 'double' using the "ToDecimal()", ToSingle() and ToDouble() methods.

    //////////////////PUTTING IT ALL TOGETHER///////////////////////////
    // Let us make a complete program with everything we've learnt.

string userName = "";
int userAge = 0;
int currentYear = 0;

Console.Write("Please enter your name: ");
userName = Console.ReadLine();
Console.Write("Please enter your age: ");
userAge = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the current year: ");
currentYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}."
                  , userName, userAge, currentYear - userAge);

// Run the program and enter the following information :

Please enter your name: Kuhle
Please enter your age: 27
Please enter the current year: 2022

// The program should give you the following output;

    Hello World! My name is Kuhle and I am 27 years old. I was born 1994.

// Points to mention about the program :
/* Line 267 shows an example of how we can use two methods within the same statement.
 */
//When we write :
                  userAge = Convert.ToInt32(console.Readline());
// the "Console.ReadLine() method" is executed first as it is within a pair of parentheses().

// This is similar to how operations within parentheses hace a higher order of precedence.
// when we evaluate a mathematical expression.

// Example : When we evaluate 3*(5+9), we have to add "5 to 9" first before mulitplying answer to "3".
// i.e 3*14

// After Console.ReadLine() is executed, the value entered by the user is converted to an integer using :
Convert.ToInt23()

// Suppose the user entered '39'.
Convert.ToInt23(Console, ReadLine());

// Now becomes
Convert.ToInt23("39");
// The result of this is the integer "39".
// This integer is nthen assigned to variable "userAge"

// Last thing to point out in this program is the last line.

Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}."
                  , userName, userAge, currentYear - userAge);
// Notice that the last argument (currentYear - userAge) involves a Mathematical Operation??
// Its allowed in C# .
// WriteLine() will perform the substraction and display the result of the calculation.