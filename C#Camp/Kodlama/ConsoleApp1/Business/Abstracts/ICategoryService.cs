using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(Category category);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(int id);
        void AddCourse(Course course, int id);

    }
}
