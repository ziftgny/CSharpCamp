using ConsoleApp1.Business.Abstracts;
using ConsoleApp1.DataAccess.Abstracts;
using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _coursedal;
        public CourseManager(ICourseDal coursedal)
        { 
            _coursedal = coursedal;
        }
        public void Add(Course course)
        {
            _coursedal.Add(course);
        }

        public void Delete(int id)
        {
            _coursedal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _coursedal.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _coursedal.GetCourseById(id);
        }

        public void Update(Course course)
        {
            _coursedal.Add(course);
        }
    }
}
