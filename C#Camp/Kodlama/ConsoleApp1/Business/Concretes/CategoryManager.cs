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
    public class CategoryManager : ICategoryService
    {
        public ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void AddCourse(Course course,int id)
        {
            _categoryDal.AddCourse(course,id);
        }

        public void Delete(int id)
        {
           _categoryDal.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Add(category);
        }
    }
}
