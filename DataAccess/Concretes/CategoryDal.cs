using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {

        public void Delete(int id)
        {
            DemoContext context = new DemoContext();

            var category = context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            context.Categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            DemoContext context = new DemoContext();

            return context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            DemoContext context = new DemoContext();

            return context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
        }

        public void Insert(Category category)
        {
            DemoContext context = new DemoContext();

            context.Categories.Add(category);
        }

        public void Update(Category category)
        {
            DemoContext context = new DemoContext();
            var ctgr = context.Categories.Where(x => x.CategoryId == category.CategoryId).FirstOrDefault();
            context.Categories.Remove(ctgr);

            Category categoryYeni = new Category()
            {
                CategoryId = category.CategoryId,
                Name = category.Name
            };
            context.Categories.Add(categoryYeni);
        }
    }
}
