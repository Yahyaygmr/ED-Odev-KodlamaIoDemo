using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        public void Delete(int id)
        {
            DemoContext context = new DemoContext();

            var course = context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
            context.Courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            DemoContext context = new DemoContext();

            return context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            DemoContext context = new DemoContext();

            return context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
        }

        public void Insert(Course course)
        {
            DemoContext context = new DemoContext();

            context.Courses.Add(course);
        }

        public void Update(Course course)
        {
            DemoContext context = new DemoContext();
            var cou = context.Courses.Where(x => x.CourseId == course.CourseId).FirstOrDefault();
            context.Courses.Remove(cou);

            Course courseYeni = new Course()
            {
                CourseId = course.CourseId,
                Name = course.Name,
                ImageUrl = course.ImageUrl,
                CompletionRate = course.CompletionRate,
                CategoryId = course.CategoryId,
                InstructorId = course.InstructorId
            };
            context.Courses.Add(courseYeni);
        }
    }
}
