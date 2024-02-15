using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> TGetAll();
        void TInsert(Category category);
        void TUpdate(Category category);
        void TDelete(int id);
        Category TGetById(int id);
    }
}
