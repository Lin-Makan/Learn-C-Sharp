///////// Chapter 10 : LINQ //////////////

/* LINQ stands for "Language-Integrated-Query" and is an interesting feature of C#
   that allows you to 'query' data in your program.
*/
/* In this chapter, we'll cover a brief introduction to LINQ foolowed by two examples
   of how LINQ can be used.
*/
// First we'll learn how to write a "LINQ" Query.
// The typical suntax for a LINQ Query is :

from... where... orderby... select

/* Let's suppose we have an "array of numbers" and we want to 'select' all
   'even numbers' from the 'array'.

We can do that with LINQ.
*/

// First, let's declare the 'array' :

int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

// Next, we write a "LINQ Query" as follows :

var evenNumQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

// The 'Query' is from the second to the "fourth line".
// Readers familiar with SQL, will have an easier time understanding this.

// The 'query' consists of three parts :
// The first part :
from num in numbers
    // States that we are performing the query on the "numbers array".
    // "num" is the name that we use to represent the individual items in the "array".

// The second part :
where (num % 2) == 0
// tests the 'individual items' to determine "if" the remainder of "num" divided by 2 is "zero".
// If it is, "num" is an even number. The third line :

// The third part :
select num;

// selects all elements that satisfy this criteria.

// This result is then assigned to the variable :
                                                  evenNumQuery
// which is declared to be of "var type".
// "var" is special 'data type' that we use whenever we want the compiler to determine the 'data type' itself.

/*
   This is necessary because in our example, the 'data type' of "evenNumQuery" is
   quite complex, we are better off letting C# figure the "data type" out for us.
*/
// After we create the 'query' statement, we can execute the 'query' by writing :

foreach (int i in evenNumQuery)
{
    Console.WriteLine("{0} is an even number", i);
}

// If you run the code, you will get :

    0 is an even number
    2 is an even number
    4 is an even number
    6 is an even number


// That's it, that's how easy it is to use "LINQ".
// Let us now move on to a more complex example of "LINQ".

/*
   Suppose you have a "customer class" with "Name", "Phone" , "Address" and "Balance"
   as it's 'properties' and a 'constructor' to 'initialize' each of these 'properties'.
*/
// We can create a 'list of' "customer objects" in our "Main()" method using the code below :

List<Customer> customers = new List<Customer>();

customers.Add(new Customer("Alan", "80911291", "ABC Street", 25.60m));
customers.Add(new Customer("Bill", "19872131", "DEF Street", -32.1m));
customers.Add(new Customer("Carl", "29812371", "GHI Street", -12.m));
customers.Add(new Customer("David", "78612312", "JKL Street", 12.6m));

/* Now suppose we want to search for all 'customers' with "negative account balances"
   , We can use the following LINQ Query :
*/

var overdue =
    from cust in customers
    where cust.Balance < 0
    orderby cust.Balance ascending
    select new { cust.Name, cust.Balance };

// This 'query' is similar to the first 'query', with two "main difference".
/*
   Here, we used "two additional keywords" >>> "orderby" and "ascending", to
   arrange the results in 'ascending order'.
 */
// In addition, we used the "new" keyword in the select statement.
// The "new" keyword is needed whenever we want to select more than one field from the "objects".

// To execute and print the results, we can use the "foreach" loop below :

foreach (var cust in overdue)
    Console.WriteLine("Name = {0}, Balance = {1}", cust.Name, cust.Balance);

// We will get the Output :

Name = Bill, Balance = -32.1
Name = Carl, Balance = -12.2

/////////COMPLETE PROGRAM////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Chapter10_LinQ
    {
        static void main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };


            var evenNumQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

            foreach (int i in evenNumQuery)
            {
                Console.WriteLine("{0} is an even number", i);
            }

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer("Alan", "80911291", "ABC Street", 25.60m));
            customers.Add(new Customer("Bill", "19872131", "DEF Street", -32.1m));
            customers.Add(new Customer("Carl", "29812371", "GHI Street", -12.m));
            customers.Add(new Customer("David", "78612312", "JKL Street", 12.6m));

            var overdue =
                from cust in customers
                where cust.Balance < 0
                orderby cust.Balance ascending
                select new { cust.Name, cust.Balance };


        }
               foreach (var cust in overdue)
               Console.WriteLine("Name = {0}, Balance = {1}", cust.Name, cust.Balance);
    }
}

