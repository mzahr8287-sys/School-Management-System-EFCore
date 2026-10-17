using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace first14.ADL.Entities
{
    internal class Course
    {
        [Key]
        public int CID { get; set; }
        [MaxLength(6)]
        public string CName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Desc { get; set; }
        public int Duration { get; set; }
        
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }
        public List<CourseInstructor> CourseInstructor { get; set; }
    }
}
