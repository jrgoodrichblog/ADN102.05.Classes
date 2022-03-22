using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page05Part1
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string courseFocus;

        // constructor
        public Student()
        {
            firstName = "Default fn";
            lastName = "Default ln";
            courseFocus = "Default Course Focus";
            Console.WriteLine("Student object created!");
        }
        public void Display()
        {
            Console.WriteLine($"'{lastName},{firstName}' is studying {courseFocus}");
        }
    }
    class Program
    {
        public static void Main()
        {
            Student student1 = new Student();
            student1.Display();
        }
    }
}
