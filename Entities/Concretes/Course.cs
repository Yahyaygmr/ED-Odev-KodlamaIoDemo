using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string CompletionRate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
