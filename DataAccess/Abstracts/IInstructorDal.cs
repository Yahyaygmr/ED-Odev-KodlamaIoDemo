using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Insert(Instructor ınstructor);
        void Update(Instructor ınstructor);
        void Delete(int id);
        Instructor GetById(int id);
    }
}
