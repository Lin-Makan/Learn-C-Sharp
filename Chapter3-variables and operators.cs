
/* Variables are names given to data or datatype that we need to store 
   and manipulate in our programs
 */
//    int userAge;
// Up here we have a declaration.

/* After you declare the variable "userAge" your program allocates a certain area of your computers storage space
  to store this "data" 

   You can then access and modify this data by referencing its name, "userAge'
 */

// 'DATA TYPES IN C#"

//INT- int 
/* int stands for integer.
 * numbers with no decimal or fractional parts
    These hold numbers from:
   -2, 147, 483, 648, to 2, 147, 483, 647. 
   15, 507, -908, 6150 etc..
 
 */

//BYTE- byte
/* byte also refers to integral numbers but they hold a range from "0 to 255"
   Most of the time we use "int" instead "byte" for integral numbers.
   BUT if you programming something with limited space, you should byte provided that the range is from 0 to 255
 */

//FLOAT-float
/* refers to floating point numbers, which are numbers with decimal places
 * such as : 12.43, 5.2, and -9.12.
 * "float" can store numbers from -3.4 * 10 to the power 38.
 * It uses 8 bytes of storage and has a precision of approxiamately 7 digits.
 * This means that if we have a number of "1.23456789" it will round of to "1.234567" (7 digits) 
 */

//DOUBLE-double
/* double is also a floating point number, but can store a much wider range of numbers. 
   It can store numbers from (+/-)5.0 * 10 to the power of -34 to (+/-)1.7 * 10 to the power of 308 
And it has a precision of about "15 to 16 digits" 

doubleis the default "floating point data type" in C#.
this means any number like 2.34 is treated as a "double".
*/

// DECIMAL=decimal
/* decimal stores a decimal number but has a double smaller range than "float" and "float"
 
 */

/////////////////////// NAMING A VARIABLE//////////////////////////////////////////////
/* A variable can only contain letters, numbers and _Underscores.
   However the first character cannot be a number. like 2userName
   But you can name variable like userName2

if a variable is double or triple words, you dont start with a high camel casing
"houseOnFire" or "lowIncome".
 
 */

///////////////////////INITIALIZING A VARIABLE///////////////////////////////////////////
//Everytime you declare a new variable, you must give it an inital value (Assign) a value.
//Example 1

byte userAge = 20;
int numberOfEmployers = s10;

byte userAge2 = 20.0;

// The next examples show you how to initialize "double" ,"float" and "decimal variables" with 'integral values'.
// Example 2

double intNumberOfHours = 5120;
float intHourlyRate = 60;
decimal intIncome = 25399;

//The next examples show you how to initalize "double" , "float"and "decimal" variables with 'non-integers'.
// Example 3

double numberOfHours = 5120.5;
float hourlyRate = 60.5f;
decimal income = 25399.65m;

/*
   As mentioned before, the default datatype for a number with decimal places is "double". 
   Hence, when you initalize "hourlyRate you need to add 'f' as a suffix after 60.5 to explicitly
   tell the compiler that to change 60.5 into a float.

Similarly, when you intilaize "income" , you need to add "m" as suffix to change 25399.65 into a decimal
datatype.
 */

// Example 4
// A 'Char' data type can only contain a single character.
//When we assign a "char variable" , we need to enclose that character in single qoutes

char grade = 'A';

//Example 5
//A "bool" variable can only be true or false
////You can initialize a "boolean"
///
bool promote = true;

//EXample 6
//You can initialize a number of individual variables inj one statement as long as they the same data type.
byte level = 2, userExperience = 5;
// seperated by a comma, ended the statement with a semi-colon.

//INITIALIZING A VARIABLE IN A SEPERATE STATEMENT

byte year;    //declare the variable
year = 20;     // intialize it

//////////////////////////////////The Assignment Sign////////////////////
//   the equal sign>>>>>    "="
// We assignning a value on the right side to the variable onn the left.

x = 5;
y = 10;
x = y;
// its okay to assign the value of a variable to another variable.
// x is now "10". 
y = x;
// this up here says y is now "5".

//////////////////////////////BASIC OPERATORS/////////////////////////////////////
// We can perform usual mathematical operations on variables.

// Basic operators in C# are :  + ,- ,* ,/ ,%
/* + Addition
   - Subtraction
   * Multiplication
   / Division
   % Modulus
 
 */

/* Addition */   x + y = 9;
/* Substraction */   x - y = 5;
/* Multiplication */  x * y = 14;
/* Division */ x / y = 3;    // rounds down the number to the nearest integer.
/* Modulus */  x % y = 1;   //gives the remainder when 7 is divided by 2

// If both values of variables are integers, then if division is used, you will get an integer
// if both values of variables are non-decimal then you will get a non-decimal answer.
7 / 2 = 3;
7.0 / 2 = 3.5;
7 / 2.0 = 3.5;
7.0 / 2.0 = 3.5;

// In any case if types are of different operands, then at least one is non-integer etc...

///////////////////MORE ASSignement OPerators///////////////////////////////////////////////
//  MORE ASsignment OPerators >>>>>>>> +=, -=, and *=

//SUPPOSE WE have variable 'x' and the value 10 to 'x'.And we want to increment x by 2:
x = x + 2;
//The program will firstevaluate the expression on the right (x+2) and assign the answer to the left.

/*Instead of writing*/
x = x + 2;
// We can instead write
x += 2;
//We combining two operators which are "+ and =" .
/*iterator simply means*/  x = x + 2;

//Similarly for subtraction we can say, 
x = x - 2;
//or we can say: 
x -= 2;

//The ++ operator is used to "increment" the value by "one" 
int = 2;
x++;
// Now the "value" of x becomes "3".
//Theres no need to use the equal sign when you use the ++ operator.


/*The statement*/ x++; /*is equivalent to*/  x = x + 1 ;

//The ++ operator may be place in front or behind the variable
// this affects the order of tasks perfromed.

//EXAMPLE:
//Suppose we have an integer named "counter".
console.WriteLine(counter++);
//The program first prints the original value of counter before incrementing counter by 1.

//In other words, it executes tasks in this order:
counter = counter + 1;
console.WriteLine(counter);

// The -- operator "decreases" the value by '1'.

//////TYPE CASting in C#//////////////////
// sometimes within our program, its necessary to convert from one data type to another
// such as converting a "double" into a "int".
// This is known as "type casting".


/*To conveert one numeric data type to another , we need to add (new data type) in front of the
 data that we want to convert*/

// Example, we can cast a "non-integer" into an "integer" like this:

int x = (int)20.9;
//we can cast 20.9 into an integer, the resulting value is 20, not 21
//The decimal portion is truncated after the conversion.

//We can also cast a "double" into a "float" or a "decimal".
//Remember that all "non-integers" are treated as "double" by default in c# ??

/*If we want to assign a number like 20.9 to a float or decimal, we need to add the "f" and "m"
  suffixes respectivley.
*/
// Another way to do this is ;
float num1 = (float)20.9;
decimal num2 = (decimal)20.9;

//The values of num1 and num2 will both be "20.9"
//In addition to casting between numeric values, we can do other type castings.
////We'll do that later on.



 


