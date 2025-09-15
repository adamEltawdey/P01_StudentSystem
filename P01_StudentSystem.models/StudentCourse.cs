using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.models
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public student Student { get; set; }
        public int CourseId { get; set; }
        public course Course { get; set; }
    }
}
