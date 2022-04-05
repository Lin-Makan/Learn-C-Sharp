// Chapter 11 : File Handling

// We've now come to this last chapter before we start the project.

// In this chapter, we'll learn how to "read & write" to an 'external file'.

// In chapter 5, we learnt how to get input from 'users' using the "ReadLine()" method.

/* However, in soem cases, getting "users" to enter data into our program may not
   be practical, especially if our program needs to work with large amounts of data.
*/
/*
   In cases like this, a mor convenient way is to prepare the needed information as
   an 'external file' and get our 'programs to read' the "information" from the 'file".
*/

// C# provides us with a number of classes to work with files.
/* 
 The classes that we are going to look at in this chapter are :
 * "File"
 * "StreamWriter"
    and 
 * "StreamReader" classes.
*/
// All three classes are available in the "System.IO" namespace.
// To use the methods in this chapter, you have to add the directive :

using System.IO;
// to the start of your code.

////////////////////////Reading a Text File///////////READING A TEXT FILE////////
// To read data from a 'text file', we use the  "StreamReader" class.
// Suppose we want to read data from the file "myFile.txt" located on the C drive.
// The example below shows how to do it :

string path = "C:\\myFile.txt";
using (StreamReader sr = new StreamReader(path))
{
    while (sr.EndOfStream != true)
    {
        Console.WriteLine(sr.ReadLine());
    }

    sr.Close();
}

// On line 36, we first declare a string variable path and assign the 'path of the file' to the "variable".

// Note that we have to use double slashes \\ when writing the path.
/* This is because if we only use a single slash, the compiler will think the 
   single slash is the beginning of an escape sequence.
This will result in an error.
*/

// On line 2, we create a "StreamReader" instance.
// The "StreamReader" constructor takes in one argument- the path of the file to be read.
StreamReadersr = new StreamReader(path)

/* Notice that we create this "streamReader" instance inside a pair of parenthesis that
   follows the word using on line "37" ?
*/
// The 'Using' keyword here ensures that the "Dispose()" method is always called.
/*
   The Dispose() method is a pre-written method in the "System" namespace that 
   closes or releases any unmanaged resources such as 'files' and 'streams' once
   they are no longer needed.
*/
/*
   When we use the 'using' keyword, we ensure that the "Dispose()" method is 
   called even if an exception occurs and prevemnts our code from reaching "line 9"
   where we manually close the file.
 */
// It is good practice to always use the "using" keyword whenever you are dealing with "files".
// The code to read and close the file is enclosed within curly braces {  } after the using statement.
// From lines 39 to 42, we use a 'while' loop to read the text file line by line.
  while (sr.EndOfStream != true)
  {
     Console.WriteLine(sr.ReadLine());
  }

  // EndOfStream is a property of the "streamreader" class that returns true when the end of the file is reached.
  // As long as the end of file is not reached, the "while loop" will continue to run.
  // Inside the while loop, we havethe statement :

  Console.WriteLine(sr.ReadLine ());
// sr.ReadLine reads a line from the text file and returns it as a string.
// This string is then printed onto the screen using the "Console.WriteLine ()" method.

// Finally, after we finish "reading the file", we close the file so that other programs may use it.
// You should always "close your file" once you no longer need it.
Sr.Close();

// That's it, thats how you "read a text file in C#".
// However, we have one problem with the code above.
// This codde will generate an error if the file "myFile.txt" cannot be found.
                   //We have 2 Options Here :
 
                          // OPTION 1 : try...catch

// The first option is to use a "try...catch" statement as a shown below :

 
   1   try
   2   {
   3   using (StreamReader sr = new StreamReader(path))
   4   {
   5   while (!sr.EndOfStream)
   6   {
   7   Console.WriteLine (sr.ReadLine());
   8   }
   9   sr.Close();
   10  }
   11  } catch (FileNotFoundException e)
   12  {
   13  Console.WriteLine (e.Message);
   14  }


// From lines "1 to 11", we try to "open", "read" and "close" the file in the 'try' block.
/* From lines "11 to 14", we use a 'catch' block to catch the
   "FileNotFoundException" exception 'if' the file is not found. 
*/
/*
  Inside the 'catch' block, we print an error statement to inform users that the 
  file is not found.
 */


                         // OPTION 2 : File.Exists ()

/* The second method to deal with a "file not found" scenario is to use the
   Exists () method in the "File" class.
*/
// As the name suggests, the Exists () method checks if a "file" exists.
/*
   The "File" class is a pre-written class in the System.IO namespace that provides
   static methods for the "creation", "copying", "deletion", "moving", and "opening" of a single file.
 */
/*
  To use the "Exists ()" method, we use an "if" statement to check if the 'file exists'
  before using a "StreamReader" to open and 'read the file' :
 */
if (File.Exists(path))
{
    using (StreamReader sr = new StreamReader(path))
    {
        while (!sr.EndOfStream)
        {
            Console.WriteLine(sr.ReadLine());
        }

        sr.Close();
    }
} else
{
    // Do something else
}

// In the "else" block, we can write code to create the "file" if it not 'found'.

/*
    As you can see, the two methods for dealing with cases where the file is 
    missing are quite similar.

    However, the "File.Exists ()" method is the preffered method as it is faster
    than the "try...catch" statement.
*/

//  Writing To A Text File :
// Next, let us look at how to write to a 'text file'.

// To write to a 'text file', we use the "StreamWriter" class.

/*
  If you want to "append data" to an 'existing file', you can create a 
  "StreamWriter" instance like this :
*/

StreamWriter sw = new StreamWriter(path, true);

// where "path" is the path of the file and "true" indicates that we want to "append the data".
/*
   If you want to overwrite any existing data in the file, you create a  
   "StreamWriter" instance like this :
 */

StreamWriter sw = new StreamWriter(path);

/*
  When we create the "StreamWriter" instance, the 'constructor looks for the file'
  at the given path.
 */
// If the 'file' is not found, it creates the file.

/*
   After we instatiate our "StreamWriter" object, we can start writiting to
   our file using the "WriteLine()" method as shown below :
*/
sw.WriteLine("It is easy to write to a file.");

// After we finish 'writing to the file', we have to 'close the file' by writing:

sw.Close();

/*
   Note that when you write to a 'text file', it is also good
   practice to enclose your code in a "using" statement.
 */
// The code below shows a complex example of how all these come together :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Learning_CSharp
{
   class Program
   {
      static void Main(string []args)
      {
        // declaring the path to the file
        string path = "myFile.txt";

        // writing to the file
        using (StreamWriter sw = new StreamWriter (path, true))

        {
            sw.WriteLine("ABC");
            sw.WriteLine("DEF");
            sw.Close();
        }

        // Reading from the file
        if (File.Exists(path))
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                Sr.Close();
            }
        }
        Console.Read();
      }
   }
}

// In this example, we choose to append data to our file when we write to it.
// When you run the program for the first time , you'll get :

/*
   ABC
   EFG
 */
// as the file output and screen display. If you run it for the second time, you'll get :

/*
   ABC
   EFG
   ABC
   EFG
 */

/*
   As the full path of "myFile.txt" is not given in this example, the text file
   will be created in the same folder as the ".exe file", which is in the 
   "Learning_CSharp" > "learning_CSharp" > "Debug" > "Bin Folder".
*/
