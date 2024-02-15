using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        List<Instructor> TGetAll();
        void TInsert(Instructor ınstructor);
        void TUpdate(Instructor ınstructor);
        void TDelete(int id);
        Instructor TGetById(int id);
    }
}
