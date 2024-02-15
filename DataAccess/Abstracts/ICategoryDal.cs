using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);
        Category GetById(int id);
    }
}
