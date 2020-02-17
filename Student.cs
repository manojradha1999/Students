using System;

namespace Students.Data
{
    public class Student
    {
        public string StudentName { get; set; }
        public double Cgpa { get; set; }
        public string Department { get; set; }
        public string StudentId { get; set; }
        public byte Year { get; set; }
        public Student(string name, string department, string id, byte year, double cgpa)
        {
            this.StudentName = name;
            this.Department = department;
            this.StudentId = id;
            this.Year = year;
            this.Cgpa = cgpa;
        }
        public Student(Student student)
        {
            this.StudentName = student.StudentName;
            this.Department = student.Department;
            this.StudentId = student.StudentId;
            this.Year = student.Year;
            this.Cgpa =student.Cgpa;
        }
        public Student()
        {

        }
    }
}
