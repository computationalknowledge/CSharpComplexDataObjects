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
        // # todo: create an array with 100 students:
        static Student[] studentList = new Student[100];
        static string[] studentNames = new string[5];

        private static void Initialize()
        {
            studentNames[0] = "JOE";
            studentNames[1] = "ARRY";
            studentNames[2] = "JOEL";
            studentNames[3] = "LENA";
            studentNames[4] = "MIC";
        }

        public static void Run()
        {
            int counter = 0;
            Manager.Initialize();
            // use the Factory Design Pattern to generate 100 Students
            for (int i = 0; i < 100; i++)
            {   
                // if I do not keep a reference to my objects visible to running program thread
                // they will be garbage collected:

                studentList[0] = new Student(studentNames[counter++], "CSAT");
                if (counter > 4)
                {
                    counter = 0;
                }
            }
            
        }
    }
    class Student
    {
        private string StudentName;
        private string programGroup;
        private int StudentID;

        public Student(string sName, string pGroup)
        {
            this.StudentName = sName;
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

        public int getStudentID()
        {
            return this.StudentID;
        }

    }
}
