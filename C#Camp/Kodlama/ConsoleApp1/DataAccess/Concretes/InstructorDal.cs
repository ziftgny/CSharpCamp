using ConsoleApp1.DataAccess.Abstracts;
using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            instructors = new List<Instructor>();
        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void AddCourse(Course course, int id)
        {
            
                Instructor instructor = instructors.Where(p => p.InstructorId == id).First();
                instructor.InstructorCourses.Add(course);
           
        }

        public void Delete(int id)
        {
            instructors.Remove(instructors.Where(p => p.InstructorId == id).First());
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            instructors.Add(instructor);
        }
    }
}
