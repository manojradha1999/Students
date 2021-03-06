﻿using System;
using Students.Data;
using System.Collections.Generic;

namespace Students.Repositery
{
    public class Repository
    {
        public static List<Student> student = new List<Student>();
        static Repository()
        {
            student.Add(new Student("Manoj", "Mech", "16Mech70", 4, 7.1));
            student.Add(new Student("Mithun", "ECE", "17ECE32", 3, 8.2));
            student.Add(new Student("Basidh", "IT", "16IT05", 4, 8));
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return student;
        }
        public  void AddStudent(Student students)
        {
           student.Add(students);
        }
        public Student GetStudent(string studentId)
        {
            return student.Find(id => id.StudentId == studentId);
        }
        public void DeleteStudent(string studentId)
        {
            Student students = GetStudent(studentId);
            if (student != null)
                student.Remove(students);
        }
    }
}

