using System;
using System.Collections.Generic;
using CMS.UI.Models;


namespace CMS.Application
{

    class Program
    {
        static List<Student> students = new List<Student>();

        public int MyProperty{ get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Entered Main()");
            Initialization();

        }

        private static void Initialization()
        {
            students.Add(new Student(100001, "John", "Smith", 1));
            students.Add(new Student(100002, "Robert", "Smith", 2));
        }

        private static void FinalizeMethod()
        {
            // Handle the FinalizeMethod here
            // ---
        }

        private static void Print()
        {
            // Print the student data to the consol
            // ----
        }

    }
}
