using final.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final.IServices
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        void Save(Student student);
        string Delete(int id);

    }
}
