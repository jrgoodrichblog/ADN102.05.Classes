using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page15
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string courseFocus;
        // a default constructor
        public Student()
        {
            FirstName = "DefaultFirst";
            LastName = "DefaultLast";
            CourseFocus = "DefaultFocus";
        }
        // create another constructor
        public Student(string courseFocus)
        {
            FirstName = "DefaultFirst";
            LastName = "DefaultLast";
            CourseFocus = courseFocus;
        }

        public Student(string firstName, string lastName, string courseFocus)
        {
            FirstName = firstName;
            LastName = lastName;
            CourseFocus = courseFocus;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // Declare a lastName property of type string
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // Declare a courseFocus property of type string
        public string CourseFocus
        {
            get
            {
                return courseFocus;
            }
            init
            {
                courseFocus = value;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is studying {CourseFocus}";
        }
    }


    class Program
    {
     public   static void main(string[] args)
        {
            // instantiate three student objects
            Student student1 = new Student("Flying");
            Student student2 = new Student("Herbology");
            Student student3 = new Student()
            {
                FirstName = "hermione",
                LastName = "granger",
                CourseFocus = "potions"
            };

            // Print them out

            Console.WriteLine($"student1: {student1.FirstName} {student1.LastName} is studying {student1.CourseFocus}");
            Console.WriteLine("student2: " + student2.FirstName + " " + student2.LastName + " is studying " + student2.CourseFocus);
            Console.WriteLine(student3);

        // set the information for student 1
            student1.FirstName = "Harry";
            student1.LastName = "Potter";
            //student1.CourseFocus = "Flying";

            // set the information for student 2

            student2.FirstName = "Ron";
            student2.LastName = "Weasley";

            // set the information for student 3
            student2.FirstName = "Hermione";   // capitalize first letter
            student2.LastName = "Granger";     // capitalize first letter

            // print information for each student
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
        }
    }


}
