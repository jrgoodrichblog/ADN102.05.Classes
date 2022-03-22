using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page05Part2
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
            Console.WriteLine("Student object created using the default ctor");
        }

        public Student(string first, string last)
        {
            firstName = first;
            lastName = last;
            courseFocus = "Default Course Focus";
            Console.WriteLine("Student object created using a two item ctor");
        }
        public Student(string first, string last, string focus)
        {
            firstName = first;
            lastName = last;
            courseFocus = focus;
            Console.WriteLine("Student object created using a three item ctor");
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
            Student student2 = new Student("Brian", "Walters");
            Student student3 = new Student("Carol", "Walters", "C#");
            student1.Display();
            student2.Display();
            student3.Display();
        }
    }
}

