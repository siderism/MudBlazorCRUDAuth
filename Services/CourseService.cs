using final.Data;
using final.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final.Services
{
    public class CourseService : ICourseService
    {

        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public string Delete(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.Id == id);
        }

        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }

        public void Save(Course course)
        {
            int coursesOnDb = _context.Courses.Where(c => c.Name == course.Name).Count();

            if (coursesOnDb > 0)
            {
                return;
            }
            if (course.Id == 0)
            {
                _context.Courses.Add(course);
            }
            else
            {
                _context.Courses.Update(course);
            }
            _context.SaveChanges();
        }
    }
}
