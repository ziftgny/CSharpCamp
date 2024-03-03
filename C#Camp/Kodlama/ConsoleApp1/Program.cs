// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Business.Abstracts;
using ConsoleApp1.Business.Concretes;
using ConsoleApp1.DataAccess.Concretes;
using ConsoleApp1.Entity;

ICourseService cs1 = new CourseManager(new CourseDal());
cs1.Add(new Course(1, 1, 2, "c#",
    "C# programming",
    75));
cs1.Add(new Course(2, 1, 1, "java",
    "java programming",
    60));
cs1.Add(new Course(3, 2, 1, "javascript",
    "javascript programming",
    50));

IInstructorService is1= new InstructorManager(new InstructorDal());
is1.Add(new Instructor(1, "engin demirog"));
is1.Add(new Instructor(2, "muhammed güney"));
is1.AddCourse(cs1.GetCourseById(1), 1);
is1.AddCourse(cs1.GetCourseById(2), 1);
is1.AddCourse(cs1.GetCourseById(3), 2);

ICategoryService cats1 = new CategoryManager(new CategoryDal());
cats1.AddCourse(cs1.GetCourseById(1), 2);
cats1.AddCourse(cs1.GetCourseById(2), 1);
cats1.AddCourse(cs1.GetCourseById(3), 1);

Console.WriteLine("Courses");
foreach(var course in cs1.GetAll())
{
    Console.WriteLine(course.CourseId+", "+course.InstructorId+", "+course.CategoryId+", "+course.CourseName+", "+
        course.CourseDescription+", "+course.CourseProgress);
}
Console.WriteLine("Instructors");
foreach (var instructor in is1.GetAll())
{
    Console.Write(instructor.InstructorId + ", " + instructor.InstructorName+", ");
    foreach(var course in instructor.InstructorCourses)
    {
        Console.Write(course.CourseName+"| ");
    }
    Console.WriteLine();
}
Console.WriteLine("Categories");
foreach (var category in cats1.GetAll())
{
    Console.Write(category.CategoryId + ", " + category.CategoryName + ", ");
    foreach (var course in category.CategoryCourses)
    {
        Console.Write(course.CourseName + "| ");
    }
    Console.WriteLine();
}



