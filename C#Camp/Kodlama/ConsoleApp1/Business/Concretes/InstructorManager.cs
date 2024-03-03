using ConsoleApp1.Business.Abstracts;
using ConsoleApp1.DataAccess.Abstracts;
using ConsoleApp1.DataAccess.Concretes;
using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        public IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor); 
        }
        public void AddCourse(Course course, int id)
        {
            _instructorDal.AddCourse(course, id);
        }
        public void Delete(int id)
        {
            _instructorDal.Delete(id);  
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }
    }
}
