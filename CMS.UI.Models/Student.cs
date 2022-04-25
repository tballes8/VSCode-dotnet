using System;

namespace CMS.UI.Models
{

    public class Student
    {

        public Student(int studentID, string firstName, string lastName, int courseID) 
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CourseID = courseID;
        }
        
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseID { get; set;}

    }

}