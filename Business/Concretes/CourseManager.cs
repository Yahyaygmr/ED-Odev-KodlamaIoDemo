using Business.Abstracts;
using DataAccess.Abstracts;
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
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void TDelete(int id)
        {
            _courseDal.Delete(id);
        }

        public List<Course> TGetAll()
        {
            return _courseDal.GetAll();
        }

        public Course TGetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void TInsert(Course course)
        {
            _courseDal.Insert(course);
        }

        public void TUpdate(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
