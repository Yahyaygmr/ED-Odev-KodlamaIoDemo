using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryDal categoryDal = new CategoryDal();
            CategoryDal categoryDal2 = new CategoryDal();

            var category1 = new Category();
            var category2 = new Category();
            var category3 = new Category();

            category1.CategoryId = 3;
            category1.Name = "Javascript";

            category2.CategoryId = 4;
            category2.Name = "PHP";
            categoryDal.Insert(category1);
            categoryDal.Insert(category2);

            var list = categoryDal.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine("Category Id: " + item.CategoryId + "  Category :" + item.Name);
            }
            Console.WriteLine("---------------------Güncelleme Sonrası------------------");
            category3.Name = ".Net";
            category3.CategoryId = 4;
            categoryDal2.Delete(3);
            categoryDal2.Update(category3);
            var newList = categoryDal2.GetAll();
            foreach (var item in newList)
            {
                Console.WriteLine("Category Id: " + item.CategoryId + "  Category :" + item.Name);
            }
            //Business Layer
            Console.WriteLine("---------------------Business Katmanı Sonrası------------------");
            ICategoryService categoryService = new CategoryManager(new CategoryDal());
            Category category5 = new Category()
            {
                CategoryId = 5,
                Name = "Sql Server"
            };
            categoryService.TInsert(category5);

            var list2 = categoryService.TGetAll();
            foreach (var item in list2)
            {
                Console.WriteLine("Category Id: " + item.CategoryId + "  Category :" + item.Name);
            }
            Console.ReadLine();
        }
    }
}
