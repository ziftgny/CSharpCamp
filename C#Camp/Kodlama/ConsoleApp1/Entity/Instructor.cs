using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Instructor
    {
        public Instructor(int instructorId, string instructorName)
        {
            InstructorId = instructorId;
            InstructorName = instructorName;
            InstructorCourses = new List<Course>();
        }

        public int InstructorId { get; set; }
        public string InstructorName { get; set; }    
        public List<Course> InstructorCourses { get; set; }
    }
}
