using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page28P1
{

    // the main tester for this problem is in the Tester class:
    // it is called T_P28P1


    //    Problem 1
    //Create a new console application called SalesTracker and create a class called sale with the following features:

    //a public property of type string called Employee
    //a public property of type decimal called SalesAmount
    //a private property of type decimal called commissionRate
    //a public read only property of type decimal called Commission,
    //       and it is to compute the commission by multiplying the SalesAmount times the commissionRate.
    //a public constructor that accepts an employee name, a sales amount, and a commission rate to construct the sale object
    //a public constructor that accepts an employee name and a sales amount, and which sets the commission rate to 3% (.03)
    //an override of the ToString method which returns a string formatted with the following:
    //EmployeeName in a field 10 characters wide
    //SalesAmount in a field 15 characters wide, and rounded to 2 decimal places, with 4 spots on the left of the decimal point
    //CommissionRate in a field 10 characters wide, rounded to 3 decimal places, with 1 spot to the left of the decimal point
    //Commission
    //a custom operator + which has the following features:
    //public static sale operator +(sale left, sale right) { implemented body }
    //    If the left employee is different than the right employee,
    //    throw an exception indicating that the left and right have to have the same employee name
    //    (show the actual values for left and right)
    //the newly created sales object will compute the new employee name by using the left employee name
    //    (the right employee name is the same)
    //the newly created sales object will compute the new sales amount by
    //    adding together the sales for the left and the right object
    //the newly created sales object will need to compute the new commissionRate by
    //    calculating the total commission for the left and right objects,
    //    and then divide this by the total sales for the left and the right objects.
    //    This formula will ensure that the commission on the newly created sale will be
    //    the sum of the two commissions on the left and right objects.
    //create a new sale object by calling the appropriate constructor providing the values computed above.
    //return the newly created sale object
    //Test the sale object by using the following Main which creates several sale objects , prints them out using Console.WriteLine, and then adds them together to see if they work as expected.
    public class sale
    {


        public static sale operator +(sale left, sale right)
        {

            return new sale();
        }

    }


    public class Program
    {

        public static void Main()
        {

            //sale s1 = new sale("One", 1000, .10M);
            //sale s2 = new sale("One", 500, .05M);
            //sale s3 = new sale("Two", 2500, .10M);
            //sale s4 = new sale("Two", 3000);

            //try
            //{
            //    Console.WriteLine(s1);
            //    Console.WriteLine(s2);
            //    Console.WriteLine(s3);
            //    Console.WriteLine(s4);
            //    Console.WriteLine(s1 + s2);
            //    Console.WriteLine(s3 + s4);
            //    Console.WriteLine(s2 + s3);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}

