﻿using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        List<Instructor> GetAll();
        void Update(Instructor instructor);
        void Delete(int id);
        void AddCourse(Course course, int id);
    }
}
