using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Category
    {
        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            CategoryCourses = new List<Course>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Course> CategoryCourses { get; set; }
    }
}
