using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GradesPrototype.Data
{
    // Types of user
    public enum Role { Teacher, Student };

    // WPF Databinding requires properties

    // TODO: Exercise 1: Task 1a: Convert Grade into a class and define constructors
    public class Grade
    {
        public int StudentID { get; set; }
        public string AssessmentDate { get; set; }
        public string SubjectName { get; set; }
        public string Assessment { get; set; }
        public string Comments { get; set; }

        public Grade(int studentID, string assessmentDate, string subject, string assessment, string comments)
        {
            StudentID = studentID;
            AssessmentDate = assessmentDate;
            SubjectName = subject;
            Assessment = assessment;
            Comments = comments;
        }
        public Grade()
        {
            StudentID = default(int);
            AssessmentDate = DateTime.Now.ToString("d");
            SubjectName = "Math";
            Assessment = "A";
            Comments = string.Empty;
        }
    }

    // TODO: Exercise 1: Task 2a: Convert Student into a class, make the password property write-only, add the VerifyPassword method, and define constructors
    public class Student
    {
        string password = Guid.NewGuid().ToString();
        public int StudentID { get; set; }
        public string UserName { get; set; }
        public string Password
        {
            set
            {
                password = value;
            }
        }
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool VerifyPassword(string password)
        {
            if (0 == string.Compare(this.password, password, false))
            {
                return true;
            }
            return false;
        }
        public Student(int studentID, string userName, string password, string firstName, string lastName, int teacherID)
        {
            StudentID = studentID;
            UserName = userName;
            Password = password;
            TeacherID = teacherID;
            FirstName = firstName;
            LastName = lastName;
        }
        public Student()
        {
            StudentID = default(int);
            UserName = string.Empty;
            Password = string.Empty;
            TeacherID = default(int);
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }

    // TODO: Exercise 1: Task 2b: Convert Teacher into a class, make the password property write-only, add the VerifyPassword method, and define constructors
    public class Teacher
    {
        string password = Guid.NewGuid().ToString();
        public int TeacherID { get; set; }
        public string UserName { get; set; }
        public string Password
        {
            set
            {
                password = value;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }

        public bool VerifyPassword(string password)
        {
            if (0 == string.Compare(this.password, password, false))
            {
                return true;
            }
            return false;
        }
        public Teacher(int teacherID, string userName, string password, string firstName, string lastName, string className)
        {
            TeacherID = teacherID;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Class = className;
        }
        public Teacher()
        {
            TeacherID = default(int);
            UserName = string.Empty;
            Password = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Class = string.Empty;
        }
    }
}
