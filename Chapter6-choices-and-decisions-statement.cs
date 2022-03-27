using System;
/*
    We'll learn how to control the "Flow of the Program".
    "Control Flow Statements".
 */
/* We'll learn about the "if Statement" , the "inline Statement", the "switch Statement".
   the "for Loop", the "foreach Loop", the "while Loop" and the "do while Loop".
 * 
 */
/* Then After we'll learn about the "try-catch-finally" Statement that 'controls' the 
   'flow of the program' when an "error occurs."
*/
/*    We'll learn how to control the "Flow of the Program" using the 
      "Control Flow Statements". */

// Before we get to control tools, we'll first look at "Condition Statements".

////////////////////--CONDITION STATEMENTS--///////////////////////////
// 
/* Most control flow statements involve evluating a condition statements.
 * The program will proceed depending on the condition.
 * The most common condition is the "comparison statement".
 * If you want to compare whether two variables are the same, use the double minus (--)
 * x -- y >>>> Here you check whether "x" is equal to the value of "y".
 */

// If they are equal, the "condition is met" the statement evaluates to "true".
// ELSE, the statement evaluates to "false".
/* 
   Other than evaluating tthe equality of the values.
   There are other "Comparision Operators".
*/

/////////////--NOT EQUAL (! =)-- ///////////////////////////////
// Return true if the "left" |is not| equal to the "right"
5 != 2,      // is true
6 != 6,      //   is false
//////////////////////////////////////////////////////////

///////////////////Greater than ( > )/////////////
// Returns true if the "left" |is greater| than the "right".
5 > 2     //is true
3 > 6    // is false
////////////////////////////////////////////


/////////////SMALLER THAN ( < )/////////////////
// Return true if the left is smaller than the right
1 < 7   // is true
9 < 6    // is false
///////////////////////////////////////////////////////////



//////////////GREATER THAN OR EQUAL TO ( > = )/////////////////////
// Return true if the left is greater than or equal to the right
5 >= 2     // is true
5 >= 5     // is true
3 >= 6     // is false
//////////////////////////////////////////////////////////////

///////////////--SMALLER THAN OR EQUAL TO ( <= )//////////////
// Returns true if the left is smaller than or equal to the right
11 <= 7;   // is false   
7 <= 7;    // is false
9 <= 6;     // is false

/* We also have "Three Logical Operators" (&&, ||, !) that are useful 
   if we want to "Combine Multiple Conditions".
 */

//////////////////--The AND Operator (&&)--////////////////////
// Returns true if all conditions are met
5 == 5 && 2 > 1 && 3 != 7,     // is true

///////////////--The OR Operator (||)   //////////////
// Returns true if at least one condition is met.
5 == 5 || 2<1 || 3==7,  // is true as the first condition (5==5) is true. 
5 == 6 || 2<1 || 3==7,   // is false as all conditions are false. 



////////////////CONTROL FLOW STATEMENTS////////////////////
// * Now that we are familiar with "condition statements",
// Now lets use these 'condition statements" to 'control' the "flow of the program".

///////////If Statement//////////////////IF STATEMENT/////////////////// :
// The if statement is one of the most commonly used "control flow statements".
/* It allows the program to evaluate if a certain "condition is met".
   and to perform the appropriate action based on the result of the evaluation.
*/
// The structure of an "if" statement is as follows
/* 1 */         if ( condition 1 is met)
/* 2 */         {
/* 3 */            do Task A
/* 4 */         }
/* 5 */           else if (condition 2 is met)
/* 6 */         {
/* 7 */           do Task B
/* 8 */         }
/* 9 */          else if (condition 3 is met)
/* 10 */        {
/* 11 */         do Task C 
/* 12 */        }
/* 13 */         else
/* 14 */        {
/* 15 */         do Task 
/* 16 */        }

// The first line tests the first condition
// If the condition is met, everything inside the pair of curly braces that follow (lines 2-4) will be executed.
// The rest of the "if" statement (5 to 16) will be skipped.
// If the first condition is not met, you can use the "else if" statements that follow to test more conditions (lines 5-12).
// There can be multiple "else if" statement. 
// Finally, you can use the "else statement" (lines 13-16) to execute some code if none of the proceeding conditions are met.

// To fully understand how the "if" statement works, add the following code to the Main() program in vsc template.

int userAge;

Console.Write("Please enter your age: ");
userAge = Convert.ToInt32(Console.ReadLine());

if (userAge < 0 || userAge > 100)
{
    Console.WriteLine("Invalid Age");
    Console.WriteLine("Age must be between 0 and 100");
}
else if (userAge < 18)
    Console.WriteLine("Sorry you are underage");
else if (userAge < 21)
    console.WriteLine("You need parental consent");
else
{
    console.WriteLine("Congratulations!");
    console.WriteLine("You may sign up for the event! ");
}

// The program first prompts the user for his age and 'stores' the result in the "userAge variable"
// The next statement :   if (userAge < 0 || userAge > 100)
// Checks if the value of userAge is "smaller than zero" or "greater than 100".
// If either of the conditions is true the origram will execute all statements within the curly braces that follow.
// etc........................

// Run the program five times, and enter -1, 8, 20, 23 and 121. respectively for each run. You'll get the following outputs :-

  Please enter your age : -1
  Invalid Age
  Age must be between 0 and 100

  Please enter your age: 8
  Sorry you are underage

  Please enter your age: 20
  You need parental consent

 Please enter your age: 23
 Congratulations!
 
 Please enter your age: 121
 Invalid Age
 Age mut be between 0 and 100


///////// Inline If Statement //////////INLINE IF STATEMENT////////////////////////
// An inline if statement is a simpler form of an "if statement".
// That is very convenient if you want to "assign a value" to a 'variable' depending on the result of a 'condition'.
// The Syntax is :

condition? value if condition is true : value if condition is false

// For instance , the statement :
3 > 2 ? 10 : 5;

// Returns the value 10 since 3 is greater than 2 ( i.e. the condition 3 > 2 is true).
// This value can be assigned to a variable ;
// If we write :

int myNum = 3 > 2 ? 10 : 5;

// myNum will be assigned the value "10".

//////////////// Switch Statement /////////SWITCH STATEMENT//////////////////
// A Switch requires that each case to be based on a single value.
//Depending on the value of the variable used for switching, the program will use the correct block of code.

//        Syntax Of A Switch Statemenet
 
   switch (variable used for switching)
   {
      case firstCase:
      do A;
      break (or other jump statements);
      
      case secondCase;
      do B;
      break (or other jump statements);

      case default:
      do C;
      break (or other jump statements);
   }
 

// You can have as many cases as you want when using a "switch" statement.
// The default case is optional, and executes only if no other case applies.
// When a certain case is satisfied, then everything from the next line is executed until a jump statement is complete.
// A jump statement is a statement that instructs the compiler to jump to another line in the program.

// The most commonly used jump stataemnt is the "break;" statement.

/* 1 */    Console.Write("Enter your grade : ");
/* 2 */    string userGrade = Console.ReadLine();
/* 3 */
/* 4 */    switch (userGrade)
/* 5 */   {
/* 6 */    case "A+":
/* 7 */    case "A":
/* 8 */        Console.WriteLine("Distinction");
/* 9 */        break;
/* 10 */    case "B":
/* 11 */        Console.WriteLine("B Grade");
/* 12 */        break;
/* 13 */    case "C":
/* 14 */        Console.WriteLine("C Grade");
/* 15 */        break;
/* 16 */    default:
/* 17 */        Console.WriteLine("Fail");
/* 18 */        break;
/* 19 */   }

// The program first promts the user for his "grade".

/* If Grade is "A+"  (Line 6) , the program executes the next statement until it reaches
   the " break; " statement.
   
   This means it'll execute "Lines 7 to 9"
   Thus the output is "Distinction".

   If grade is "A" (Line 7), the program executes "Line 8 and 9"
   Similarly the output is "Distinction".
 
   If grade is not "A+" or "A", the program checks the next "case".
 * It keeps checking from Top to Bottom until a case is saitisfied.
 * If none of these cases applies, the default case is executed.
*/

// If you run the code above you'll get the following :


   Enter your grade: A+
   Distinction
 
   Enter your grade: A
   Distinction
  
   Enter your grade: A
   Distinction 

   Enter your grade: B
   B Grade

   Enter your grade: C
   C Grade

   Enter your grade: D
   fail

   Enter your grade: Hello
   fail
 
 

///////////For Loop////////////FOR LOOP//////////////
// The "for" loop executes a "block of code" repeatedly until the 'test' 'condition' is no longer valid.
// The Syntax for a "for loop" is as follows :

for (initial value; test condition; modification to value)
{
     // Do some task
}

// To understand how the "for loop" works, look below :
/* 1 */        for (int i = 0 ; i < 5; i++)
/* 2 */        {
/* 3 */          Console.WriteLine (i);
/* 4 */        }

// The main focus of the for loop is line 1 :

// There are three parts to it, each seperated by a semi-colon :.
for (int i = 0; i < 5; i++)
    // The 'First part' declares and initializes an "int" variable "i" to zero.
    // This variable serves as a "loop counter".

    // The 'Second Part' 'tests' if "i" is "smaller than 5".
    // In this example, the curly braces are optional as there is one statement.

    // After executing the "WriteLine()" statement, the program returns to the last segment in "Line 1".
    // "i++" increments the value of "i" by 1. Hence, 'i' is increased from "0 to 1".

    // After the "increment", the program tests if the "new value" if "i" is still "smaller than 5".
    // If it is, it executes the "WriteLine()" statement once again.

    /* This process of testing and 'incrementing' the "loop counter" is repeated until the 
       condition "i < 5" is no longer 'true".

       At this point, the program exits for the "for loop" and continues to execute other commands after the "for loop".
    */

    // The Output for the code segment is :
    
       0
       1
       2
       3
       4
     
    /* The 'output' stops at "4" because when "i" is "5", the "WriteLine()" statement is not executed
       as "5" is not "smaller than 5"
    */

    // The "for loop" is commonly used to "loop" through an "Array" or a "List".
    //               For instance, if we have ; 

int[] myNumbers = { 10, 20, 30, 40, 50 };
    
// We can use the 'for loop' and the length property of the array to loop through, shown below:

for (int i = 0; i < myNumbers.Length; i++)
{
    Console.WriteLine(myNumbers[i]);
}

// As "myNumbers.Length" is equal to '5', this code runs from "i=0" to "i=4".
// If we run the code, the following output is :

  10
  20
  30
  40
  50
 
//////Foreach Loop//////////////////FOREACH LOOP////////////////////////
/* In addition to "for loops", we can also use a "foreach" loop when working with "Arrays" and "Lists"
   
   A Foreach loop is very useful if you want to get information from an Array or List,
   without making any changes to it,

   Suppose you have :-
*/

char[] message = { 'H', 'e', 'l', 'l', 'o' };

// You can use the following code to display the elements of the 'array'.

foreach (char i in message)
    Console.Write(i);

/*
  In the code above, we have a "char" variable 'i' that is used for looping.
  Each time the 'loop runs', an 'element' in the message "array" is assigned to the variable 'i"
  For instance, the first time the loops runs, the character 'H' is assigned to "i".
*/
Console.Write(i);
// then prints out the letter 'H'.

// The second time the loop runs, the character 'e' is assigned to "i".
// The line :
Console.Write(i);
// prints out the letter 'e'.
// This continues until all the "elements" in the "array" have been printed.

/////////////While Loop//////////////
/* Like the name suggests, a "While"Loop repeatedly executes instructions inside
   the loop while a certain condition remains valid.
*/
// The structure of a "while" statement is as follows-:

while (condition is true)
{
    do A
}

/* Most of the time when using a while loop, we need to first declare a variable
   to function as as a "Loop Counter".
   
   Let's call this variable "Counter".
*/
// The code belowshows an example how a "while" loop works.

int counter = 5;

while (counter > 0)
{
    Console.WriteLine("Counter = {0}", counter);
    counter = counter - 1;
}

//Ifnyou run the code, you'll get the following output:-

counter = 5
counter = 4
counter = 3
counter = 2
counter = 1

// A while statement has a relatively simple syntax.
// The statements inside the curly braces are executed as long as "counter > 0".
/* Then line with "counter = counter - 1" inside the curly braces? Its a crucial line
   It decreases the value of "counter" by 1 so that the loop condition (counter < 0)
   will eventually evaluate to "false".

   If we forget to do that, the loop will keep running endlessly, resulting in 
   an "infinite loop".
   The program will keep printing "counter = 5" untilyou somehow kill the  program.
You might not even have an idea which code segment is causing the "infinite loop".
*/
/////////Do While ///////////////////////DO WHILE///////////////////////////////
// The "do while" loop is similar to the "while" loop with one main difference:
// The code within the curly braces of a "do while" loop is executed at least once.
//         Example Of How A "Do While Loop" Statement Works:

int counter = 100;

do {
    Console.WriteLine("counter = {0}", counter);
    counter++;
} while (counter < 0);

/* As the test condition "(while (counter < 0))" is placed after the closing curly brace, it is tested after
   the code inside the curly braces is executed at least once.

   If you run the code above, you will get:-
                                             Counter = 100;
 */

/*
* After the "WriteLine" statement is executed for the first time, 
  "counter" is "incremented by 1."

* The value of "counter" is now 101.
  When the program reaches the test condition,  the test fails as
  "counter" is not "smaller than 0".

* The program will then exit the loop.
  Even though the original value of counter does not meet the test
  conditon "(counter < 0)", the code inside the curly braces is still executed once.
* Notice that for a "do while" statement,  a semi-colon(;) is required after the Test conditon.
*/

//////////////Jump Statements///////////////JUMP STATEMENTS//////////////////////////////////

// We've now covered most of the control flow statements, now to do Jump Statements.

/* A "Jump Statement" is a statement that instructs the program to deviate from its
   "normal flow sequence" and jump to another line of code.
* Jump Statements are commonly used in loop and other controlflow statements.
*/

///////      Break; Statement     ////////
// The 'break" keyword causes the program to "exit a loop" prematurely when a certain condition is met.
// We've seen how a break keyword is used in a switch statement.

// We' ll now look at how a "break" keyword can be used in a "for loop".

/* 1 */     int i = 0;

/* 2 */     for  (i = 0; i < 5; i++)
/* 3 */     {
/* 4 */         Console.WriteLine("i = {0}", i);
/* 5 */         if (i == 2)
/* 6 */         break;
/* 7 */     }

// In  this example, we used an "if statement" inside a "for loop".
/* It is very common for us to 'mix-match' various control tools in programming
   such as using a "while loop" inside an "if statement" or using a "for loop" inside a 'while loop'.
 
   This is  known as "nested control statement". 
 */
// If you run the program, you will get the Output :
i = 0
i = 1
i = 2
// Note that the loop ends prematurely at "i = 2" ??
/* Without the "break" keyword, the loop should run from "i = 0" to 
   "i = 4" because the loop condition is "i < 5".
  
   However with the "break"keyword, when "i = 2", the condition on 
   line 6 evaluates to true.
   
   The "break" keyword on line 7 then causes the loop to end prematurely
*/

    /////////////////Continue Jump  /////////////// CONTINUE JUMP STATEMENT////
// Another commonly used "jump keyword" is the "continue keyword".
// When we use "continue", the rest of the loop after the keyword is skipped for that "iteration".

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("i = {0}", i);
    if (i == 2)
        continue;
    Console.WriteLine("I will not be printed if i=2. \n");
}

// You will get the following output:


   i = 0
   I will not be printed if i = 2.

   i = 1
   I will not be printed if i = 2.

   i = 2
   i = 3
   I will not be printed if i = 2.

   i = 4
   I will not be printed if i = 2.
 

// When "i = 2", the line after the continue keyword is not executed.
// Other thann that, everything runs as per normal.

////////Exceptional Handling  //////////////////
/* We're now learned how to control the 'flow' of a program under 'normal circumstances'
   using the "control flow statements" and "jump statements" 
   
   Before we close this chapter, we must look at one more control flow
   statement, the "try-catch-finally" Statement. >>>TRY-CATCH-FINALLY<<< STATEMENT.
*/

// The "try-catch-finally" statement controls how the program handles "error".
//   The Syntax there of is :

try
{
    do something
}
catch (Type of error)
{
  do something else when an error occurs
}
finally
{
    do this regardless of whether the try or catch condition is met
}
    

// You can have more than one "catch" blocks.
// In additonal. the "finally block" is optional. Let's consider an example.

/// <summary>
/// </summary>
/////////////////////////////////////////////////////////////////////////////////////////////////////

int numerator, denominator;

Console.Write("Please enter the numerator: ");
numerator = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine("The result is {0}. ", numerator / denominator);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("----End of Error Handling Example");
}

// If you run the code and enter 12 and 4, you'll get the message "exception".
// To display that properly, we write :

Console.WriteLine(e.Message);

/////////////////////////////////////////////////////////////////////////////////////////////////////

///////////--Specif Errors--/////////////SPECIFIC ERRORS///////////////////////////////////////

/* In addition to the "Exception Class" that handles general errors,  we also have other classes
   that can handle more "specific errors".

   This is useful if you want to perform specific tasks depending on the error caught.
For instance, you might want to display your own "error message". 
*/
// Try running the code below :

int choice = 0;
int[] numbers = { 10, 11, 12, 13, 14, 15 };
Console.Write("Please enter the index of the array: ");

try
{
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
} catch (IndexOutOfRangeException)
{
    Console.WriteLine("Error: Index should be from 0 to 5.");
} catch (FormatException)
{
    Console.WriteLine("Error: You did not enter an integer.");
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// If you enter  '10'
// You will get :
/* 
   Index ws outside the bounds of the array.
   Index should be from 0 to 5.
 */

// If you enter  'Hello'.
// You will get :

   Input string was not in a correct format.
   You did not enter an integer.
 

/* The FIRST ERROR is a "IndexOutOfRangeException" exception and was handled
   by the first "catch block".
   This "exception" occurs when you try to 'access an element' of an "array" with
   an an index that is outside it's bounds.
 */

/* The SECOND ERROR is a "formatException" exception and was handled by the
   second "catch block".
   The "formatException" excpetion occurs when the 'format of an argument' 
   is invalid.

   In our example, "Convert.ToInt32("Hello") generated a "ForamtException"
   exception as the argument "Hello" cannot be 'converted' into an 'integer'. 

In contrast, if you entered 4, "Convert.ToInt32("4")" will not generate a
"formatException" exception as the string "4" can not be converted into 
an 'integer'.
*/
 /* After the two specific "catch blocks" , we have one more "catch" block
    to catch any general errors that we did not "pre-empt" */
 // The 2 examples we completed above shows only 2 of the many exceptions in C#.
 // Look for more C# 'exceptions'.