using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class DemoContext
    {
        public List<Category> Categories { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }
        public DemoContext()
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
            new Instructor(){InstructorId=1,Name="Engin Demiroğ", ImageUrl="Deneme"}

        };
        public static List<Course> courses = new List<Course>
        {
            new Course() {CourseId=1,ImageUrl="Deneme", Name="2024 yazılım geliştirici yetiştirme kampı(C#)",CategoryId=1,InstructorId=1,CompletionRate="80"}
        };
    }
}
