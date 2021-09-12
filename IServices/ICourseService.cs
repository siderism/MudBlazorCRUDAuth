using final.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final.IServices
{
    public interface ICourseService
    {
        List<Course> GetCourses();
        Course GetCourseById(int id);
        void Save(Course course);
        string Delete(int id);
        }
}
