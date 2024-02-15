using Business.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        CourseDal courseDal = new CourseDal();
        public void TDelete(int id)
        {
            courseDal.Delete(id);
        }

        public List<Course> TGetAll()
        {
            return courseDal.GetAll();
        }

        public Course TGetById(int id)
        {
            return courseDal.GetById(id);
        }

        public void TInsert(Course course)
        {
            courseDal.Insert(course);
        }

        public void TUpdate(Course course)
        {
            courseDal.Update(course);
        }
    }
}
