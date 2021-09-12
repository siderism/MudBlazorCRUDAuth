using final.Data;
using final.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public string Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.SingleOrDefault(s => s.Id == id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public void Save(Student student)
        {
            int coursesOnDb = _context.Students.Where(s => s.Email == student.Email).Count();

            if (coursesOnDb > 0)
            {
                return;
            }
            if (student.Id == 0)
            {
                _context.Students.Add(student);
            }
            else
            {
                _context.Students.Update(student);
            }
            _context.SaveChanges();
        }
    }
}
