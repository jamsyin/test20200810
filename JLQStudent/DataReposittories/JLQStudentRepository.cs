using JLQStudent.Models;
using JLQStudent.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLQStudent.DataReposittories
{
    public class JLQStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public JLQStudentRepository()
        
        {
            _studentList = new List<Student>()
            {
                new Student(){Id=1,Name="candy",Major=MajorEnum.ComputerScience,Email="test@163.com"},
                new Student(){Id=2,Name="lily",Major=MajorEnum.EnvironmentEngine,Email="1111@`63.com"},
                new Student(){Id=3,Name="james",Major=MajorEnum.Communication,Email="6666@163.com"}
            };
        }

        
        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }
        public Student Add(Student student)
        {
            student.Id = _studentList.Max(s => s.Id) + 1;
            _studentList.Add(student);
            return student;
        }

        public Student Insert(Student student)
        {
            student.Id = _studentList.Max(s => s.Id) +1;
            _studentList.Add(student);
            return student;
        }

        public Student Update(Student updatestudent)
        {
            Student student = _studentList.FirstOrDefault(s => s.Id == updatestudent.Id);
            if(student != null)
            {
                student.Name = updatestudent.Name;
                student.Email = updatestudent.Email;
                student.Major = updatestudent.Major;
                return student;
            }
            return null;
        }

        public Student Delete(int id)
        {
            Student student = _studentList.FirstOrDefault(s => s.Id == id);
            if(student != null)
            {
                _studentList.Remove(student);
                return student;
            }
            return null;
        }
    }


}
