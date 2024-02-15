using DataAccess.Concretes;
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
            var list = categoryDal.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
