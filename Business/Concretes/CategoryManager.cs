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
    public class CategoryManager : ICategoryService
    {
        CategoryDal categoryDal = new CategoryDal();
        public void TDelete(int id)
        {
            categoryDal.Delete(id);
        }

        public List<Category> TGetAll()
        {
            return categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return categoryDal.GetById(id);
        }

        public void TInsert(Category category)
        {
            categoryDal.Insert(category);
        }

        public void TUpdate(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
