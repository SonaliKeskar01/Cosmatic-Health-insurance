using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementConsoleApp
{
    public class StudentBL
    {
        StudentDB _db;

        public StudentBL()
        { 
            _db=new StudentDB();
           }

        public List<Student> Students()
        {
            return _db.Students();

        }

        public Student StudentById(int id)
        {
            return _db.StudentById(id);
        }

        public bool Create(Student student)
        {
            return _db.Create(student);
        }

        public bool Update(int id, Student student)
        {
            return _db.Update(id, student);
        }

        public bool Delete(int id)
        {
            return _db.Delete(id);
        }

        public bool ArchieveStudents()
        {
            return _db.ArchieveToStudents();
        }
    }
}
