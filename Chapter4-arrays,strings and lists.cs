// We have three Advance Data Types: "Arrays" , "Strings" and "Lists"
//We'll also discuss the difference between a 'data type' and a 'reference type'.

/////////////////////// ARRAY  ////////////////////////
// an Array is a collection of data normally related to each other.
// If we want to store the age of 5 users, instead of userAge1 userAge2 userAge3 userAge4
// Instead we can store them in an Array and say :

int[] userAge = { 21, 22, 23, 24, 25 };
// int statesb that the variable stores "int values".
// [] indicates that the variable is an array instead of a normal variable.
// userAge is the name of the Array.
// { 21, 22, 23, 24, 25 }; are the five integers that the Array stores. 

// We can also declare an "Array" first and then initialize it later on.
// To do that we need to use the new operator/keyword.

int[] userAge = new int[5];
userAge = new[] { 21, 22, 23, 24, 25 };

//The first statemnet declares and creates an array for storing 5 integers.
//The second statement intializes the array.
//Individual values in the arrray are sccessible by their indexes, and indexes start with 0.
// first value of the array starts with index "0", the next one is index "1". etc...

//if we try:
Console.WriteLine(userAge[0]);
// Console Answer is : "21"

//if we try:
userAge[2] = userAge[2] + 20;
// the array becomes { 21, 22, 43, 24, 25 }. That is "20" is added to the "third element".

////////////////ARRAY PROPERTIES AND METHODS/////////////////////////////////////////////
// C# Has alot of useful "properties" and "methods".
// To use a "property" and "method" we have to use the dot (.) operator.
//To use the "property" name, we type the property name after the dot.
//To use the "method" name, we type the method name after the dot, followed by a pair of parentheses.

////Length Property/////////////////////
//The Length property tells us the number of items the array has.

int[] userAge = { 21, 22, 26, 32, 40 };
userAge.Length  /* is equals to "5" as there 5 numbers in the Array */

//////Copy() Method/////////////////////////////
/* The copy() mthod allows you to copy the contents of one array into another array startimg from
   the first element.
*/
// In C#, the copy() method comes in 4 variations.
// If you can figure out how to use one variation, you can easily figure out the rest of the copy() methods.
//All the time using methods, we must use a pair of parentheses after the method name.
// Some methods require certain data for it to work.
// These data are known as arguments.
// We includde these arguments in a pair of parentheses.
//   The Copy() Method requires 3 arguments.
//EXAMPLE

int[] source = { 12, 1, 5, -2, 16, 14 };
int[] dest = { 1, 2, 3, 4 };

//You can copy the first three elements of "source" into "dest" by using the following below:

Array.copy(source, dest, 3);

//The "first argument" is the "array" that provides the "values" to be "copied".
// The "second argument" is the "array" where the values will be "copied into".
// The "last argument" specifies the "number of items to copy".

/*Now our "dest array" becomes: */ { 12 ,1 ,5 ,4 };

//while the "source array" remains inchanged.

///////////Sort() Method////////////////////////////
// The sort() method allows us to sort our arrays.
// It takes in an array as the argument.
// Suppose you have:

int[] numbers = { 12, 1, 5, -2, 16, 14 };

//You can sort this array by writing:

Array.sort(numbers);

// The array will be sorted ascending order. Thus numbers becomes:
{ -2 , 1 , 5, 12, 14, 16 };

///////////////// IndexOf() Method//////////////////////////////////
// We use the "IndexOf()" method to determine if a certain value exists in an "array".
//If it exists, the method returns the index of the first occurence of that value,
//If it does not exist, the ,method returns -1.
// For instance, if you have :

int[] numbers = { 10, 30, 44, 21, 51, 21, 61, 24, 14 };

// You can find if the value 21 exists in the array by writing :
Array.IndexOf(numbers, 21);

/* The method "return"s the "index" of the "first value" found, which is "3".   
   in this case since "21" is the "fourth element" in the "array".
*/
// You can then assign the answer to a variable like this :

int ans = Array.IndexOf(numbers, 21);

// The value of ans is thus 3, if you write.
ans = Array.IndexOf(numbers, 100);

//The value of "ans" is '-1' as '100' does not exist in the "numbers array".

//We've covered some of the more commonly used "array methods" here.

///////////////-String-///////////////////////////////////////////////
// A string is a piece of text
//like "HelloWorld".

//To 'declare' and 'initialize' a "string variable", you write :

string message = "HelloWorld";
// Message is the name of the string variable, and "HelloWorld" is the string assigned to it.
// YOU HAVE to enclose the string in double quotes(" ").

//You can also assign an empty string :

string anotherMessage = "";

//We can also combine two or more strings using the concatenate operator sign(+) and assign to a variable.
// For instance ;

string myName = "HelloWorld, " + "my name is Lindokuhle";

// This is the same as :

string myName = "HelloWorld, my name is Lindokuhle";

///////STRING///// PROPERTIES and METHODS/////////////////////////
///
// Like arrays, strings come with a number of properties and methods.

//Length property of a String//
/* The Length property of a string tells us the total number of characters the 
   string contains.
   
   To find the length of the string "HelloWorld", we write
*/
-----------------------------
"Hello World".Length
--------------------------

//We will get the value "11" as "Hello" and "World" both have 5 characters each.
// When you add the space between the words, you get a total length of "11". 

///////////////////Substring() Method ///////////////////////////
// The substring method is used to extract a substring from a longer string.
// It requires two arguments :
// The first argument tells the compiler the "index" of the "starting position" to extract.
// The second argument tells the compiler the length.

// Suppose we declare a "string variable" message and assign the string "Hello World" to it.

string message = "Hello World";

// We can then use "message' to call the "substring()" method below :

string newMessage = message.Substring(2, 5);

/*Substring (2,5) extracts a Substring of 5 characters from 
  index 2(which is the third letter as indexes always start from 0).
*/
// The resulting substring is then assigned to "newMessage".
//  newMessage is thus equal to "llo W".
newMessage = "llo W";

//////--EQuals() Method ////////////////////////
// We can use the "Equals() method" to compare if "two strings" are "identical".

// If we have two strings shown below :

string firstString = "This LindoMakan";
string secondString = "Hello";

firstString.Equals("This is LindoMakan");
// returns true,  while

firstString.Equals(secondString);
//returns false as the two strings (firstString and secondString) are not equal.

///////////////--Split--////////////////////////////////////////////////
// The split() method splits a string into substrings based on an array of user-defined seperators.
/* After splitting the string, the "Split()" method returns an array that contains the 
   resulting substrings.

  *The split()method requires two arguments , an array of strings that act as seperators and
   and the "second argument" to specify whether you want to remove empty strings, from the result.
*/

//Suppose you want split the string into substrings :
"Peter,John;Lindo,Lisa"      // The string

 //

/* 1*/   string[] seperator = { ", ", "; " };
/* 3*/   string names = "Peter, John; Lindo, , David";
/* 2*/   string[] substrings = names.Split(seperator, System.StringSplitOptions.None);

/*On line 1, we first declare an "array" of "two strings" to act as "seperators"
  The first string is a comma followed by a space and then the second is a semi-colon
  followed by a space.
*/

/* On line 2, we 'assign' the 'string' that we want to 'split' to the "names" variable.
 
 * On line 3, we use the "names" variable to call the "split() Method" and assign
   it's result to the "substrings" array.
 */
// The result of the code above is the following array:

{ "Peter", "John", "Lindo", "", "David" };

/*This array contains an empty string as there is a space between the comma after
  "Lindo" and the comma before "David" in the original string.
*/
/* If you want to remove the empty string ffrom the result, 
   you have to change line 3 to :
*/
string[] substrings = names.Split(seperator, System.StringSplitOptions.RemoveEmptyEntries);

// The "substrings" array thus becomes :
{ "Peter", "John","Lindo", "David" };

//We've only covered a number of the more commonly used "string methods".

///////////Lists///////////////////////////////////
//The Last data type in this chapter "Lists".
// A List stores values like an array, but elements can be added or removed at will.


// An array can only hold a fixed number of values. If you declare:-

int[] myArray = new int[10];

/* 'myArray" can only hold 10 values.
   If you write "myArray[10]" which refers to the 11th value since array
   index starts from zero, you will get an error.

If you need greater flexibility in your program, you can use "list".
To declare a list of integers, we write :
*/
List<int> userAgeList = new List<int>();

//userAge list, is the name of the "List".
// "List" is a 'keyword' to indicate that you are 'declaring' a 'list'.
// The "Data Type" is enclosed in "angle brackets<>"

// You can choose to 'initialize' the 'list' at the point of 'declaration'.

List<int> userAgeList = new List<int> { 11, 21, 31, 41 };

//To access individual elements, we use the same notation as before, using the index numbers.
userAgeList[0];       //To access the first element
userAgeList[2];       //To access the third element


///////////////////--List Properties and Methods--/////////////////////////////////
// The "list" 'data type' also comes with a large number of "properties" and "methods".

///////// Add()////////
// You can add members to a list using the Add() method.

userAgeList.Add(51);
userAgeList.Add(61);

// userAgeList now has 6 members : { 11, 21, 31, 41, 51, 61 };

//////COunt Property////////////////

//To find out the number of elements in the list, we use the "Count property" :

userAgeList.count

////////////Insert() Method/////////////////////
// To add members at a specific position, use the Insert() method
// To insert a member at the 3rd position, you write: 
userAgeList.Insert(2,51);

//Where 2 is the index and 51 is the value you want to insert.
// userAgeList now becomes :
                            { 11, 21, 51, 31, 41, 51, 61 };

///////////////////--RemoveAt()--///////////////////////
// To remove a member at a specific location, use the "RemoveAt()" method.
// for instance, to remove the 4th item (index 3), you write:-

userAgeList.RemoveAt(3);

//Where 3 is the index of the item to be removed.
userAgeList // now becomes:
                           { 11, 21, 31, 51, 61 };

///////////////--Contains()--//////////////
//To check if a list contains a certain member, use the contains() method.
// To check if userAgeList contains '51', we write:
                                                   userAgeList.contains(51);
// We will get "true" as the result.

//////////--Clear()--///////////////////
// To remove all items in a list, use the "Clear()" method. If we write:
userAgeList.clear();
// We will have no elements left in the list.

////////////////////--Value Type vs Reference Type--/////////////////
// Now that we are familiar with "strings", "arrays", "lists".
// Lets talk about an important subject in C#.

//All Data Types in C# can be classified as either a "Value Type" or "Reference Type".

/*
  * The 'Data Types' discussed in chapter 3 are "Value Types".
  * Those discussed in this chapter 4 : Arrays, Strings, List are "Reference Types".
 */

// A "Value Data Type"  is a 'variable' that 'stores' it's own data.
//When we write:
int myNumber = 5;
//The variable myNumber stores the actual "value 5"


//A "Reference Data Type", on the other hand does not 'store' the "actual data".
// Instead, it stores a reference to the data.
// It tells the compiler where to find the actual data.

// An example of "Reference Type" is a "string". When you write a statement like:
string message = "Hello"; 

// the variable message actually does not store the string "Hello".
// Instead, the string "Hello" is created and stored elsewhere in the computers memory.
// The variable message stores the address of that memory location.

//Thats all when it comes to refernce types and value types.
// Always be aware that there is a difference "Reference Types" and "Value Types".
// The former stores a "Value", while the latter stores an "Address".
  





