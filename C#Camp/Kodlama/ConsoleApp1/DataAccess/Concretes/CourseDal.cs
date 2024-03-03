using ConsoleApp1.DataAccess.Abstracts;
using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            courses = new List<Course>();
          
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int id)
        {
             courses.Remove(courses.Where(p=>p.CourseId==id).First());
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetCourseById(int id)
        {
            return courses.Where(p=> p.CourseId==id).First();
        }

        public void Update(Course course)
        {
            courses.Add(course);
        }
    }
}
