using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Classroom;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        private int capacity;
        private int count;

        public Classroom(int capacity)
        {
            this.students = new List<Student>(capacity);
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return students.Count;
            }
        }

        public string RegisterStudent(Student student)
        {
            var result = "No seats in the classroom";

            if (this.Capacity > this.Count)
            {
                result = $"Added student {student.FirstName} {student.LastName}";
                this.students.Add(student);
            }

            return result;
        }

        public string DismissStudent(string firstName, string lastName)
        {
            var result = "Student not found";

            Student student = this.students
                .FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (student != null)
            {
                this.students.Remove(student);
                result = $"Dismissed student {student.FirstName} {student.LastName}";
            }

            return result;
        }

        public string GetSubjectInfo(string subject)
        {

            var sb = new StringBuilder();
            var list = this.students.Where(x => x.Subject == subject).ToList();

            if (!list.Any())
            {
                return "No students enrolled for the subject";
            }

            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            foreach (var item in list)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName}");
            }

            return sb.ToString().Trim();
        }

        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return
                this.students
                .FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }




    }
}
