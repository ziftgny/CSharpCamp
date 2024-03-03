using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Abstracts
{
    public interface ICourseService
    {
        void Add(Course course);
        List<Course> GetAll();
        void Update(Course course);
        void Delete(int id);
        Course GetCourseById(int id);
    }
}
