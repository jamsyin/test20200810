using JLQStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLQStudent.DataReposittories
{
    public interface  IStudentRepository
    {
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudents();
        Student Add(Student student);
        Student Insert(Student student);
        Student Update(Student updatestudent);
        Student Delete(int id);
    }
}
