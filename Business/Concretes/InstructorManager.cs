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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal insructorDal)
        {
            _instructorDal = insructorDal;
        }

        public void TDelete(int id)
        {
            _instructorDal.Delete(id);
        }

        public List<Instructor> TGetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor TGetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public void TInsert(Instructor instructor)
        {
            _instructorDal.Insert(instructor);
        }

        public void TUpdate(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}
