using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace first14.ADL.Entities
{
    internal class Student
    {
        [Key]
        public int SID { get; set; }
        [MaxLength(100)]
        public string Fname { get; set; }
        [MaxLength(100)]
        public string Lname { get; set; }
        [Range(20,40)]
        public int Age { get; set; }
        public string Address { get; set; }
        
        public int DepartmentID { get; set; }
        public Department department { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }
        
        public int? SuperId { get; set; }
        public Student Super { get; set; }
        public List<Student> Supers { get; set; }

    }
}
