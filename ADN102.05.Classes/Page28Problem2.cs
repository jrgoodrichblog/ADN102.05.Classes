using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Expand the previous program to add the following features:

//add another constructor to the sale object which will accept a csv line, parse it for correctness, and initialize the sale object with the data. The CSV line must contain an employeename, the salesamount and the commissionRate

//validate three possible errors: (throw an exception with as much information as possible if one of these errors is discovered)

//the csv line does not have the correct number of commas
//the salesAmount is not recognizable as a decimal
//the commission rate is not recognizable as a decimal
//modify the Main to open a file called sales.csv containing sales data in a CSV format

//create a list of sale objects (using System.Collections.Generic.List) and loop over each of the lines in the file to create a sale object using the constructor you just added

//add the newly created object to the list on each iteration of the loop

//place the construction code in a try-catch block: catch any exceptions, print them out, and continue executing the rest of the file. if an exception occurs, do not add the corrupted data to the list.

//after reading all the data, close the reader

//after reading all the data, now loop over all the data in the list, printing out an index and the item at that index.

//now enter into an infinite loop and

//Prompt the user to type in two numbers separated by spaces(from the list of data above)
//parse the line and validate that the two numbers are correct
//there should only be 2 numbers
//both numbers should be able to be recognized as integers
//if either number is negative, print out a message and try again(continue)
//if either number is too large (larger that the count of elements in the list), print out a message and try again(continue)
//if everything is fine with the numbers, add the two elements identified together and print out the results

namespace Page28P2
{

    
    public class sale
    {
        // make a copy of the sale class you have in Page28Problem1
        // replace this class with that one.
        // this class has stub methods for everything that is needed
        // by the implementation of Main

        // you will have to implement the ctor(string csv) below
        // the other two methods should already be implemented in the other class

        public sale(string csv)
        {

        }
        public sale()
        {

        }
        public static sale operator +(sale left, sale right)
        {

            return new sale();
        }

    }

    public class Program
    {
        public static void Main()
        {

            // this section reads the data from the file.
            System.IO.TextReader reader = System.IO.File.OpenText("sales.csv");
            string line;
            List<Page28P2.sale> SalesData = new List<Page28P2.sale>();
            while (!string.IsNullOrWhiteSpace(line = reader.ReadLine()))
            {
                try
                {
                      SalesData.Add(new sale(line));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            reader.Close();
            for (int i = 0; i < SalesData.Count; i++)
            {
                Console.WriteLine($"{i,3}: {SalesData[i]}");
            }

            Console.WriteLine("********************");
            // this loop processes the requests
            while (true)
            {
                Console.Write("Type in two numbers (separated by a space) from the list above to add together (or hit return to exit): ");
                line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }
                string[] data = line.Split(' ');
                if (2 != data.Length)
                {
                    Console.WriteLine($"Invalid format '{line} does not have two numbers separated by a single space");
                }
                else
                {
                    int one;
                    int two;
                    if (!int.TryParse(data[0], out one))
                    {
                        Console.WriteLine($"The first item of '{line}' is not an integer "); continue;
                    }
                    if (!int.TryParse(data[1], out two))
                    {
                        Console.WriteLine($"The second item of '{line}' is not an integer "); continue;
                    }
                    if (one < 0)
                    {
                        Console.WriteLine($"The first item of '{line}' is too low (must be 0 or greater) "); continue;
                    }
                    if (two < 0)
                    {
                        Console.WriteLine($"The second item of '{line}' is too low (must be 0 or greater) "); continue;
                    }
                    if (one >= SalesData.Count)
                    {
                        Console.WriteLine($"The first item of '{line}' is too high (must be {SalesData.Count - 1} or less) "); continue;
                    }
                    if (two >= SalesData.Count)
                    {
                        Console.WriteLine($"The second item of '{line}' is too high (must be {SalesData.Count - 1} or less) "); continue;
                    }
                    Page28P2.sale first = SalesData[one];
                    Page28P2.sale second = SalesData[two];
                    try
                    {
                        Page28P2.sale third = first + second;
                        Console.WriteLine(third);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }
    }
}
