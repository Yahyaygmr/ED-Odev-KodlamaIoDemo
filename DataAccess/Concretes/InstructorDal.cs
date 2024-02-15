using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        public void Delete(int id)
        {
            DemoContext context = new DemoContext();

            var instructor = context.Instructors.Where(x => x.InstructorId == id).FirstOrDefault();
            context.Instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            DemoContext context = new DemoContext();

            return context.Instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            DemoContext context = new DemoContext();

            return context.Instructors.Where(x => x.InstructorId == id).FirstOrDefault();
        }

        public void Insert(Instructor instructor)
        {
            DemoContext context = new DemoContext();

            context.Instructors.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            DemoContext context = new DemoContext();
            var inst = context.Instructors.Where(x => x.InstructorId == instructor.InstructorId).FirstOrDefault();
            context.Instructors.Remove(inst);

            Instructor instructorYeni = new Instructor()
            {
                InstructorId = instructor.InstructorId,
                Name = instructor.Name,
                ImageUrl = instructor.ImageUrl,
                Courses = instructor.Courses
            };
            context.Instructors.Add(instructorYeni);
        }
    }
}
