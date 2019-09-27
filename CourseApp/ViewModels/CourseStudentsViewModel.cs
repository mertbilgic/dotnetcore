using System.Collections.Generic;
using CourseApp.Models;

namespace CourseApp.ViewModels
{
    public class CourseStudentsViewModel
    {
        public Course Course { get; set; }
        public List<StudentData> Students { get; set; }
    }
}