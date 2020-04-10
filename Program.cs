using System;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.ShowMaleStudents();
            um.SortStudentByAge();
            um.ShowStudentsFromUniversity("Yale");
            um.ShowStudentsFromUniversity("MIT");
        }
    }
}
