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
    public class InstructorManager : IInstructorService
    {
        InstructorDal instructorDal = new InstructorDal();
        public void TDelete(int id)
        {
            instructorDal.Delete(id);
        }

        public List<Instructor> TGetAll()
        {
            return instructorDal.GetAll();
        }

        public Instructor TGetById(int id)
        {
            return instructorDal.GetById(id);
        }

        public void TInsert(Instructor instructor)
        {
            instructorDal.Insert(instructor);
        }

        public void TUpdate(Instructor instructor)
        {
            instructorDal.Update(instructor);
        }
    }
}
