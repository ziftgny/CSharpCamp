using ConsoleApp1.DataAccess.Abstracts;
using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {

            categories = new List<Category>();
            categories.Add(new Category(1, "web programming"));
            categories.Add(new Category(2, "desktop app programming"));
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void AddCourse(Course course,int id)
        {
            Category category = categories.Where(p => p.CategoryId == id).First();
            category.CategoryCourses.Add(course);
        }

        public void Delete(int id)
        {
            categories.Remove(categories.Where(p => p.CategoryId == id).First());

        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            categories.Add(category);
        }
    }
}
