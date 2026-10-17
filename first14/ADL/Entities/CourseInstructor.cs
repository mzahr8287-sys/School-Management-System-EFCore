using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace first14.ADL.Entities
{
    internal class CourseInstructor
    {
        
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string Evaluation { get; set; }
    }
}
