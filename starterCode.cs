using System;

// Requirement: Create a simple College Enrollment System:
// 1. Create a Student Class: student: name, id, programgroup {CSAT, MAD, ECE, CPCT}
// #todo: create 20 student objects using Factory Method : anonymous object references
// and put them into an Array!

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager.Run();
        }
    }

    class Manager
    {
        public static void Run()
        {
            // use the Factory Design Pattern to generate 100 Students

            new Student("JOE", "CSAT", "C333");
        }
    }
    class Student
    {
        private string StudentName;
        private string programGroup;
        private string StudentID;

        public Student(string sName, string pGroup, string sid)
        {
            this.StudentName = sName;
            this.StudentID = sid;
            this.programGroup = pGroup;
        }

        public string getStudentName()
        {
            return this.StudentName;
        }

        public void setStudentName(string sName)
        {
            this.StudentName = sName;
        }


        public string getProgramGroup()
        {
            return this.programGroup;
        }

        public void setProgramGroup(string pGroup)
        {
            this.programGroup = pGroup;
        }

        public string getStudentID()
        {
            return this.StudentID;
        }

        public void setStudentID(string stid)
        {
            this.StudentID = stid;
        }

    }
}
