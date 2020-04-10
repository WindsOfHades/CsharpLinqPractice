using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqPractice
{
    class UniversityManager
    {
        private List<Univeristy> universities = new List<Univeristy>();
        private List<Student> students = new List<Student>();

        public UniversityManager()
        {
            this.universities.Add(new Univeristy { Id = 1, Name = "Yale" });
            this.universities.Add(new Univeristy { Id = 2, Name = "Harvard" });
            this.universities.Add(new Univeristy { Id = 3, Name = "MIT" });

            this.students.Add(new Student { Id = 1, Name = "Amir", Age = 35, Gender = "Male", UniverityId = 3 });
            this.students.Add(new Student { Id = 2, Name = "Michael", Age = 36, Gender = "Male", UniverityId = 3 });
            this.students.Add(new Student { Id = 3, Name = "Golnaz", Age = 34, Gender = "Female", UniverityId = 3 });
            this.students.Add(new Student { Id = 1, Name = "Zaya", Age = 28, Gender = "Female", UniverityId = 2 });
            this.students.Add(new Student { Id = 1, Name = "Edward", Age = 30, Gender = "Male", UniverityId = 1 });
            this.students.Add(new Student { Id = 1, Name = "Alice", Age = 31, Gender = "Female", UniverityId = 1 });
        }
        public void ShowMaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in this.students where student.Gender == "Male" select student;
            foreach (Student st in maleStudents)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public void SortStudentByAge()
        {
            IOrderedEnumerable<Student> sorted = from student in this.students orderby student.Age select student;
            Console.WriteLine("Students sorted by Age:");
            foreach (Student st in sorted)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public void ShowStudentsFromUniversity(string universityName)
        {
            IEnumerable<Student> mitStudents = from student in this.students
                                               join univeristy in this.universities
                                               on student.UniverityId equals univeristy.Id
                                               where univeristy.Name == universityName
                                               select student;
            Console.WriteLine("{0} Students:", universityName);
            foreach (Student st in mitStudents)
            {
                Console.WriteLine(st.ToString());
            }
        }
    }

    
}
