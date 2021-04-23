using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student : User
    {
        public string CurrentSubject { get; set; }

        public string[] PastSubjects { get; set; }

        public int[] Grades { get; set; }


        public Student()
        {

        }

        public Student(int id, string username, string password) : base() { 

        }

        public Student(string currentSubj, string[] pastSubj, int[] grades)
        {
            CurrentSubject = currentSubj;
            PastSubjects = pastSubj;
            Grades = grades;
        }

        public void AverageGrade()
        {
            int[] averageGrade = Grades
                                  .Average();  
        }
    }
}
