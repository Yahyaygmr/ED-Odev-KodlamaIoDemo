using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class DemeoContext
    {
        public List<Category> Categories { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }
        public DemeoContext()
        {
            Categories = categories;
            Courses = courses;
            Instructors = instructors;
            
        }
        public static List<Category> categories = new List<Category>
            {
                new Category() {CategoryId=1,Name="C#"},
                new Category() {CategoryId=2,Name="Java"}
            };
        public static List<Instructor> instructors = new List<Instructor>
        {

        };
        public static List<Course> courses = new List<Course>
        {

        };
    }
}
