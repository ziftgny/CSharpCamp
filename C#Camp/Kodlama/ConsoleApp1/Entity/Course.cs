using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public int InstructorId {  get; set; }
        public int CategoryId {  get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CourseProgress {  get; set; }
        public Course(int courseId, int instructorId,
           int categoryId, string courseName,
           string courseDescription, int courseProgress)
        {
            CourseId = courseId;
            InstructorId = instructorId;
            CategoryId = categoryId;
            CourseName = courseName;
            CourseDescription = courseDescription;
            CourseProgress = courseProgress;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
